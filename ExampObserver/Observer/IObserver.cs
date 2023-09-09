namespace ExampObserver.Observer
{
    public interface IObserver
    {
        void Update(string twitter, string lenta, string insta);
        void Display();
    }
}
