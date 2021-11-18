using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [Serializable]
    public class Group
    { 
         public Group()
    { }
        public Group(string name, List<Student> stdList, string spec, string classTeacher)
        {
            GroupList = stdList;
            Name = name;
            Spec = spec;
            ClassTeacher = classTeacher;
        }
        public string Name = "";
        public List<Student> GroupList;
        public string Spec = "";
        public string ClassTeacher = "";

        public void GroupInfo()
        {
            Console.Write($"Название группы: {Name}. ");
            Console.Write($"Направление: {Spec}. ");
            Console.WriteLine($"Классный руководитель: {ClassTeacher}. ");
            Console.WriteLine("Список группы:");
            for (int j = 0; j < GroupList.Count; j++)
            {
                Console.Write((j + 1) + ". ");
                GroupList[j].StudentInfo();
            }
        }
    }
}
