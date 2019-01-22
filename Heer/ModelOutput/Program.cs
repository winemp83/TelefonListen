using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ModelOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Anruf anruf in AnrufList.Anrufe)
            {
                Console.WriteLine(anruf);
            }
            Console.ReadKey();
        }
    }
}
