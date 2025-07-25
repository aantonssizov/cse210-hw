class PromptGenerator
{
    private string[] _prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
        ];

    public static string GetRandomPrompt()
    {
        Random random = new();
        PromptGenerator promptGenerator = new();
        int randomIndex = random.Next(0, promptGenerator._prompts.Length);
        string prompt = promptGenerator._prompts[randomIndex];

        return prompt;
    }
}