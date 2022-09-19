using System;
using System.Collections.Generic;
namespace Student_File
{
    public class AdminService
    {
        public static List<Admin> admins = new List<Admin>();
        StudentService studentService = new StudentService();
        
        

        static string userid = Guid.NewGuid().ToString();
        Admin addm=new Admin("Agboola","Ameen",userid,17,"2021-10133","agboola@gmail.com","09068635361",DateTime.Now,"alily22");

        public void Initial()
        {
            admins.Add(addm);
        }
                public Admin Login(string adminID, string password)
        {
            if(adminID==""||password=="")
            {
                Console.WriteLine("Fill in all fields");
                return null;
            }

            var admin =GetByAdminID(adminID);
            if(admin!=null && password==admin.Password)
            {
                Console.WriteLine("Login Successful");
                AdminMenu adminMenu=new AdminMenu();
                adminMenu.Adminmenu();
                return admin;
            }
            Console.WriteLine("Invalid Admin ID or Password");
            return null;
        }        


        public Admin GetByAdminID(string adminID)
        {
            var admin=admins.Find(obj => obj.AdminID==adminID);
            return admin;
        }
    }
}