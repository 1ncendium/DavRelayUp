using System;
using System.IO;

namespace DavRelayUp.StartEfs
{
    public class EfsHandler
    {
        public static void Start()
        {
            string homeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); // Get home directory
            string filePath = Path.Combine(homeDir, "test.txt"); // Create file in home directory

            try
            {
                // Create the file
                File.WriteAllText(filePath, "This is a test file.");
                Console.WriteLine($"File created: {filePath}");

                // Encrypt the file using C#'s built-in method
                File.Encrypt(filePath);
                Console.WriteLine("File encrypted successfully.");

                // Delete the file
                File.Delete(filePath);
                Console.WriteLine("File deleted successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}
