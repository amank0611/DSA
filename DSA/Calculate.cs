namespace DSA
{
    internal class Calculate
    {
        public static void CalculateDiscount()
        {
            Console.WriteLine("Enter total bill amount");
            long.TryParse(Console.ReadLine(), out long billAmount);
            // Write your code here example 136, 86, 357, 12294
            int discount = 0;
            long billAmt = billAmount;
            while (billAmt > 0)
            {
                var digit = billAmt % 10;
                if (digit % 2 != 0)
                {
                    discount += (int)digit;
                }
                billAmt /= 10;
            }
            Console.Write($"final calculated discount is : {discount}");
            Console.ReadKey();
        }
    }
}
