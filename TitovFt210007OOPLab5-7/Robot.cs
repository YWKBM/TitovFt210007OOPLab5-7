using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007OOPLab5_7
{
    internal class Robot : IRobot
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Robot(string name, string number)
        {
            Name = name;
            Number = number;
        }   
    }
}
