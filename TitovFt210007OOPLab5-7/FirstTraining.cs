using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007OOPLab5_7
{
    internal class FirstTraining : Decorator
    {
        public void BuildAHouse()
        {
            Console.WriteLine("Robot {0} with number {1} built a house", this.robot.Name, this.robot.Number);
        }

        public void BuildABarn()
        {
            Console.WriteLine("Robot {0} with number {1} built a barn",this.robot.Name, this.robot.Number);
        }

        public FirstTraining(IRobot robot, string name) : base(robot) { ChangeName(name); }
    }
}
