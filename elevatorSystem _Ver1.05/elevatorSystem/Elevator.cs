using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorSystem
{
    public class Elevator
    {
        public int CurrentFloor { get; private set; } = 1;
        public IElevatorDirection Direction { get; private set; } = new StopDirection();
        private readonly Label currentFloorLabel;
        private readonly Label directionLabel;
        private readonly Timer timer;

        public Elevator(Label floorLabel, Label dirLabel)
        {
            currentFloorLabel = floorLabel;
            directionLabel = dirLabel;

            timer = new Timer { Interval = 1000 };
            timer.Tick += (s, e) => Move();
        }

        public void Start() => timer.Start();
        public void Stop() => timer.Stop();

        public void SetDirection(IElevatorDirection newDirection)
        {
            Direction = newDirection;
            Direction.UpdateDirectionLabel(directionLabel);
        }

        private void Move()
        {
            if (Direction is UpDirection)
                CurrentFloor++;
            else if (Direction is DownDirection)
                CurrentFloor--;

            // 確保不會超出範圍
            CurrentFloor = Math.Max(1, Math.Min(15, CurrentFloor));

            currentFloorLabel.Text = CurrentFloor.ToString();
            UpdateElevatorPosition?.Invoke(CurrentFloor);
        }

        public event Action<int> UpdateElevatorPosition;
    }
}

