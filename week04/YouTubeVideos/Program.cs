using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [
            new() {
                Author = "PewDiePie",
                Title = "Use Linux",
                Length = 1000,
                Comments = [
                    new() {
                        CommenterName = "James",
                        Text = "What an interesting take"
                    },
                    new() {
                        CommenterName = "Sam",
                        Text = "I'm currios what is he going to do next"
                    },
                    new() {
                        CommenterName = "Josh",
                        Text = "I'm going to follow his advice and install Linux"
                    }
                ]
            },
            new() {
                Author = "MrBeast",
                Title = "Biggest Airplane in the world! Can you survive in it?",
                Length = 800,
                Comments = [
                    new() {
                        CommenterName = "Paul",
                        Text = "Wow, I never thought being inside of such airplane can be so scary"
                    },
                    new() {
                        CommenterName = "Kathy",
                        Text = "I wonder what would happen is such airplane was in the space"
                    },
                    new() {
                        CommenterName = "Jack",
                        Text = "Can you imagine how time would it take for you to learn how to rule such a thing"
                    }
                ]
            },
            new() {
                Author = "T-Series",
                Title = "Bolywood highlights 2024",
                Length = 600,
                Comments = [
                    new() {
                        CommenterName = "Tom",
                        Text = "Thank you for the video"
                    },
                    new() {
                        CommenterName = "Halib",
                        Text = "2:45 Best Moment imho"
                    },
                    new() {
                        CommenterName = "Salib",
                        Text = "Please do next video about top 5 hindi songs! Thank you in advance"
                    }
                ]
            }
        ];

        Console.WriteLine("Today videos for you:");

        foreach (var video in videos)
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length / 60}m {video.Length % 60}s");
            Console.WriteLine($"Total Comments: {video.CommentsCount}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine();
                Console.WriteLine($"Commenter Name: {comment.CommenterName}");
                Console.WriteLine($"Comment: {comment.Text}");
            }
        }
    }
}