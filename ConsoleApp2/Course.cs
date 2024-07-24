using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Course 
    {
        static int maxCapacity = 100;
        String courseName;
        int enrollments;
        String[] enrolledStudents = new String[maxCapacity];

        Course(String CourseName)
        {
            this.courseName = CourseName;
            this.enrollments = 0;
        }


        public void enrollStudent(String studentName)
        {
            enrolledStudents[enrollments] = studentName;
            enrollments++;
            Console.WriteLine();
        }

        public void unenrollStudent(String studentName)
        {
            int i = 0;
            int j = 0;
            int size = maxCapacity;
            String[] enrolledStudentsCopy = new String[maxCapacity];
            while (i < enrolledStudents.Length - 1)
            {
                if (enrolledStudents[i].Equals(studentName))
                {
                    Console.WriteLine("Student unenrolled");
                    enrollments--;
                }
                else
                {
                    enrolledStudentsCopy[j] = enrolledStudents[i];
                    Console.WriteLine("Student enrolled");
                    j++;
                }
                i++;
            }
            enrolledStudents = enrolledStudentsCopy;
        }

        public static void setMaxCapacity(int maxCapacity)
        {
            Course.maxCapacity = maxCapacity;
        }

        public static void main(String[] args)
        {
            Course obj = new Course("MCA");

        }

    }
}
