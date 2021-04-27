using Flee.CalcEngine.PublicTypes;
using Flee.PublicTypes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TTTTTTTTTTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*CalculationEngine engine = new CalculationEngine();
            ExpressionContext context = new ExpressionContext();
            engine.Add("Func1", "(2*3) + 2.0", context);

            double res = 0;
            res = engine.GetResult<double>("Func1");
            Console.WriteLine(res);*/
            /* context.Variables["a"] = 3;
             engine.Recalculate("Func1");*/
            string s = "1+(3*(2+2)-2)/4%3";
            string[] ss = s.Split(new char[] { '+', '-', '*', '/', '%', '(', ')' });
            List<String> li = ss.ToList();
            li.RemoveAll(d => d.Length == 0);
            int tt = 0;
            foreach (string t in li)
            {
                Console.WriteLine(tt + "번째 인덱스 : " + t + " " + t.Length);
                tt++;
            }
        }
    }
}
