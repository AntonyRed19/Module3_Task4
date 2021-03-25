using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Linq
    {
        private readonly string[] _teams = { "Бавария", "Боррусия", "Манчестер Сити", "Манчестер Юнайтед", "Реал Мадрид", "Псж", "Лион", "Ювентус", "Интер" };
        private readonly string[] _teams2 = { "Бавария", "Боррусия", "Герта", "Шальке" };
        public string Name { get; set; }
        public int Age { get; set; }
        public void Mod()
        {
            var newstring = _teams.FirstOrDefault();
            Console.WriteLine(newstring);

            var newstring1 = _teams.Where(w => w.Contains("Манчестер")).OrderBy(o => o);
            foreach (var item in newstring1)
            {
                Console.WriteLine(item);
            }

            IEnumerable<int> newstring2 = _teams.Select(s => s.Length);
            foreach (var item in newstring2)
            {
                Console.WriteLine(item);
            }

            var newstring3 = _teams.Intersect(_teams2);
            foreach (var item in newstring3)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------");
            var newstring4 = _teams.Concat(_teams2);
            foreach (var item in newstring4)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------------------------------------------");
            var newstring5 = _teams.OrderByDescending(o => o);
            foreach (var item in newstring5)
            {
                Console.WriteLine(item);
            }
        }
    }
}
