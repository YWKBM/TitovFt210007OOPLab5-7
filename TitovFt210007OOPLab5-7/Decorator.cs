using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007OOPLab5_7
{
 
    abstract class Decorator
    {
        public IRobot robot { get; set; }

        public void ChangeName(string Name)
        {
            robot.Name = Name;
        }

        public Decorator(IRobot robot)
        {
            this.robot = robot;
        }   
    }
}
