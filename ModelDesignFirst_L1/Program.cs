using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test Model Designer First");
            string fisrtname = Console.ReadLine();
            string lastname = Console.ReadLine();
            string midlename = Console.ReadLine();
            string telephone = Console.ReadLine();
            TestPerson(fisrtname, lastname, midlename, telephone);
            Console.ReadKey();
        }
        static void TestPerson(String firstname, String lastname, String midlename, String telephone)
        {
            using (Model1Container context = new Model1Container())
            {
                Person p = new Person()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    MidleName = midlename,
                    TelephonNumber = telephone
                };
                context.People.Add(p);
                context.SaveChanges();
                var items = context.People;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);
            }
        }
    }
}
