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
            Chatbot chatbot = new Chatbot();

            audioPlayer.PlayGreeting();

            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            user.SetName(userName);

            Console.WriteLine(user.GetPersonalizedGreeting());

            // Test the chatbot
            Console.WriteLine("\n" + chatbot.GetResponse("how are you"));
            Console.WriteLine("\n" + chatbot.GetResponse("what is phishing"));

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}