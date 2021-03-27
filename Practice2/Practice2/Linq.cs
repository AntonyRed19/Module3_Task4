using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Linq
    {
        public void Show()
        {
            var list = new List<Contact>
            {
                new Contact { Name = "Dimon", PhoneNumber = "1232436675" },
                new Contact { Name = "Alex", PhoneNumber = "228673" },
                new Contact { Name = "Anton", PhoneNumber = "245666" },
                new Contact { Name = "Bogdan", PhoneNumber = "68754376" },
                new Contact { Name = "Uri", PhoneNumber = "228532" },
            };

            Console.WriteLine("------------------------------");
            var newlist = list.FirstOrDefault(f => f.Name == "Anton");
            Console.WriteLine($"{newlist.Name} - {newlist.PhoneNumber}");

            Console.WriteLine("------------------------------");
            var newlist1 = list.Where(w => w.PhoneNumber.Contains("228"));
            foreach (var item in newlist1)
            {
                Console.WriteLine($"{item.Name} - {item.PhoneNumber}");
            }

            Console.WriteLine("------------------------------");
            var newlist2 = list.Select(s => s.PhoneNumber).Where(w => w.Length > 6);
            foreach (var item in newlist2)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("------------------------------");
            var newlist3 = list.OrderByDescending(o => o.Name);
            foreach (var item in newlist3)
            {
                Console.WriteLine($"{item.Name}");
            }

            var list2 = new List<string>
            {
                "Alex",
                "Anton",
                "Vlad",
                "Vova",
            };

            Console.WriteLine("------------------------------");
            var newlist4 = list.Select(s => s.Name).Concat(list2);
            foreach (var item in newlist4)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("------------------------------");
            var newlist5 = list.Select(s => s.Name).Union(list2);
            foreach (var item in newlist5)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine("------------------------------");
            var newlist6 = list.Select(s => s.Name).Intersect(list2);
            foreach (var item in newlist6)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
