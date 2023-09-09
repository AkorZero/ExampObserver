using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampObserver.Observer
{
    internal class InstaWidget
    {
        string _photo;
        public void Display()
        {
            Console.WriteLine($"Insta: {_photo}");
        }

        public void Update(string twitter, string lenta, string insta)
        {
            _photo = insta;
            Display();
        }
    }
}
