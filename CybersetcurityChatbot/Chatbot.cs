using System;
using System.Collections.Generic;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private Dictionary<string, string> responses;

        public Chatbot()
        {
            responses = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            LoadResponses();
        }

        private void LoadResponses()
        {
            responses["how are you"] = "I'm functioning perfectly! Ready to help you learn about cybersecurity.";
            responses["what is your purpose"] = "My purpose is to educate you about staying safe online!";
            responses["what is phishing"] = "Phishing is when scammers pretend to be legitimate companies to steal your info. Never click suspicious links!";
            responses["password safety"] = "Use strong passwords with 12+ characters, uppercase, lowercase, numbers, and symbols!";
            responses["safe browsing"] = "Always check for 'https://' in URLs and avoid suspicious downloads.";
        }

        // String manipulation method (required by rubric)
        public string GetResponse(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "I didn't quite understand that. Could you rephrase?";
            }

            string processedInput = input.Trim().ToLower();

            foreach (var key in responses.Keys)
            {
                if (processedInput.Contains(key))
                {
                    return responses[key];
                }
            }

            return "I didn't quite understand that. Could you rephrase? Try asking about passwords or phishing!";
        }
    }
}