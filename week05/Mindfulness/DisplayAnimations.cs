class DisplayAnimations
{
    public static void CountdownMessage(string message, int countdown = 5)
    {
        Console.Write($"{message}...{countdown}");
        while (countdown > 0)
        {
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write(--countdown);
        }
        Console.WriteLine();
    }

    public static void Spinner(int duration = 1)
    {
        int speed = 250;
        Console.WriteLine();
        char[] spinnerComponents = ['|', '/', '-', '\\'];
        while (duration > 0)
        {
            foreach (var spinnerComponent in spinnerComponents)
            {
                Console.Write(spinnerComponent);
                Thread.Sleep(speed);
                Console.Write("\b \b");
            }
            duration--;
        }
        Console.WriteLine();
    }
}