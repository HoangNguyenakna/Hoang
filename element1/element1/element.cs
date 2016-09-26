using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace element1
{
    class element<T>
    {
        private T data;

        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        private element<T> Next;
         
        internal element<T> next
        {
            get { return Next; }
            set { Next = value; }
        }
    }
}
