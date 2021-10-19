namespace Tech
{
    using System;
    using System.Linq;

    public class VowelsCount
    {
        public static int vowels (string word)
        {
            int count = 0;

            foreach (var letter in word)
            {
                if (letter == 'A' || letter == 'a' || letter == 'E' || letter == 'e' || letter == 'U' || letter == 'u'
                    || letter == 'O' || letter == 'o' || letter == 'I' || letter == 'i') count++;
            }

            return count;
        }
        public static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(vowels(word));
        }
    }
}
