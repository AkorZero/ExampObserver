using ExampObserver.Observer;
using ExampObserver.Subject;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var twitterWidget = new TwitterWidget();
        var instagramWidget = new InstagramWidget();
        var lentaWidget = new LentaWidget();

        var newsAggregator = new NewsAggregator();

        newsAggregator.RegisterObserver(instagramWidget);
        newsAggregator.RegisterObserver(lentaWidget);
        newsAggregator.RegisterObserver(twitterWidget);

        newsAggregator.NewNewsAvailable();

        Console.WriteLine();
        Console.ReadLine();

    }
}