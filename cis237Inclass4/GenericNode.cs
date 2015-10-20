using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass4
{
    class GenericNode<T>
    {
         public GenericNode<T> Next
        { get; set; }

        public T data
        { get;  set;  }
    
    }
}
