using System;

namespace CybersecurityChatbot
{
    public class User
    {
        // Automatic property (required by rubric)
        public string Name { get; private set; }

        public User()
        {
            Name = "Guest";
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name.Trim();
            }
        }

        public string GetPersonalizedGreeting()
        {
            return $"Hello, {Name}! Welcome to the Cybersecurity Awareness Bot.";
        }
    }
}