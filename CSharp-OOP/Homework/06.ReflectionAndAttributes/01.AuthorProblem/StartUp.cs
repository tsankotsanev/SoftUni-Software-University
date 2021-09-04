namespace _01.AuthorProblem
{
    [Author("Vetsi")]
    public class StartUp
    {
        [Author("Gosho")]
        static void Main(string[] args)
        {
            var tracker = new Tracker();

            tracker.PrintMethodsByAuthor();
        }
    }
}
