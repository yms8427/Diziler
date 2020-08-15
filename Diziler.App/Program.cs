using Diziler.Common;
using System;

namespace Diziler.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: bu uygulama sadece 5 kere çalışsın
            while (true)
            {
                Console.Write("Bir şarkı sözü giriniz................: ");
                var lyric = Console.ReadLine();
                var textHelper = new TextHelper();

                Console.Write("Hangi harf adedini saymak istersin....: ");
                var letter = Console.ReadKey();

                var numberOfLetters = textHelper.GetNumberOfLetters(lyric, letter.KeyChar);

                Console.WriteLine("\n=================================================\n");
                Console.WriteLine($"Şarkı sözü içinde {numberOfLetters} adet '{letter.KeyChar}' harfi vardır");

                Console.Write("\n\n\nYeni bir şarkı sözü araması için bir tuşa basınız");
                Console.ReadKey();
                
                Console.Clear();
            }
        }
    }
}
