namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(Hello());
            Console.WriteLine(Hello("Anjana"));
        }

        public static string Hello()
        {
            return "hello Anjana";
        }

        public static string Hello(String name)
        {
            return $"hello {name}";
        }
    }
}
