using System;

namespace EncryptionSampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "32karaktersifre12345678901234567";
                     


            Console.WriteLine("Please enter a string for encryption");
            var str = Console.ReadLine();
            var encryptedString = AESEncryption.EncryptString(key, str);
            Console.WriteLine($"encrypted string = {encryptedString}");

            var decryptedString = AESEncryption.DecryptString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");

            Console.ReadKey();
        }
    }
}
