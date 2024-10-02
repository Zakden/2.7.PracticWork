using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7.PracticWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            string userFullname = "Шальнов Алексей Петрович";
            int userAge = 22;
            string userEmail = "shalnovap@mail.ru";
            double userProgrammingPoints = 6.5;
            double userMathPoints = 7.5;
            double userPhysPoints = 5.0;

            Console.WriteLine($"Имя: {userFullname}. Возраст: {userAge}. Электронная почта: {userEmail}.");
            Console.WriteLine($"Баллы по программированию: {userProgrammingPoints}");
            Console.WriteLine($"Баллы по математике: {userMathPoints}");
            Console.WriteLine($"Баллы по физике: {userPhysPoints}");
            Console.ReadKey();

            //Task 2
            double pointsSum = userMathPoints + userPhysPoints + userProgrammingPoints;
            double pontsValue = pointsSum / 3;

            Console.WriteLine($"Сумма всех баллов: {pointsSum}");
            Console.WriteLine($"Средний бал: {Math.Round(pontsValue,1)}");
            Console.ReadKey();
        }
    }
}
