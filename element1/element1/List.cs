using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace element1
{
    class List<T>
    {
        element<T> head;
        internal element<T> Head
        {
            get { return head; }
            set { head = value; }
        }
        public List()
        {}
            public void addfirst(element<T> e)
        {
            e.next = head;
            this.head = e;
        }
            }

}
