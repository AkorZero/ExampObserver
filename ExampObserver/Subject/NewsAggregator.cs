using ExampObserver.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampObserver.Subject
{
    public class NewsAggregator : ISubject
    {
        private List<IObserver> _observers;
        private Random _random;

        public NewsAggregator()
        {
            _observers = new List<IObserver>();
            _random = new Random();
        }

        public void NewNewsAvailable()
        {
            NotifyObserver();
        }

        public void NotifyObserver()
        {
            string twit = GetTwitterNews();
            string coupon = GetLentaCoupons();
            string msg = GetInstaMesg();

            foreach (var observer in _observers)
            {
                observer.Update(twit, coupon, msg);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public string GetTwitterNews()
        {
            var twit = new List<string>
            {
                "Новость из Twitter #1",
                "Новость из Twitter #2",
                "Новость из Twitter #3"
            };
            return twit[_random.Next(3)];
        }

        public string GetLentaCoupons()
        {
            var coupon = new List<string>
            {
                "Купон из Lenta #1",
                "Купон из Lenta #2",
                "Купон из Lenta #3"
            };
            return coupon[_random.Next(3)];
        }

        public string GetInstaMesg()
        {
            var message = new List<string>
            {
                "Сообщение из Instagram #1",
                "Сообщение из Instagram #2",
                "Сообщение из Instagram #3"
            };
            return message[_random.Next(3)];
        }
    }
}
