using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampObserver.Observer
{
    internal class InstagramWidget
    {
        string _message;
        public void Display()
        {
            Console.WriteLine($"Insta: {_message}");
        }

        public void Update(string twitter, string lenta, string insta)
        {
            _message = insta;
            Display();
        }
    }
}
