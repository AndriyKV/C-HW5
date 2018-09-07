using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HW5 1)
            List< IDeveloper > developers = new List<IDeveloper>();
            developers.Add(new Builder("hammer"));
            developers.Add(new Builder("ledgehammer"));
            developers.Add(new Builder("jackhammer"));
            developers.Add(new Programmer("java"));
            developers.Add(new Programmer("C#"));
            developers.Add(new Programmer("C++"));

            foreach(var d in developers)
            {
                d.Create();
                d.Destroy();
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            #endregion
            #region HW5 2)
            Dictionary<uint, string> persons = new Dictionary<uint, string>(7);
            Console.WriteLine("Please enter seven pairs (ID, Name) of some persons:");
            for (int i=0; i<7; i++)
            {
                Console.WriteLine("Enter {0} ID:", i + 1);
                uint ID=Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Enter {0} Name:", i + 1);
                string name = Console.ReadLine();
                persons.Add(ID, name);
            }
            Console.WriteLine("------------------------\nEnter one of the IDs you entered earlier.");
            uint serchID = Convert.ToUInt32( Console.ReadLine());

            if (persons.ContainsKey(serchID))
            {
                Console.WriteLine(persons[serchID]);
            }
            else
            {
                Console.WriteLine("Can't find this ID");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
            #endregion
        }
    }
}
