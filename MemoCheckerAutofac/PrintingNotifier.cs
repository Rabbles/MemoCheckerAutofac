using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoCheckerAutofac
{
    public class PrintingNotifier : IMemoDueNotifier
    {
        private TextWriter writer;

        public PrintingNotifier(TextWriter writer)
        {
            this.writer = writer;
        }
        public void MemoIsDue(Memo memo)
        {
            writer.WriteLine($"Memo: {memo.Title} is due.");
        }
    }
}
