using System;

namespace CybersecurityChatbot
{
    public class User
    {
        // Automatic property (required by rubric)
        public string Name { get; private set; }
        public int QuestionsAsked { get; set; }

        public User()
        {
            Name = "Guest";
            QuestionsAsked = 0;
        }

        public void SetName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name.Trim();
            }
        }

        public string GetPersonalizedMessage(string message)
        {
            return $"{Name}, {message}";
        }
    }
}
