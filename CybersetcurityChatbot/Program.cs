using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";
            Console.WindowWidth = 100;

            AudioPlayer audioPlayer = new AudioPlayer();
            User user = new User();
            Chatbot chatbot = new Chatbot();

            // Display ASCII art
            chatbot.DisplayAsciiArt();

            // Play voice greeting
            chatbot.WriteColored("\n[🔊] Playing voice greeting...\n", ConsoleColor.Yellow);
            audioPlayer.PlayGreeting();

            // Welcome message with border
            chatbot.DrawBorder("WELCOME");
            Console.WriteLine();
            chatbot.WriteColored("Hello! Welcome to the Cybersecurity Awareness Bot.\n", ConsoleColor.White);
            chatbot.WriteColored("I'm here to help you stay safe online.\n\n", ConsoleColor.White);

            // Ask for name
            chatbot.WriteColored("What is your name? ", ConsoleColor.Green);
            string userName = Console.ReadLine();
            user.SetName(userName);

            Console.WriteLine();
            chatbot.WriteColored($"Nice to meet you, {user.Name}!\n", ConsoleColor.Green);
            chatbot.DrawBorder();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}