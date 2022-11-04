using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_1214057
{
    internal class DVD_1214057 : Product_1214057
    {
        protected string duration;

        public DVD_1214057(string title, string duration)
        {
            this.MyTitle = title;
            this.MyType = "DVD";
            this.duration = duration;

            Console.WriteLine("Ini dari class DVD");
        }

        public string Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                duration = value;
            }
        }
    }
}
