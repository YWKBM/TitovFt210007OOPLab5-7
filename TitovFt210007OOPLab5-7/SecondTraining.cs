using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007OOPLab5_7
{
    internal class SecondTraining : Decorator
    {
        public void HouseAddFloor()
        {
            Console.WriteLine("Robot {0} with number {1} added the floor", this.robot.Name, this.robot.Number);
        }
        
        public void DemountFloor()
        {
            Console.WriteLine("Robot {0} with number {1} demount the floor", this.robot.Name, this.robot.Number);
        }

        public SecondTraining(IRobot robot, string name) : base(robot) { ChangeName(name);  }
    }
}
