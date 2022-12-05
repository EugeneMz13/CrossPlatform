using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = ("C:\\Users\\eugene\\source\\repos\\ConsoleCalc\\ConsoleCalc\\INPUT.txt");
            string inputfile = File.ReadAllText(path);
            List<string> inputnum = new List<string>();
            inputnum = inputfile.Split(' ').ToList();
            int b = Convert.ToInt32(inputnum[0]);
            if ( b > 1000)
            {
                string incorrect = "a and b should be <1000";
                File.WriteAllText("C:\\Users\\eugene\\source\\repos\\ConsoleCalc\\ConsoleCalc\\OUTPUT.txt", incorrect);
            }
            else
            { 
                string res = Convert.ToString(Sequence(b));
                File.WriteAllText("C:\\Users\\eugene\\source\\repos\\ConsoleCalc\\ConsoleCalc\\OUTPUT.txt", res);
            }
        }

         static int Sequence(int b)
         {
            var def = 1;
            for (int i = 1; i < 10000; i++)
            {
                if (i % 2 == 0)
                {
                    def += 1;
                }
                else if (i % 3 == 0)
                {
                    def += 1;
                }
                else if (i % 5 == 0)
                {
                    def += 1;
                }
                if (def == b)
                {
                    return i;
                }
            }
            return 0;
         }    
    }
}
