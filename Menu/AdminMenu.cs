using System;
using System.IO;
namespace Student_File
{
    public class AdminMenu
    {
        AdminService _adminService = new AdminService();
        StudentService _studentService = new StudentService();
        public void Adminmenu()
        {
            MainMenu mainMenu=new MainMenu();
            Console.WriteLine("1. View All Student Profiles\n2. Back to Login Page\n0. Back to Main menu");
            int input =int.Parse(Console.ReadLine());
             var  path = @"C:\Users\User\Desktop\Student File\StudentRecord.txt";
            if(input==1)
            {
                FileStream fsread =new FileStream(path, FileMode.Open,FileAccess.Read);
                var st= new StreamReader(fsread);
                Console.WriteLine(st.ReadToEnd());
                st.Close();
            }
            else if(input==2)
            {
                AdminService admn=new AdminService();
                Console.WriteLine("Enter AdminId");
                string adminID=Console.ReadLine();
                Console.WriteLine("Enter password");
                string password=Console.ReadLine();
                admn.Login(adminID,password);
            }
            else if(input==0)
            {
                
            }
        }
    }
}