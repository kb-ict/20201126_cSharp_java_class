using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = "1";
            int n = 1;
            while (n <= 20)
            {
                Console.WriteLine(n + "번째 수열: " + sequence);
                char token = sequence[0];
                int count = 0;
                string tempSequence = "";
                for (int i = 0; i < sequence.Length; i++)
                {
                    if (token == sequence[i])
                        count++;
                    else
                    {
                        tempSequence += "" + token + count;
                        count = 0;
                        token = sequence[i];
                        count++;
                    }
                    if (i + 1 == sequence.Length)
                        tempSequence += "" + token + count;
                }
                sequence = tempSequence;
                n++;
                
            }

            
        }
    }
}
