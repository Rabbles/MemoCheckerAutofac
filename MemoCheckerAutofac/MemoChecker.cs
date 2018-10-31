using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoCheckerAutofac
{
    public class MemoChecker
    {
        private IQueryable<Memo> memos;
        private IMemoDueNotifier notifier;

        public MemoChecker(IQueryable<Memo> memos, IMemoDueNotifier notifier)
        {
            this.memos = memos;
            this.notifier = notifier;
        }

        public void CheckNow()
        {
            var overdueMemos = memos.Where(m => m.DueTime < DateTime.Now);

            foreach (var memo in overdueMemos)
            {
                notifier.MemoIsDue(memo);
            }
        }
    }
}
