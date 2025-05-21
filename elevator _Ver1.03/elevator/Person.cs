using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevator
{
    public class Person
    {
        public string Name { get; set; }
        public int CurrentFloor { get; set; }
        public int TargetFloor { get; set; }
        public bool InElevator { get; set; }
        public bool HasFinished { get; set; } // 新增屬性標記是否已完成
    }
}
