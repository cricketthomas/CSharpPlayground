using System;
namespace CSharpPlayground
{
    public class Student
    {

        public string name;
        public string major;
        public double gpa;

        public Student(string argName, string argMajor, double argGpa)
        {
            name = argName;
            major = argMajor;
            gpa = argGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
