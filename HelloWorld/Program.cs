namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Hello World

            string name; 

            do
            {
                Console.WriteLine("Please enter your name:");
                name = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(name));

            if (args.Length == 0) { Console.WriteLine($"Howdy {name}!!"); }
            else
            {
                switch (args[0].ToLower())
                {
                    case "formal":
                        Console.WriteLine($"Hello, How are you {name}?");
                        break;
                    case "casual":
                        Console.WriteLine($"Hey, What’s up {name}?");
                        break;
                    default:
                        Console.WriteLine($"Howdy {name}!!");
                        break;
                }
            }

            Console.ReadKey();

            Console.WriteLine("-----------------------------------------------------");

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 5)
                    Console.WriteLine(animal);
            }

            Console.WriteLine("-----------------------------------------------------");

            string color;

            do
            {

                Console.WriteLine("What is your favorite color?");
                color = Console.ReadLine();

            } while (String.IsNullOrWhiteSpace(color));

            Random random= new Random();

            Console.WriteLine($"Would you like to have a {color} {animals[random.Next(0,animals.Length)]}? (y/n)");

            string response;

            do
            {
                response= Console.ReadLine();
                if (response.ToLower() == "y")
                {
                    Console.WriteLine("we are on it, it will be sent to your home in 3 days");
                }
                else Console.WriteLine("no problem!!!");

            } while (String.IsNullOrWhiteSpace(response));

            #endregion

            #region Console Input
            #region Console.Read()

            int userInputInt = Console.Read();
            Console.WriteLine($"input int value is {userInputInt}");
            Console.WriteLine($"input char value is {Convert.ToChar(userInputInt)}");
            #endregion

            #region Console.ReadKey()

            ConsoleKeyInfo enteredKey;

            do
            {
                enteredKey = Console.ReadKey();
                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine($"you pressed the {enteredKey.Key.ToString()} key");
                Console.WriteLine("-----------------------------------------------");

            } while (enteredKey.Key != ConsoleKey.Escape);
            #endregion

            #region Console.ReadLine()
            string sentence;

            do
            {
                Console.WriteLine("Type in a sentence. Press enter when done");
                sentence = Console.ReadLine();
                Console.WriteLine($"You entered the sentence: {sentence}");

            } while (sentence.ToLower() != "quit");
            #endregion 
            #endregion


        }
    }
}