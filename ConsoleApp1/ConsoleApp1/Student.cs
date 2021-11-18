using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Student
    { 
       public Student()
       { }
        public Student(string fio, int age, string gender)
        {
            FIO = fio;
            Age = age;
            Gender = gender;
        }
        public string FIO = "";
        public int Age = 0;
        public string Gender = "";

        public void StudentInfo()
        {
            Console.Write($"{FIO}. ");
            Console.Write($"Возраст: {Age}. ");
            Console.Write($"Пол: {Gender}. \n");
        }

    }
}

