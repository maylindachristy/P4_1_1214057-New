using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214057
{
    public class Book_1214057 : Product_1214057
    {
        protected string pageCount;

        public Book_1214057(string type, string title, string pagecount) : base(type, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return this.pageCount;
            }
            set
            {
                pageCount = value;
            }
        }
    }
}
