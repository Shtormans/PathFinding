using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PathFinding
{
    class PathButton
    {
        private Button button;
        public Status buttonStatus 
        { 
            get { return buttonStatus; } 
            set { SetButtonStatus(value); } 
        }

        public PathButton(int x, int y)
        {
            button = new Button();
            button.Location = new System.Drawing.Point(x, y);
            buttonStatus = Status.unused;
        }
        public void SetButtonStatus(Status status)
        {
            if (buttonStatus == Status.unused)
            {
                buttonStatus = status;
            }
        }
    }
}
