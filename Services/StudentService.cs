using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Student_File
{
    public class StudentService
    {
        private static List<Student> students = new List<Student>();
        public Student CreateStudent(string firstName, string lastName, int age, string email, string phoneNo, DateTime dob, string password, string cpassword)
        {
            if(password!=cpassword)
            {
                Console.WriteLine("Passwords do not match");
                return null;
            }

            if(firstName==""||lastName==""||email==""||phoneNo==""||password==""||cpassword=="")
            {
                Console.WriteLine("Kindly fill in all the fields");
                return null;
            }

            int code=GenerateMatric();
            string matricNo= $"{DateTime.Today.Year}/{code}";
            var userID = Guid.NewGuid().ToString();
            Student student =new Student(firstName,lastName,userID,age,matricNo,email,phoneNo,dob,password);
            students.Add(student);
            Console.WriteLine($"Congratulations {student.FirstName}, you have succesfully registered./nYour Matric Number is {student.MatricNo} and your UserID is {student.UserID}");
            WriteFile(student);
            return student;
        }

        public int GenerateMatric()
        {
            Random rnd = new Random();
            int matric = rnd.Next(1000,9999);
            return matric;
        }
        public void WriteFile(Student std)
        {
            var  path = @"C:\Users\User\Desktop\Student File\StudentRecord.txt";
            FileStream fs = new FileStream(path,FileMode.Append);
            Console.WriteLine(new FileInfo(path).FullName);
            var word =Encoding.Default.GetBytes(std.ToString());
            fs.Write(word, 0,word.Length);
            fs.Close();
        }
    }
}