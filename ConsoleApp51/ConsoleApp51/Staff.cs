
using ConsoleApp51;

namespace ConsoleApp51
{
    public class Staff:Base
    {
        public string ID_staff = "2";

        public const string staff_Name = "2";
        public void StaffLogin()
        {
            Console.Clear();
            Console.WriteLine("Enter ID:");
            string id = Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string name = Console.ReadLine();
            Console.Clear();

            if (id == ID_staff && name == staff_Name)
                
           

           
            {

                int choice;
                do
                {


                    Console.WriteLine("Press 1 For Students List\nPress 2 For Add New student Details\nPress 3 For admin login\n press 4 for student login");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (choice)
                    {

                        case 1:

                            foreach (Base items in students)
                            {

                                Console.WriteLine($"Student Name:{items.FullName}\tStudent ID:{items.ID}\tPresenty:{items.Attendance}");
                            }

                            break;

                        case 2:

                            Console.WriteLine("Enter Name,ID and Present:");
                            Base student = new Base()
                            {
                                FullName = Console.ReadLine(),
                                ID = Console.ReadLine(),
                                Attendance = Console.ReadLine()
                            };
                            students.Add(student);
                            Console.Clear();

                            Console.WriteLine("Student Added Successfully!");



                            break;


                        case 3:
                            Admin admin = new Admin();
                            admin.AdminLogin();
                            break;

                        case 4:
                            Student student1 = new Student();
                            student1.StudentLogin();
                            break;
                        default:

                            Console.WriteLine("Invalid Input");
                            goto Exit;


                    }
                } while (choice != 0);
                Console.Clear();

            Exit:
                Console.WriteLine("logout");
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        




    }

    }
}
