using System;
using ConsoleApp51;

namespace ConsoleApp51;

public class Program
{
    public static void Main(string[] args)
    {
        int press;


        do
        {
            Console.WriteLine("tap 1 for admin\n tap 2 for staff\n tap 3 for student");
            press = int.Parse(Console.ReadLine());
            Console.Clear();


            switch (press)
            {
                case 1:
                    Admin admin = new Admin();
                    admin.AdminLogin();
                    break;

                case 2:
                    Staff staff = new Staff();
                    staff.StaffLogin();
                    break;

                case 3:
                    Student student = new Student();
                    student.StudentLogin();
                    break;



            }

        }

        while (press != 0);
        
       
    }
}

