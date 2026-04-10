using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            AudioPlayer audioPlayer = new AudioPlayer();
            User user = new User();

            audioPlayer.PlayGreeting();

            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            user.SetName(userName);

            Console.WriteLine(user.GetPersonalizedGreeting());
            Console.WriteLine($"Nice to meet you, {user.Name}!");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}