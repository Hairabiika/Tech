namespace Tech
{
    using System;
    using System.Linq;

    public class CharactersInRange
    {
        public static void print (char firstCharacter, char secondCharacter)
        {
            if (firstCharacter > secondCharacter) { char temp = firstCharacter; firstCharacter = secondCharacter; secondCharacter = temp; }

            for (char i = firstCharacter ; i < secondCharacter; i++)
            {
                if (i == firstCharacter) continue;
                Console.Write(i + " ");
            }
        }
        public static void Main(string[] args)
        {
            char firstCharacter = char.Parse(Console.ReadLine());
            char secondCharacter = char.Parse(Console.ReadLine());
            print(firstCharacter, secondCharacter);
        }
    }
}
