using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using TextBox = System.Windows.Forms.TextBox;

namespace elevator
{
    public partial class Form1 : Form
    {
        private Elevator elevator = new Elevator();
        private List<Person> people = new List<Person>();
        private Stopwatch stopwatch = new Stopwatch();
        private Timer timer = new Timer();
        private int secondsElapsed = 0;
        public Form1()
        {
            InitializeComponent();
            InitializePeople();
            InitializeTimer();
            UpdateUI();
        }

        private void InitializePeople()
        {
            people = new List<Person>
            {
                new Person { Name = "A" },
                new Person { Name = "B" },
                new Person { Name = "C" },
                new Person { Name = "D" }
            };
        }
        // 預設4個人名

        private void InitializeTimer()
        {
            timer.Interval = 1000;
            // 1秒
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            secondsElapsed++;
            lblTime.Text = $"時間: {secondsElapsed}";

            // 檢查是否所有人都已完成或未設定
            bool allInactive = people.All(p =>
                (p.CurrentFloor == 0 && p.TargetFloor == 0) ||
                p.HasFinished);

            if (allInactive)
            {
                timer.Stop();
                return;
            }

            // 檢查是否有新的活動人員
            bool hasActivePerson = people.Any(p =>
                !p.HasFinished &&
                p.CurrentFloor >= 1 && p.CurrentFloor <= 10 &&
                p.TargetFloor >= 1 && p.TargetFloor <= 10);

            if (!timer.Enabled && hasActivePerson)
            {
                timer.Start();
            }

            // 設定2秒移動一層樓
            if (secondsElapsed % 2 == 0 && hasActivePerson)
            {
                elevator.Move(people);
                elevator.UpdatePassengers(people);
            }

            UpdateUI();
        }

        private void UpdateUI()
        {
            // 更新目前電梯樓層
            lblElevatorFloor.Text = $"目前樓層 : {elevator.CurrentFloor} ";
            lblElevatorDirection.Text = $"方向 : {(elevator.Direction == Direction.Up ? "向上" : "向下")}";
            lblElevatorDirection.ForeColor =  (elevator.Direction == Direction.Up ? Color.Red : Color.Green);

            //更新電梯內人員
            var currentPassengers = elevator.Passengers.Where(p => p.TargetFloor != elevator.CurrentFloor).Select(p => p.Name);
            lblElevatorPassengers.Text = "電梯內人員有 : " + (currentPassengers.Any() ? string.Join(", ", currentPassengers) : " 0 人");

            //更新人員燈號狀態
            UpdatePersonStatus(people[0], txtName1, numCurrentFloor1, numTargetFloor1, panelLight1);
            UpdatePersonStatus(people[1], txtName2, numCurrentFloor2, numTargetFloor2, panelLight2);
            UpdatePersonStatus(people[2], txtName3, numCurrentFloor3, numTargetFloor3, panelLight3);
            UpdatePersonStatus(people[3], txtName4, numCurrentFloor4, numTargetFloor4, panelLight4);

        }

        private void UpdatePersonStatus(Person person, TextBox txtName, NumericUpDown numCurrent, NumericUpDown numTarget, Panel light)
        {
            person.Name = txtName.Text;

            // 只有當人員未完成時才更新樓層資訊
            if (!person.HasFinished)
            {
                person.CurrentFloor = (int)numCurrent.Value;
                person.TargetFloor = (int)numTarget.Value;
            }

            if (person.InElevator && person.TargetFloor != elevator.CurrentFloor)
            {
                light.BackColor = Color.Green; // 在電梯中且未到達目標樓層
            }
            else if (person.InElevator && person.TargetFloor == elevator.CurrentFloor)
            {
                // 到達目標樓層時變黃色
                light.BackColor = Color.Yellow;
                // 標記為已離開電梯
                person.InElevator = false;
            }
            else if (person.HasFinished)
            {
                // 已完成的人員
                light.BackColor = Color.Gray;
                numCurrent.Value = 0;
                numTarget.Value = 0;
            }
            else
            {
                // 不在電梯中
                light.BackColor = Color.Yellow;
            }
        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
            stopwatch.Stop();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stopwatch.Stop();            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            stopwatch.Reset();
            secondsElapsed = 0;
            lblTime.Text = "時間 : 0秒";

            elevator = new Elevator();
            InitializePeople();

            //清除人名輸入
            txtName1.Text = "A";
            txtName2.Text = "B";
            txtName3.Text = "C";
            txtName4.Text = "D";

            numCurrentFloor1.Value = 1;
            numCurrentFloor2.Value = 1;
            numCurrentFloor3.Value = 1;
            numCurrentFloor4.Value = 1;

            numTargetFloor1.Value = 1;
            numTargetFloor2.Value = 1;
            numTargetFloor3.Value = 1;
            numTargetFloor4.Value = 1;

            // 重置人員狀態
            foreach (var person in people)
            {
                person.HasFinished = false;
                person.InElevator = false;
            }

            UpdateUI();
        }

        private Person GetPersonForControl(Control ctrl)
        {
            if (ctrl == numCurrentFloor1 || ctrl == numTargetFloor1) return people[0];
            if (ctrl == numCurrentFloor2 || ctrl == numTargetFloor2) return people[1];
            if (ctrl == numCurrentFloor3 || ctrl == numTargetFloor3) return people[2];
            if (ctrl == numCurrentFloor4 || ctrl == numTargetFloor4) return people[3];
            return null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown num = sender as NumericUpDown;
            if (num != null)
            {
                // 確保樓層在0-10之間
                if (num.Value < 0) num.Value = 0;
                if (num.Value > 10) num.Value = 10;

                // 如果當前樓層或目標樓層從0變為有效值，重置HasFinished
                var person = GetPersonForControl(num);
                if (person != null && (num.Value >= 1 && num.Value <= 10))
                {
                    person.HasFinished = false;
                }
            }
            UpdateUI();
        }

        private void dgvLog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
