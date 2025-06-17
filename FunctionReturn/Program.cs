namespace FunctionReturn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hello());
            Console.WriteLine(HelloName("Anjana"));
        }

        public static string Hello()
        {
            return "hello Anjana";
        }

        public static string HelloName(string name)
        {
            return $"hello {name}";
        }
    }
}
