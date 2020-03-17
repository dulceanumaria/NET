using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	public class Class1
	{
        public string Get(String Nume, int id)
        {
            string res = "";
            using (ModelSelfRefrences context = new ModelSelfRefrences())
            {
                if (Nume != "")
                {
                    var rs = context.SelfReferences.Where(s => s.nume == Name).Where(s => s.SelfReferenceId == 0).ToList();
                    foreach (var fisier in rs)
                        res += "ID: " + fisier.SelfReferenceId + " NAME: " + fisier.Name + "\n";
                }
            }
            return res;
        }
        public void Add(String Nume)
        {
            using (ModelSelfRefrences context = new ModelSelfRefrences())
            {
                SelfReference p = new SelfReference()
                {
                    Name = Nume
                };
                context.SelfReferences.Add(p);
                context.SaveChanges();
                var items = context.SelfReferences;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.SelfReferenceId, x.Name);
            }
        }
    }
}
