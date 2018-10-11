using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartMenuLibrary;
using CalculatorLibrary.cs;

namespace CalculatorApp
{
    public class CalculatorMenu
    {
            string[] danskText;
            string[] englishText;
            int[] callId;
            int j;


            string start = String.Join(Environment.NewLine, "SmartMenu",
                "Vælg sprog",
                "1 dansk",
                "2 engelsk");

            public void LoadMenu(string path)
            {
                Console.WriteLine(start);
                string[] text = System.IO.File.ReadAllLines(@"c:..\..\MenuSpec.txt");
                danskText = text.Take(text.Length / 2).ToArray();
                englishText = text.Skip(text.Length / 2).ToArray();


                for (int i = 0; i < danskText.Length; i++) 
                {

                    if (danskText[i].Contains(';'))
                    {
                        j++;
                        string[] spliter = danskText[i].Split(';');
                        danskText[i] = spliter[0];

                    }
                }

                callId = new int[j];

                for (int i = 0; i < j; i++)
                {
                    callId[i] = i + 1;
                }


            }
            public void Activate()
            {

                ConsoleKeyInfo userinput;
                string s = Console.ReadLine();

                int n = int.Parse(s);

                switch (n)
                {
                    case 1:
                        Console.Clear();
                        for (int i = 0; i < danskText.Length; i++)
                        {
                            Console.WriteLine(danskText[i]);
                        }
                        for (int i = 0; i < callId.Length; i++)
                        {
                            Console.WriteLine(callId[i]);
                        }
                        userinput = Console.ReadKey();
                    if (userinput.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 1");
                    }
                    else if (userinput.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 2");
                    }
                    else if (userinput.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 3");
                    }
                    else if (userinput.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 4");
                    }
                    else if (userinput.Key == ConsoleKey.D5)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 5");
                    }
                    else if (userinput.Key == ConsoleKey.D6)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 6");
                    }
                    else if (userinput.Key == ConsoleKey.D7)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 7");
                    }
                    else if (userinput.Key == ConsoleKey.D8)
                    {
                        Console.Clear();
                        Console.WriteLine("svar 8");
                    }
                    else if (userinput.Key == ConsoleKey.D0)
                    {
                        Console.Clear();
                        Console.WriteLine(start);
                        Activate();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("fejl vælg en mulighed på skærmen");
                        Console.WriteLine("");
                        Console.WriteLine(start);
                        Activate();

                    }
                        
                        break;




                    case 2:
                        Console.Clear();
                        for (int i = 0; i < englishText.Length; i++)
                        {
                            Console.WriteLine(englishText[i]);
                        }
                        userinput = Console.ReadKey();
                    if (userinput.Key == ConsoleKey.D1)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 1");
                    }
                    else if (userinput.Key == ConsoleKey.D2)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 2");
                    }
                    else if (userinput.Key == ConsoleKey.D3)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 3");
                    }
                    else if (userinput.Key == ConsoleKey.D4)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 4");
                    }
                    else if (userinput.Key == ConsoleKey.D5)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 5");
                    }
                    else if (userinput.Key == ConsoleKey.D6)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 6");
                    }
                    else if (userinput.Key == ConsoleKey.D7)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 7");
                    }
                    else if (userinput.Key == ConsoleKey.D8)
                    {
                        Console.Clear();
                        Console.WriteLine("answer 8");
                    }
                    else if (userinput.Key == ConsoleKey.D0)
                    {
                        Console.Clear();
                        Console.WriteLine(start);
                        Activate();
                    }
                    else
                        {
                            Console.Clear();
                            Console.WriteLine("fail select an valid option on screen");
                            Console.WriteLine("");
                            Console.WriteLine(start);
                            Activate();
                    }
                  
                        break;

                }


            }
        
    }
}