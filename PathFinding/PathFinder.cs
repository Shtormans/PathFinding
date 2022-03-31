using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinding
{
    enum Status
    {
        border,
        startPoint,
        endPoint,
        used,
        unused,
        path
    }
    public partial class PathFinder : Form
    {
        private readonly int height;
        private readonly int width;
        private readonly int matrixHeight;
        private readonly int matrixWidth;
        private const int buttonSize = 15;
        private const int borderLength = 20;
        private const int topMargin = 100;
        private readonly Color unusedColor = Color.White;
        private readonly Color usedColor = Color.Gray;
        private readonly Color borderColor = Color.Red;
        private readonly Color startPointColor = Color.Violet;
        private readonly Color endPointColor = Color.Purple;
        private readonly Color pathColor = Color.Green;
        private Status currentStatus;
        private Color currentColor;
        private bool startPointExist = false;
        private bool endPointExist = false;
        private Point startPointPosition;
        Form1 form1;

        private PathButton[,] buttons;

        public PathFinder(int height, int width, Form1 form1)
        {
            InitializeComponent();

            currentStatus = Status.border;
            currentColor = borderColor;

            this.height = height;
            this.width = width;

            this.form1 = form1;

            matrixHeight = (height - borderLength - topMargin) / buttonSize - 1;
            matrixWidth = (width - borderLength * 2) / buttonSize - 1;

            ChangeButtonsColor();

            buttons = new PathButton[matrixHeight, matrixWidth];

            InitializeScreen();
        }

        private void ChangeButtonsColor()
        {
            rubberButton.BackColor = unusedColor;
            borderButton.BackColor = borderColor;
            startPointButton.BackColor = startPointColor;
            endPointButton.BackColor = endPointColor;
        }

        private void InitializeScreen()
        {
            for (int i = 0; i < matrixHeight; i++)
            {
                for (int j = 0; j < matrixWidth; j++)
                {
                    int pos_x = borderLength + buttonSize * j;
                    int pos_y = topMargin + buttonSize * i;

                    buttons[i, j] = new PathButton(i, j, pos_x, pos_y, buttonSize, unusedColor, UnusedButton_MouseEnter);
                    this.Controls.Add(buttons[i, j].button);
                }
            }
        }
        private void UnusedButton_MouseEnter(object sender, EventArgs e)
        {
            if (Control.ModifierKeys.HasFlag(Keys.Control))
            {
                int buttonLocY = ((Button)sender).Location.Y;
                int buttonLocX = ((Button)sender).Location.X;
                int i = (buttonLocY - topMargin) / buttonSize;
                int j = (buttonLocX - borderLength) / buttonSize;

                if (currentStatus == Status.startPoint)
                {
                    if (startPointExist)
                    {
                        return;
                    }

                    startPointPosition = new Point(j, i);
                    startPointExist = true;
                }
                else if (currentStatus == Status.endPoint)
                {
                    if (endPointExist)
                    {
                        return;
                    }

                    endPointExist = true;
                }
                else if (buttons[i, j].ButtonStatus == Status.startPoint)
                {
                    startPointExist = false;
                }
                else if (buttons[i, j].ButtonStatus == Status.endPoint)
                {
                    endPointExist = false;
                }

                buttons[i, j].ChangenStatus(currentStatus, currentColor);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            currentStatus = Status.unused;
            currentColor = unusedColor;
        }

        private void BorderButton_Click(object sender, EventArgs e)
        {
            currentStatus = Status.border;
            currentColor = borderColor;
        }

        private void StarPointButton_Click(object sender, EventArgs e)
        {
            currentStatus = Status.startPoint;
            currentColor = startPointColor;
        }

        private void EndPointButton_Click(object sender, EventArgs e)
        {
            currentStatus = Status.endPoint;
            currentColor = endPointColor;
        }

        private void ChangeConfigurationsButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixHeight; i++)
            {
                for (int j = 0; j < matrixWidth; j++)
                {
                    buttons[i, j].ChangenStatus(Status.unused, unusedColor);
                }
            }

            startPointExist = false;
            endPointExist = false;
        }

        private void PathFinder_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!form1.Visible)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (!startPointExist || !endPointExist)
            {
                return;
            }

            int startPosX = startPointPosition.X;
            int startPosY = startPointPosition.Y;
            List<PathButton> nextButtons = new List<PathButton>() { buttons[startPosY, startPosX] };
            StartFindingPath(nextButtons);
        }

        private void StartFindingPath(List<PathButton> nextButtons)
        {
            bool pathNotFound = true;

            while (pathNotFound)
            {
                int length = nextButtons.Count;

                if (length == 0)
                {
                    pathNotFound = false;
                    break;
                }
                for (int i = 0; i < length; i++)
                {
                    if (AddButtonsToList(nextButtons, i))
                    {
                        ShowPath(nextButtons[nextButtons.Count - 1]);
                        pathNotFound = false;
                        break;
                    }

                    i--;

                    if (i == -1)
                    {
                        break;
                    }
                }
            }
        }

        private void ShowPath(PathButton pathButton)
        {
            PathButton curButton = pathButton;
            while (curButton.LastPosition != startPointPosition)
            {
                Point pos = curButton.LastPosition;
                curButton = buttons[pos.Y, pos.X];
                curButton.ChangenStatus(Status.path, pathColor);
            }
        }

        private bool CheckPath(PathButton pathButton)
        {
            return pathButton.ButtonStatus == Status.endPoint;
        }

        private bool AddButtonsToList(List<PathButton> nextButtons, int index)
        {
            Point lastPos = nextButtons[index].position;
            int pos_x = nextButtons[index].position.X;
            int pos_y = nextButtons[index].position.Y;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    if (i != 0 && j != 0)
                    {
                        continue;
                    }

                    int curPosY = pos_y + i;
                    int curPosX = pos_x + j;

                    if (!CheckIndexExist(curPosY, curPosX))
                    {
                        continue;
                    }

                    if (CheckPath(buttons[curPosY, curPosX]))
                    {
                        buttons[curPosY, curPosX].InputLastPosition(lastPos);
                        nextButtons.Add(buttons[curPosY, curPosX]);
                        return true;
                    }
                    if (CheckButtonPosition(curPosY, curPosX))
                    {
                        buttons[curPosY, curPosX].InputLastPosition(lastPos);
                        nextButtons.Add(buttons[curPosY, curPosX]);

                    }
                }
            }

            nextButtons.RemoveAt(index);

            return false;
        }

        private bool CheckIndexExist(int pos_y, int pos_x)
        {
            if (pos_x < 0 || pos_x >= matrixWidth
                || pos_y < 0 || pos_y >= matrixHeight)
            {
                return false;
            }

            return true;
        }

        private bool CheckButtonPosition(int pos_y, int pos_x)
        {
            if (buttons[pos_y, pos_x].ButtonStatus != Status.unused)
            {
                return false;
            }

            buttons[pos_y, pos_x].ChangenStatus(Status.used, usedColor);
            return true;
        }
    }
}
