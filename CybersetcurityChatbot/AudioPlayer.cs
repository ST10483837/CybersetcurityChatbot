using System;
using System.Media;
using System.IO;

namespace CybersecurityChatbot
{
    public class AudioPlayer
    {
        public void PlayGreeting()
        {
            try
            {
                string audioPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Greeting.wav");

                if (File.Exists(audioPath))
                {
                    using (SoundPlayer player = new SoundPlayer(audioPath))
                    {
                        player.PlaySync();
                    }
                    Console.WriteLine("Voice greeting played!");
                }
                else
                {
                    Console.WriteLine("Greeting.wav not found. Place it in the Debug folder.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}