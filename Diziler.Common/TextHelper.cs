namespace Diziler.Common
{
    public class TextHelper
    {
        public int GetNumberOfLetters(string text, char search)
        {
            var amount = 0;
            foreach (var letter in text)
            {
                if (letter == search)
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}
