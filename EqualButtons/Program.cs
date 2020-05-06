using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EqualButtons
{
    class Program
    {
        static void Main(string[] args)
        {
            Button button1 = new Button();
            button1.Text = "Click me now!";

            Button button2 = new Button();
            button2.Text = "Click me now!";

            Console.WriteLine("Operator: " + AreButtonsEqualOp(button1, button2));
            Console.WriteLine("Method: " + ArebuttonsEqualMethod(button1, button2));
            
        }

        static bool AreButtonsEqualOp(Button x, Button y)
        {
            return x == y;
        }

        static bool ArebuttonsEqualMethod(Button x, Button y)
        {
            return x.Equals(y);
        }
    }
}
