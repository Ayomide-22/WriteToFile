using System;
using System.Collections.Generic;

namespace Student_File
{
    public class MainMenu
    {
        StudentService _studentService = new StudentService();
        AdminService _adminService = new AdminService();

        public void Welcome()
        {
            Console.WriteLine("***WELCOME TO THE STUDENT REGISTRATION PORTAL***\nSelect an option below:");
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("1. Register\n2. Login as Admin\n0. Exit");
                int input=int.Parse(Console.ReadLine());

                if(input == 1)
                {
                    var register =new RegisterMenu();
                    register.Register();
                }
                else if(input==2)
                {   
                    AdminService admn=new AdminService();
                    admn.Initial();
                    Console.WriteLine("Enter AdminId");
                    string adminID=Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string password=Console.ReadLine();
                    admn.Login(adminID,password);
                }
                else if(input==0)
                {
                    Console.WriteLine("Thanks for using this medium");
                    flag=false;
                }

            }
        }
    }
}