using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringClassWork6._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            /*Console.ForegroundColor = ConsoleColor.Yellow;
            string s = "Arr string";
            Console.Write(s);
            Console.Write("\nInpun number who delete char:");
            int num = Convert.ToInt32(Console.ReadLine());
            s=s.Remove(num,1);
            Console.Write(s);
            Console.ReadLine();*/
            #endregion
            #region Exercise 2
            /*            Console.ForegroundColor = ConsoleColor.Yellow;
                        string s = "Ar string rem";
                        Console.Write(s);
                        Console.Write("\nInpun :");
                        char num = Convert.ToChar(Console.ReadLine());
                        for(int i = 0; i < s.Length; i++) {
                            if(num == s[i]) {
                                s = s.Remove(i, 1);
                            };
                        };
                        Console.Write(s);
                        Console.ReadLine();*/
            #endregion
            #region Exercise 3
            /*string s = "Ar string rem";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nInpun char:");
            string num = Convert.ToString(Console.ReadLine());
            Console.Write("\nInpun position:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            s = s.Insert(num2,num);
            Console.Write(s);
            Console.ReadLine();*/
            #endregion
            #region Exercise 4
            /*string s = "ar ra";
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    Console.Write("Polindrom doesnt find");
                    break;
                }
                else {
                    Console.Write("This is polindrom");
                    break;
                };
            }
            Console.ReadLine();*/
            #endregion
            #region Exercise 5
            /*string s = Convert.ToString(Console.ReadLine());
            string a = " ";
            int proj = 1;
            for(int i = 0; i < s.Length; i++) {
                if(s[i] == a[0]) {
                    proj++;
                }
                else { 
                
                };
            };
            Console.Write($"{proj} слова");
            Console.ReadLine();*/
            #endregion
            #region Exercise 6
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Input txt:");
            string txt = Convert.ToString(Console.ReadLine());
            Console.Write("\nInput find txt:");
            string findtxt = Convert.ToString(Console.ReadLine());
            Console.Write("\nInput change txt:");
            string txtchange = Convert.ToString(Console.ReadLine());
            int a = txt.IndexOf(findtxt);
            Console.Write($"\ntxt find:{a}");

            txt = txt.Insert(a,findtxt);
            Console.Write(txt);
            Console.ReadLine();
            #endregion

        }
    }
}
