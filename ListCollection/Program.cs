using System;
using System.Diagnostics.Metrics;

namespace FunwithLists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> BirthdayP = new List<string> { "Michle J.", "Troy R.", "Susan K.", "Tyler L.", "Whittny H." };
            string mainName = "Skyler"; 
            BirthdayP.Add(mainName); 
            BirthdayP.Insert(0, "Lu C."); 



            Console.WriteLine($"--You have {BirthdayP.Count()} to attend this year--");

            
            string[] memberArr = new string[] { "Stuart L.", "George J.", "Carl W." };
            BirthdayP.AddRange(memberArr);
            Console.WriteLine($"--Your now have {BirthdayP.Count()} to attend this year--");



            Console.WriteLine("--The Birthday attendence list is of the following:--");
            for (int i = 0; i < BirthdayP.Count(); i++)
                Console.WriteLine(BirthdayP[i]);



            BirthdayP.Remove("Troy R.");
            BirthdayP.Remove(BirthdayP[4]); 
            BirthdayP.RemoveRange(3, 2); 



            Console.WriteLine($"--The revised list now has {BirthdayP.Count()} members--");
            Console.WriteLine("Refurbished List:");
            for (int i = 0; i < BirthdayP.Count(); i++)
                Console.WriteLine(BirthdayP[i]);



            BirthdayP.Sort();
            Console.WriteLine("--The Same List But Sorted:--");
            foreach (string b in BirthdayP)
                Console.WriteLine(b);
            BirthdayP.Reverse();
            Console.WriteLine("--Sorted List But in Reverse:--");
            foreach (string b in BirthdayP)
                Console.WriteLine(b);


        }
    }
}
