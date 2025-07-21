// Excidded Requirement: Added ability to reshow scripture after it was all hidden

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new(
            new("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight."
        );

        while (true)
        {
            Console.Clear();
            scripture.Display();

            if (scripture.IsAllHidden)
            {
                Console.Write("All words of the scripture are hidden. Do you want to restart? (yes/no) ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("yes", StringComparison.CurrentCultureIgnoreCase))
                    scripture.ShowAll();
                else
                    break;
            }
            else
            {
                Console.Write("Press enter to hide or 'quit' to quit the program: ");
                string userInput = Console.ReadLine();

                if (userInput.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
                    break;
                else if (userInput == "")
                    scripture.HideAFew();
            }

        }
    }
}