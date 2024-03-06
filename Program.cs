namespace CsharpAssignment5
{
    class Program
    {

        private static BackgroundOperation _bgOperation  = new BackgroundOperation();

  
        public static async Task Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Menu:)");
                Console.WriteLine("1. Write \"Hello World\"");
                Console.WriteLine("2. Write Current Date");
                Console.WriteLine("3. Write OS Version");
                Console.WriteLine("Enter your choice (1/2/3):");

                string choice = Console.ReadLine();
                string message = "";

                switch (choice)
                {
                    case "1":
                        message = "Hello World";
                        break;
                    case "2":
                        message = DateTime.Now.ToString();
                        break;
                    case "3":
                        message = Environment.OSVersion.VersionString;
                        break;
                    default:
                        Console.WriteLine("========================================="); 
                        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3."); 
                        Console.WriteLine("=========================================");
                        continue;
                }
                await _bgOperation.WriteToFileAsync(message);
                Console.WriteLine("");
                Console.WriteLine("Message written to file.");
                Console.WriteLine("----------------------------------------------------");


            }
        }
    }
}