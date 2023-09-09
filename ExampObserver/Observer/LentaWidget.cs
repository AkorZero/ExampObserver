namespace ExampObserver.Observer
{
    internal class LentaWidget : IObserver
    {
        string _coupon;
        public void Display()
        {
            Console.WriteLine($"Lenta: {_coupon}");
        }

        public void Update(string twitter, string lenta, string insta)
        {
            _coupon = lenta;
            Display();
        }
    }
}
