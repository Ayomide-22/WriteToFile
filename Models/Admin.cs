using System;
namespace Student_File
{
    public class Admin
    {
        public string FirstName{get;set;} 

        public string LastName{get;set;}
        
        public string UserID{get;set;}
        
        public int Age{get;set;}  
        
        public string Email{get;set;}
        
        public string PhoneNo{get;set;}

        public string AdminID{get;set;}
        
        public DateTime DOB{get;set;}
        
        public string Password{get;set;}
        public Admin(string firstName, string lastName, string userID, int age,string adminID, string email, string phoneNo, DateTime dob, string password)
        {
            FirstName=firstName;
            LastName=lastName;
            UserID=userID;
            age= DateTime.Now.Year - dob.Year;
            if(DateTime.Now.DayOfYear < dob.DayOfYear){age-=1;}
            Age=age;
            AdminID=adminID;
            Email=email;
            PhoneNo=phoneNo;
            DOB=dob;
            Password=password;
        }
    }
}