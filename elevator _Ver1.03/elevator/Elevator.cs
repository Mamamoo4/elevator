using System;
using System.Collections.Generic;
using System.Linq;

namespace elevator
{
    public class Elevator : IElevator
    {
        public int CurrentFloor { get; set; } = 10;
        public Direction Direction { get; set; } = Direction.Down;
        public List<Person> Passengers { get; set; } = new List<Person>();

        private readonly IElevatorStrategy _strategy;

        public Elevator() : this(new DefaultElevatorStrategy())
        {
        }

        public Elevator(IElevatorStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Move(List<Person> allPeople)
        {
            // 1. 移動樓層
            if (Direction == Direction.Up)
                CurrentFloor = Math.Min(CurrentFloor + 1, 10);
            else
                CurrentFloor = Math.Max(CurrentFloor - 1, 1);

            // 2. 處理乘客
            UpdatePassengers(allPeople);

            // 3. 檢查是否需要轉向
            _strategy.CheckTurnaround(this, allPeople);
        }

        public void UpdatePassengers(List<Person> allPeople)
        {
            // 處理下車乘客
            var exiting = Passengers.Where(p => p.TargetFloor == CurrentFloor).ToList();
            foreach (var p in exiting)
            {
                p.InElevator = false;
                p.HasFinished = true;
                p.CurrentFloor = 0;
                p.TargetFloor = 0;
                Passengers.Remove(p);
            }

            // 處理上車乘客
            var boarding = allPeople
                .Where(p => !p.InElevator &&
                           !p.HasFinished &&
                           p.CurrentFloor == CurrentFloor &&
                           _strategy.IsDirectionMatch(this, p.TargetFloor))
                .ToList();

            foreach (var p in boarding)
            {
                p.InElevator = true;
                Passengers.Add(p);
            }
        }
    }

    internal class DefaultElevatorStrategy : IElevatorStrategy
    {
        private Direction lastDirection = Direction.Down;

        public void CheckTurnaround(IElevator elevator, List<Person> allPeople)
        {
            bool directionChanged = false;

            if (elevator.Direction == Direction.Down)
            {
                int minRequestFloor = FindMinimumRequestFloor(elevator, allPeople);
                if (minRequestFloor >= elevator.CurrentFloor && HasUpwardRequests(elevator, allPeople))
                {
                    elevator.Direction = Direction.Up;
                    directionChanged = true;
                }
            }
            else // Direction.Up
            {
                int maxRequestFloor = FindMaximumRequestFloor(elevator, allPeople);
                if (maxRequestFloor <= elevator.CurrentFloor && HasDownwardRequests(elevator, allPeople))
                {
                    elevator.Direction = Direction.Down;
                    directionChanged = true;
                }
            }

            if (directionChanged)
            {
                elevator.UpdatePassengers(allPeople);
            }
        }

        public int FindMinimumRequestFloor(IElevator elevator, List<Person> allPeople)
        {
            int minFloor = int.MaxValue;

            foreach (var p in elevator.Passengers)
            {
                if (p.TargetFloor < minFloor)
                    minFloor = p.TargetFloor;
            }

            foreach (var p in allPeople)
            {
                if (!p.InElevator && p.CurrentFloor < minFloor && p.TargetFloor != p.CurrentFloor)
                    minFloor = p.CurrentFloor;
            }

            return minFloor == int.MaxValue ? 1 : minFloor;
        }

        public int FindMaximumRequestFloor(IElevator elevator, List<Person> allPeople)
        {
            int maxFloor = int.MinValue;

            foreach (var p in elevator.Passengers)
            {
                if (p.TargetFloor > maxFloor)
                    maxFloor = p.TargetFloor;
            }

            foreach (var p in allPeople)
            {
                if (!p.InElevator && p.CurrentFloor > maxFloor && p.TargetFloor != p.CurrentFloor)
                    maxFloor = p.CurrentFloor;
            }

            return maxFloor == int.MinValue ? 10 : maxFloor;
        }

        public bool HasUpwardRequests(IElevator elevator, List<Person> allPeople)
        {
            return allPeople.Any(p => (p.InElevator && p.TargetFloor > elevator.CurrentFloor) ||
                   (!p.InElevator && p.CurrentFloor > elevator.CurrentFloor && p.TargetFloor != p.CurrentFloor));
        }

        public bool HasDownwardRequests(IElevator elevator, List<Person> allPeople)
        {
            return allPeople.Any(p => (p.InElevator && p.TargetFloor < elevator.CurrentFloor) ||
                   (!p.InElevator && p.CurrentFloor < elevator.CurrentFloor && p.TargetFloor != p.CurrentFloor));
        }

        public bool IsDirectionMatch(IElevator elevator, int targetFloor)
        {
            return elevator.Direction == Direction.Up
                ? targetFloor > elevator.CurrentFloor
                : targetFloor < elevator.CurrentFloor;
        }
    }
}