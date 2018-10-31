using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoCheckerAutofac
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var memos = new List<Memo>() {
                new Memo { Title = "Hear Autofac for the first time", DueTime = new DateTime(2017, 12, 14) },
                new Memo { Title = "Start working on Autofac tutorial", DueTime = DateTime.Now },
                new Memo { Title = "DI required in upcoming project", DueTime = new DateTime(2018, 07, 01) }
            }.AsQueryable();

            // Direct object creation
            var checker = new MemoChecker(memos, new PrintingNotifier(Console.Out));
            checker.CheckNow();


        }
    }
}
