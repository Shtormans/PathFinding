using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinding
{
    class PathButton
    {
        public readonly Button button;
        private Status buttonStatus;
        public readonly Point position;
        private Point lastPosition;

        public Status ButtonStatus
        {
            get { return buttonStatus; }
        }

        public Point LastPosition
        {
            get { return lastPosition; }
        }

        public PathButton(int index_i, int index_j, int x, int y, int buttonSize, Color color, EventHandler unusedButton_MouseEnter)
        {
            position = new Point(index_j, index_i);

            button = new Button()
            {
                Size = new System.Drawing.Size(buttonSize, buttonSize),
                Location = new System.Drawing.Point(x, y),
                FlatStyle = FlatStyle.Flat,
                BackColor = color
            };
            button.FlatAppearance.BorderSize = 0;
            button.Location = new System.Drawing.Point(x, y);
            buttonStatus = Status.unused;
            button.MouseEnter += unusedButton_MouseEnter;
        }

        public void ChangenStatus(Status status, Color color)
        {
            buttonStatus = status;
            button.BackColor = color;
        }

        public void InputLastPosition(Point position)
        {
            lastPosition = position;
        }
    }
}
