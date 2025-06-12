using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorSystem
{
    public partial class MainForm : Form
    {
        private readonly Elevator elevator;
        private readonly List<Person> people = new List<Person>();
        private string selectedPerson = "";
        private readonly Dictionary<int, Button> floorButtons = new Dictionary<int, Button>();
        private readonly HashSet<int> requestedFloors = new HashSet<int>();
        public MainForm()
        {
            InitializeComponent();
            InitializePeople();
            InitializeFloorButtons();

            elevator = new Elevator(lblCurrentFloor, lblDirection);
            elevator.UpdateElevatorPosition += HandleElevatorMovement;
        }

        private void InitializePeople()
        {
            people.Add(new Person
            {
                Name = "A",
                StatusLabel = lblStatusA,
                CurrentFloorBox = txtCurrentA,
                TargetLabel = lblTargetA
            });

            people.Add(new Person
            {
                Name = "B",
                StatusLabel = lblStatusB,
                CurrentFloorBox = txtCurrentB,
                TargetLabel = lblTargetB
            });

            people.Add(new Person
            {
                Name = "C",
                StatusLabel = lblStatusC,
                CurrentFloorBox = txtCurrentC,
                TargetLabel = lblTargetC
            });

            people.Add(new Person
            {
                Name = "D",
                StatusLabel = lblStatusD,
                CurrentFloorBox = txtCurrentD,
                TargetLabel = lblTargetD
            });

            UpdateAllPeopleStatus();
        }

        private void InitializeFloorButtons()
        {
            for (int i = 1; i <= 15; i++)
            {
                var btn = Controls.Find($"btnFloor{i}", true)[0] as Button;
                floorButtons.Add(i, btn);
                btn.Click += FloorButton_Click;
                btn.BackColor = SystemColors.Control;
            }
        }

        private void UpdateAllPeopleStatus()
        {
            foreach (var person in people)
            {
                person.UpdateStatus();
            }
        }

        private void FloorButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPerson)) return;

            var btn = sender as Button;

            if (int.TryParse(btn.Text, out int floor))
            {
                var person = people.Find(p => p.Name == selectedPerson);
                if (person.CurrentFloor == floor) return;

                // 如果之前有設定目標樓層，先清除舊的請求
                if (person.TargetFloor > 0 && floorButtons.ContainsKey(person.TargetFloor))
                {
                    requestedFloors.Remove(person.TargetFloor);
                    floorButtons[person.TargetFloor].BackColor = SystemColors.Control;
                }

                person.TargetFloor = floor;
                person.UpdateStatus();

                // 標記新請求
                requestedFloors.Add(floor);
                btn.BackColor = Color.Red;

                UpdateElevatorDirection();
            }
            else
            {
                MessageBox.Show($"無效的樓層格式: {btn.Text}");
            }
        }



        private void PersonButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            selectedPerson = btn.Text;
        }



        private void HandleElevatorMovement(int currentFloor)
        {
            foreach (var person in people)
            {
                if (person.InElevator && person.TargetFloor == currentFloor)
                {
                    person.InElevator = false;
                    person.CurrentFloor = currentFloor;
                    person.TargetFloor = 0;
                    person.UpdateStatus();

                    
                    if (requestedFloors.Contains(currentFloor))
                    {
                        requestedFloors.Remove(currentFloor);
                        floorButtons[currentFloor].BackColor = SystemColors.Control;
                    }
                }
            }

            
            foreach (var person in people)
            {
                if (!person.InElevator &&
                    person.CurrentFloor == currentFloor &&
                    person.TargetFloor > 0)
                {
                    // 檢查方向是否符合或電梯停止
                    bool directionMatch = (elevator.Direction is UpDirection && person.TargetFloor > currentFloor) ||
                                        (elevator.Direction is DownDirection && person.TargetFloor < currentFloor) ||
                                        (elevator.Direction is StopDirection);

                    if (directionMatch)
                    {
                        person.InElevator = true;
                        person.UpdateStatus();
                    }
                }
            }

            UpdateElevatorDirection();
        }

        private void UpdateElevatorDirection()
        {
            if (requestedFloors.Count == 0 && !people.Any(p => p.InElevator))
            {
                elevator.SetDirection(new StopDirection());
                return;
            }

            // 收集所有未完成的請求
            var allRequests = new HashSet<int>(requestedFloors);
            foreach (var person in people)
            {
                if (person.InElevator && person.TargetFloor > 0)
                {
                    allRequests.Add(person.TargetFloor);
                }
                else if (!person.InElevator && person.TargetFloor > 0)
                {
                    allRequests.Add(person.CurrentFloor);
                    allRequests.Add(person.TargetFloor);
                }
            }

            if (allRequests.Count == 0)
            {
                elevator.SetDirection(new StopDirection());
                return;
            }

            int minRequest = allRequests.Min();
            int maxRequest = allRequests.Max();

            // 決定移動方向
            if (elevator.CurrentFloor < minRequest)
            {
                elevator.SetDirection(new UpDirection());
            }
            else if (elevator.CurrentFloor > maxRequest)
            {
                elevator.SetDirection(new DownDirection());
            }
            else if (elevator.Direction is UpDirection && elevator.CurrentFloor < maxRequest)
            {
                elevator.SetDirection(new UpDirection());
            }
            else if (elevator.Direction is DownDirection && elevator.CurrentFloor > minRequest)
            {
                elevator.SetDirection(new DownDirection());
            }
            else
            {

                if (!allRequests.Contains(elevator.CurrentFloor))
                {
                    int closestUp = allRequests.Where(f => f > elevator.CurrentFloor).OrderBy(f => f).FirstOrDefault();
                    int closestDown = allRequests.Where(f => f < elevator.CurrentFloor).OrderByDescending(f => f).FirstOrDefault();

                    if (closestUp > 0 && closestDown > 0)
                    {
                        if (closestUp - elevator.CurrentFloor <= elevator.CurrentFloor - closestDown)
                        {
                            elevator.SetDirection(new UpDirection());
                        }
                        else
                        {
                            elevator.SetDirection(new DownDirection());
                        }
                    }
                    else if (closestUp > 0)
                    {
                        elevator.SetDirection(new UpDirection());
                    }
                    else if (closestDown > 0)
                    {
                        elevator.SetDirection(new DownDirection());
                    }
                }
            }
        }
        private void HandleFloorButtonClick(object sender)
        {
            if (string.IsNullOrEmpty(selectedPerson)) return;

            var btn = sender as Button;

            if (int.TryParse(btn.Text, out int floor))
            {
                var person = people.Find(p => p.Name == selectedPerson);
                if (person.CurrentFloor == floor) return;

                
                if (person.TargetFloor > 0 && floorButtons.ContainsKey(person.TargetFloor))
                {
                    requestedFloors.Remove(person.TargetFloor);
                    floorButtons[person.TargetFloor].BackColor = SystemColors.Control;
                }

                person.TargetFloor = floor;
                person.UpdateStatus();

                
                requestedFloors.Add(floor);
                btn.BackColor = Color.Red;

                UpdateElevatorDirection();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            elevator.Start();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            foreach (var person in people)
            {
                person.CurrentFloor = rand.Next(1, 16);
                person.TargetFloor = 0;
                person.InElevator = false;
                person.UpdateStatus();
            }

            
            foreach (var btn in floorButtons.Values)
            {
                btn.BackColor = SystemColors.Control;
            }
            requestedFloors.Clear();

            UpdateElevatorDirection();
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            selectedPerson = "A";        }

        private void btnB_Click(object sender, EventArgs e)
        {
            selectedPerson = "B";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            selectedPerson = "C";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            selectedPerson = "D";
        }

        private void btnFloor1_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor2_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor3_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor4_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor5_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor6_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor7_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor8_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor9_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor10_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor11_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor12_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor13_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor14_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }

        private void btnFloor15_Click(object sender, EventArgs e)
        {
            HandleFloorButtonClick(sender);
        }
    }
}
