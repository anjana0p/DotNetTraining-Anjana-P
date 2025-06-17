namespace CalculatorWithClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,j,result=0;
            string op;
            Console.WriteLine("Value 1 :");
            i=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Value 2 :");
            j = Int32.Parse(Console.ReadLine());
            Console.WriteLine("operation (+,-) :");
            op = Console.ReadLine();

            if (op == "+")
            {
                result = i + j;
            }
            else if (op == "-")
            {
                result = i - j;

            }
            else if (op == "*")
            {
                result = j * i;
            }
            else if (op == "/")
            {

                result = i / j;
            }
            else
            {
                Console.WriteLine("invalid op");
                return;
            }
            Console.WriteLine($"RESULT :{result}");


        }
    }
}
