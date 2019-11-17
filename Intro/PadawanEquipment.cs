namespace Tech
{
    using System;
    using System.Text;

    public class PadawanEquipment
    {
        public static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freeBelts = students / 6;

            double total = Math.Ceiling(students * 1.1) * lightsabersPrice + robesPrice * students + beltsPrice * (students - freeBelts);

            if (total <= money) { Console.WriteLine($"The money is enough - it would cost {total:F2}lv."); }
            else { Console.WriteLine($"Ivan Cho will need {(total - money):F2}lv more."); }
        }
    }
}
