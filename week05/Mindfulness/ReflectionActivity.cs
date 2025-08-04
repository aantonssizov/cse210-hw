
using System.Timers;

class ReflectionActivity : Activity
{
    private readonly List<string> _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    ];

    private List<string> _questions;

    public ReflectionActivity()
    {
        _name = "Reflection Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public override void Do()
    {
        bool timerElapsed = false;
        System.Timers.Timer _timer = new(_duration * 1000)
        {
            AutoReset = false,
            Enabled = true
        };
        _timer.Elapsed += (o, e) =>
        {
            timerElapsed = true;
        };

        string prompt = SelectRandomPrompt();
        Console.WriteLine(prompt);
        DisplayAnimations.Spinner(5);

        while (!timerElapsed)
        {
            string question = SelectRandomQuestion();
            if (question == null)
            {
                _timer.Stop();
                break;
            }

            Console.WriteLine(question);
            DisplayAnimations.Spinner(5);
        }
    }


    private string SelectRandomPrompt()
    {
        Random random = new();
        int randomIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomIndex];

        _prompts.Remove(prompt);

        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

        return prompt;
    }

    private string SelectRandomQuestion()
    {
        Random random = new();

        int randomIndex = random.Next(_questions.Count);
        string question = _questions[randomIndex];
        _questions.Remove(question);

        return question;
    }
}