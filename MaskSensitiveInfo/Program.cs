using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a secret: ");
            var secret = Console.ReadLine();
            int length = secret.Length;
            int allButLastFourLenth = secret.Substring(0, length - 4).Length;
            var allButLastFour = new string('X', allButLastFourLenth);
            var maskedSecret = secret.Substring(length - 4, 4);
            Console.WriteLine(allButLastFour+maskedSecret);
            
        }
    }
}
