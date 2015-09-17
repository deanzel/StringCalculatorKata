using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            bool hasNegative = false



            if (numbers == "")
            {
                return 0;
            }

            //Custom Delimiter
            if (numbers.StartsWith("//"))
            {
                
                string[] seq = numbers.Split('\n');
                int delimeterLength = seq[0].Length - 4;
                string delimeter = seq[0].Substring(3, delimeterLength);
                string delimeterReplaced = seq[1].Replace(delimeter, ",");
                string[] arrayReplaced = delimeterReplaced.Split(new char[] { ',', '\n' });

                int sumReplaced = 0;

                foreach (string number in arrayReplaced)
                {
                    sumReplaced += int.Parse(number);
                }

                return sumReplaced;
            }

            
           
            string[] array = numbers.Split(new char[] {',', '\n'});
            

            //Has negatives

            

            int sum = 0;

            //Regular adding method
            foreach (string number in array)
            {
                sum += int.Parse(number);
            }

            return sum;
        }
    }
}
