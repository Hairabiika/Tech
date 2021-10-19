namespace Tech
{
    using System;
    using System.Linq;

    public class PasswordValidator
    {
        public static bool digits(string password)
        {
            int countDigits = 0;

            foreach (var character in password)
            {
                if (character >= '0' && character <= '9') countDigits++;
            }

            if (countDigits < 2) return false;
            else return true;
        }

        public static bool consists(string password)
        {
            bool valid = true;
            foreach (var character in password)
            {
                if ((character < '0' || character > '9') && (character < 'a' || character > 'z') && (character < 'A' || character > 'Z'))
                { valid = false; }
            }

            if (valid) return true;
            else return false;
        }

        public static bool range(string password)
        {
            if (password.Length < 6 || password.Length > 10) return false;
            else return true;
        }       
        
        public static void validate(string password)
        {
            bool digitsValidation = digits(password);
            bool consistsValidation = consists(password);
            bool rangeValidation = range(password);

            if (!rangeValidation) Console.WriteLine("Password must be between 6 and 10 characters");
            if (!consistsValidation) Console.WriteLine("Password must consist only of letters and digits");
            if (!digitsValidation) Console.WriteLine("Password must have at least 2 digits");
            if (digitsValidation && consistsValidation && rangeValidation) Console.WriteLine("Password is valid");
        }

        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            validate(password);
        }
    }
}
