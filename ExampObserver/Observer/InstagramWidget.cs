namespace ExampObserver.Observer
{
    internal class InstagramWidget : IObserver
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
