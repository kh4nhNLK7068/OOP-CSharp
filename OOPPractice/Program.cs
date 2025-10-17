using System;

namespace OOPPractice
{

    public enum Level
    {
        First = 1,
        Second = 2,
        Third = 3
    }

    class Program
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            Pig obj = new Pig();
            obj.animalSound();
            Level enumString = Level.Second;
            Console.WriteLine($"{enumString}");

            /*int[] numArr = { 1, 2, 3 };
            try
            {
                int num = numArr[10];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Try again!");
            }*/

            /*
            Thứ 3 21/10/2025 deadline
            + build public Webform (Không mã hóa - mã hóa một phần - toàn phần) + (Build project -> đưa lên IIS -> public domain web {Thực hành}) / App winfroms (install 2017, 2019(unnecessary), 2022 ver Visual Code xem cách build app 3 vers này + bugs thường gặp, tìm đọc thêm errors {Lý thuyết})
            + Dataset (.xsd) trong .NET {Lý thuyết}

            Thứ 5 23/10/2025 - Lý thuyết
            + HTML/CSS/JS in .NET
            + Telerik (UI/UX)
            + DevExpress (dùng mỗi HRM)
            + SAP Crystal Report (DÙNG NHIỀU, winforms & webform)


            Học học:
            Entity Framework / Dapper
            Core (old 4,5,6) (new 8,9,..)
            .NET Framework (4.0 -> 4.8 ver)
            MVC + core / web API
             */
            checkAge(15);
        }
    }
}
