using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace elevatorSystem
{
    public class Person
    {
        public string Name { get; set; }
        public int CurrentFloor { get; set; } = 1;
        public int TargetFloor { get; set; }
        public bool InElevator { get; set; }
        public Label StatusLabel { get; set; }
        public TextBox CurrentFloorBox { get; set; }
        public Label TargetLabel { get; set; }

        public void UpdateStatus()
        {
            if (TargetFloor == 0)
            {
                StatusLabel.BackColor = Color.Gray;  // 未設定目標樓層
            }
            else if (InElevator)
            {
                StatusLabel.BackColor = Color.Green; // 在電梯內
            }
            else
            {
                StatusLabel.BackColor = Color.Yellow; // 等待中
            }

            CurrentFloorBox.Text = CurrentFloor.ToString();
            TargetLabel.Text = TargetFloor > 0 ? TargetFloor.ToString() : "";
        }
    }
}
