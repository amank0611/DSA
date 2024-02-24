namespace DSA
{
    internal class Swap
    {
        public static void NumberSwaping()
        {
            Console.WriteLine("Enter the value of a and b");
            /*Define variables*/
            _ = int.TryParse(Console.ReadLine(), out int a);
            _ = int.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine($"before swapping numbers: {a} ,{b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swapping numbers: {a} ,{b}");
        }
    }
}
