using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampObserver.Observer
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string insta);
        void Display();
    }
}
