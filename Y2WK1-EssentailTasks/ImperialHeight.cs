using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Y2WK1_EssentailTasks
{
    internal class ImperialHeight
    {
        int feet;
        int inches;
        int fullHeightInches = 0;

        public void GetFeet(int hFeet)
        {
            hFeet = feet;
        }

        public void GetInches(int hInches)
        {
            hInches = inches;
        }

        public void ViewHeight()
        {
            Console.WriteLine($"{feet} foot and {inches} inches");
        }

        public void GetHeightInInches()
        {
            fullHeightInches = inches + (feet*12);
        }

        public void ViewHeightInInches()
        {
            Console.WriteLine(fullHeightInches);
        }
    }
}
