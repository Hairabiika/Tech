namespace Tech
{
    using System;
    using System.Text;

    public class Login
    {
        public static void Main(string[] args)
        {
            string password = Console.ReadLine();
            int digits = 0;
            int a = 0;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                string newPassword = Console.ReadLine();
                string reverse = String.Empty;
                a = 0;
                digits = 0;

                if (password.Length == newPassword.Length)
                {

                    for (int j = newPassword.Length - 1; j >= 0; j--)
                    {
                        if (password[a] == newPassword[j]) { digits++; }
                        a++;
                    }
                }

                if (digits == password.Length && digits == newPassword.Length) { sb.AppendLine($"User {password} logged in."); break; }
                else if (i < 3) { sb.AppendLine("Incorrect password. Try again."); }
            }

            if (digits != password.Length) { sb.AppendLine($"User {password} blocked!"); }

            Console.Write(sb);
        }
    }
}
