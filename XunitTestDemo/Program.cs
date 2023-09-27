using System;
using System.Security.Cryptography.X509Certificates;

namespace XunitTestDemo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine(Hilsen("Said"));
            Console.WriteLine(ErMyndig(28));
            Console.WriteLine(FindAlder(1995, true));


        }
        

        public static string Hilsen(string navn)
        {
            navn = navn.Trim();

            if (navn == "")
            {
                return "Hej med dig";
            }

            return "Hej " + navn;
        }


        public static bool ErMyndig(int alder)
        {
            return alder >= 18;
        }

        public static int FindAlder(int foedselsaar, bool harhaftFoedselsdag = false)
        {
            if (foedselsaar > DateTime.Now.Year)
            {
                return -1;
            }
            else if (foedselsaar == DateTime.Now.Year)
            {
                return 0;
            }
            else
            {
                if (harhaftFoedselsdag)
                {
                    return DateTime.Now.Year - foedselsaar;
                }
                else
                {
                    return DateTime.Now.Year - foedselsaar - 1;
                }
            }

        }
    }
}