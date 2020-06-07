using System;
using System.Collections.Generic;

namespace testemene
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> FibMaker = new List<int>();
            int j = 0;
            for (int i = 0; j < 350; i++)
            {
                if ((i == 0) || (i == 1))
                    FibMaker.Add(i);
                else
                {
                    j = FibMaker[i - 1] + FibMaker[i - 2];
                    if (j < 350)
                        FibMaker.Add(j);
                }
            }
            bool isIt = false;
            for (int i = 0; i < FibMaker.Count; i++)
            {

                if (4 == FibMaker[i])
                {
                    isIt = true;
                }
            }
            Console.WriteLine(isIt);
        }
    }
}
