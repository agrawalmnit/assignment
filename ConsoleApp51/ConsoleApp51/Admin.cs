using System;


namespace ConsoleApp51
{
    public class Admin : Base 
    {
          
        public string ID_Admin = "1";

        public const string Admin_Name = "1";
        public void AdminLogin() 
        {
            Console.Clear();
            Console.WriteLine("Enter ID:");
            string id=Console.ReadLine();
            Console.WriteLine("Enter Full Name:");
            string name=Console.ReadLine();
           
           
            if(id==ID_Admin&&name==Admin_Name)
            {
                int choice;
                do
                {
                    
                    
                    
                    Console.WriteLine("Press 1 For students List\nPress 2 For Add New students Details\ntap 3 for staff\\n tap 4 for student\"");
                    choice = int.Parse(Console.ReadLine());
                    Console.Clear() ;
                    switch (choice)
                    {
                        
                        case 1:

                            foreach (Base items in students)
                            {
                               
                                Console.WriteLine($"Student Name:{items.FullName}Student id:{items.ID}\tPresenty:{items.Attendance}");
                            }

                        break;
                        case 2:
                          
                            Console.WriteLine("Enter Name,ID and Present:");
                            Base staff1 = new Base()
                            {
                                FullName = Console.ReadLine(),
                                ID = Console.ReadLine(),
                                Attendance = Console.ReadLine()
                            };
                            students.Add(staff1);
                            Console.Clear() ;
                            
                            Console.WriteLine("Staff Added Successfully!");
                            


                            break;







                        case 3:
                            Staff staff = new Staff();
                            staff.StaffLogin();
                            break;

                        case 4:
                            Student student2 = new Student();
                            student2.StudentLogin();
                            break;


                        default:

                            Console.WriteLine("Invalid Input");
                            goto Exit;



                    }
                }while(choice!=0);
                Console.Clear();

            Exit:
                Console.WriteLine("Logout Successfully!!!");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        
        
        }
    }
}
