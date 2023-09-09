namespace ExampObserver.Observer
{
    public class TwitterWidget : IObserver
    {
        string _twit;
        public void Display()
        {
            Console.WriteLine($"Twitter: {_twit}");
        }

        public void Update(string twitter, string lenta, string insta)
        {
            _twit = twitter;
            Display();
        }
    }
}
