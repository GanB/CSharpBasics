namespace CollectionsBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = new List<int>();
            listOfIntegers.Add(100);
            listOfIntegers.Add(200);

            foreach (var number in listOfIntegers)
            {
                Console.WriteLine(number);
            }

            List<double> doubles= new List<double>();
            doubles.Add(10.75);
            doubles.Add(21.23);
            doubles.Add(51.34);

            foreach (var item in doubles)
            {
                Console.WriteLine(item);
            }

            var product = Tuple.Create("Yo-yo", 1, 10.65);
            Console.WriteLine($"{product.Item1} {product.Item2} {product.Item3}");

            (string name, int quantity, double price) product2 = ("Yo-yo", 1, 10.67);

            Console.WriteLine($"{product2.name} {product2.price} {product2.quantity}");

            product2.price = 25.99;

            Console.WriteLine(product2.price);

            Dictionary<int, string> numberTable= new Dictionary<int, string>();

            numberTable.Add(1, "One");
            numberTable.Add(2, "Two");
            numberTable.Add(3, "Three");
            numberTable.Add(4, "Four");
            numberTable.Add(5, "Five");
            numberTable.Add(6, "Six");
            numberTable.Add(7, "Seven");

            foreach (var item in numberTable)
            {
                Console.WriteLine($"{item.Key} equals {item.Value}");
            }

            //numberTable.Add(5, "Cinco");

        }
    }
}