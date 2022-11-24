using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitovFt210007OOPLab5_7
{
    internal class Program
    {
        static void Main()
        {
            Robot robot = new Robot("В", "АА001221-56");  

            FirstTraining ft = new FirstTraining(robot, "ВИТА");
            ft.BuildABarn();
            ft.BuildAHouse();

            SecondTraining st = new SecondTraining(robot, "Виталий");
            st.HouseAddFloor();
            st.DemountFloor();
            
        }
    }
}
