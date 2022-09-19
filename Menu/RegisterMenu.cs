using System;
using System.Collections.Generic;
namespace Student_File
{
    public class RegisterMenu
    {
        StudentService _studentService = new StudentService();
        public void Register()
        {
            try
            {
            Console.WriteLine("Enter your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name:");
            string lastName = Console.ReadLine();         
            Console.WriteLine("Enter your Email:");
            string email =  Console.ReadLine();
            Console.WriteLine("Enter your PhoneNo:");
            string phoneNo = Console.ReadLine();             
            Console.WriteLine("Enter your date of birth: YYYY-MM-DD");
            DateTime dob = DateTime.Parse(Console.ReadLine());
            int age= DateTime.Now.Year - dob.Year;
            if(DateTime.Now.DayOfYear < dob.DayOfYear){age-=1;}               
            Console.WriteLine("Enter your Password:");
            string password = Console.ReadLine();           
            Console.WriteLine("Confirm your Password:");
            string cpassword = Console.ReadLine();

            var student =  _studentService.CreateStudent(firstName,lastName,age,email,phoneNo,dob,password,cpassword); 
            if(student!=null)
            {
                MainMenu menu=new MainMenu();
                menu.Welcome();
            }
            }
            catch{Console.WriteLine("Invalid Date of Birth");}


   
           
            
        }
    }
}