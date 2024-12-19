using System;

namespace Learning
{
    public class Student
    {
        public string name;
        public int id;
        public Student()
        {

        }
        
        
        public Student(Student s)
        {
            //Student s2 = new Student();
            this.id=s.id;
            this.name = s.name;

        }

        
    }
}