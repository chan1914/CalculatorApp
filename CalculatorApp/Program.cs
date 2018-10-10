using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary.cs;
using SmartMenuLibrary;
using CalculatorApp;



namespace CalculatorApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Program myProgram = new Program();
                myProgram.Run();
            }

            private void Run()
            {
                CalculatorMenu menu = new CalculatorMenu();
                menu.LoadMenu("MenuSpec.txt");
                menu.Activate();
            }
        }
    }
    
}
