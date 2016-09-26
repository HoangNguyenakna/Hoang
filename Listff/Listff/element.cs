using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listff
{
    class element<T>

    {
        element<T> head;
        public element()
        {

        }
        public void addfirst(element<T> e)
        {
            e.Next = head;
            this.head = e;
        }
    }
}
