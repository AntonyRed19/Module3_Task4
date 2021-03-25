using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    public class Delegate
    {
        private event Func<int, int, int> SumHandler;

        public int Sum(int a, int b)
        {
            return a + b;
        }

        public void Run()
        {
            SumHandler += Sum;
            SumHandler = SumHandler + SumHandler;
            var sum = 0;
            TryAction(() =>
            {
                var listevent = SumHandler.GetInvocationList();
                foreach (var item in listevent)
                {
                    sum += (int)item.DynamicInvoke(2, 4);
                }
            });
            Console.WriteLine(sum);
        }

        public void TryAction(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
