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
            var result = SumHandler.GetInvocationList();
            var newresult = 0;
            foreach (var item in result)
            {
                var sumresult = item.DynamicInvoke(2, 4);
                int newsum = (int)sumresult + (int)sumresult;
                newresult = newsum;
            }

            Try(SumHandler, newresult);
        }

        public void Try(Func<int, int, int> func, int result)
        {
            try
            {
                func = (a, b) => result = a + b;
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
