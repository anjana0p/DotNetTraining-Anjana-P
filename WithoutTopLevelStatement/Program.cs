namespace WithoutTopLevelStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Hello();
            Hello();
            HelloName("Nathaneal","Malappuram");
        }

        public static void Hello()
        {
            Console.WriteLine("Hello from Anjana P");
        }

        public static void HelloName(String name,String location)
        {
            Console.WriteLine($"Hello {name}, from {location}");
        }
    }
}
