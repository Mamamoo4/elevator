using System.Collections.Generic;

namespace elevator
{
    public interface IElevator
    {
        int CurrentFloor { get; set; }
        Direction Direction { get; set; }
        List<Person> Passengers { get; set; }

        void Move(List<Person> allPeople);
        void UpdatePassengers(List<Person> allPeople);
    }

    public interface IElevatorStrategy
    {
        void CheckTurnaround(IElevator elevator, List<Person> allPeople);
        int FindMinimumRequestFloor(IElevator elevator, List<Person> allPeople);
        int FindMaximumRequestFloor(IElevator elevator, List<Person> allPeople);
        bool HasUpwardRequests(IElevator elevator, List<Person> allPeople);
        bool HasDownwardRequests(IElevator elevator, List<Person> allPeople);
        bool IsDirectionMatch(IElevator elevator, int targetFloor);
    }

    public enum Direction
    {
        Up,
        Down
    }
}
