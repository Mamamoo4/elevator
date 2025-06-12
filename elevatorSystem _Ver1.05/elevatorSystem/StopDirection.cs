using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace elevatorSystem
{
    public class StopDirection : IElevatorDirection
    {
        public void UpdateDirectionLabel(Label label)
        {
            label.Text = "■";
            label.ForeColor = Color.Black;
        }
    }

}
