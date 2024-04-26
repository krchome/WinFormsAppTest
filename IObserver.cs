using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternDemo
{
   

     // Observer interface
        public interface IObserver
        {
            void Update(string data);
        }
    

}
