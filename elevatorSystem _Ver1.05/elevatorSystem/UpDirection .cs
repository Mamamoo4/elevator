using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace elevatorSystem
{
    public class UpDirection : IElevatorDirection
    {
        public void UpdateDirectionLabel(Label label)
        {
            label.Text = "↑";
            label.ForeColor = Color.Red;
        }
    }
}
