using System;

namespace SchoolAssignmentAlternative
{
    public class School
    {

        public class ClassRoom
        {
            public string TextId { get; set; }

            public abstract class Person
            {
                public abstract class Teacher
                {
                    public string Name { get; set; }
                    public abstract void Teach();
                    public class Course
                    {
                        public string Name { get; set; }
                        public int Clas { get; set; }
                        public int Exercise { get; set; }
                    }
                }
                public abstract class Student
                {
                    public string Name { get; set; }
                    public int Id { get; set; }
                }


            }


        }





       
    }



}
