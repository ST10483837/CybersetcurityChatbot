using System;

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Bot";

            AudioPlayer audioPlayer = new AudioPlayer();

            Console.WriteLine("Starting Cybersecurity Chatbot...");
            audioPlayer.PlayGreeting();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}