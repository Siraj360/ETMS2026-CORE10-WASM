using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ETMS2026CORE10WA.Model
{
    public class CourseInfo:Course
    {

        public List<EmployeeCourse> EmployeeCourseList { get; set; }

        public List<Employee> EmployeeList { get; set; }

        public int TotalCoursesAssined
        {
            get
            {
                return EmployeeCourseList.Count;
            }
        }

        public string PercentCourcesCompleted
        {
            get
            {
                double total = TotalCoursesCompleted + TotalCoursesAssined;
                if (total == 0) return "0.00%";

                double fraction = (double)TotalCoursesCompleted / TotalCoursesAssined;
                return fraction.ToString("P2"); // exactly 2 decimals

            }

        }
        public int TotalCoursesCompleted
        {
            get
            {
                return EmployeeCourseList.Where(e => e.isComplete == true).ToList().Count;
            }
        }


        public bool isAllEmployeeCompleted
        {
            get
            {
                return (TotalCoursesAssined > 0) && (TotalCoursesAssined == TotalCoursesCompleted);
            }
        }

        public bool isAllEmployeePending
        {
            get
            {
                return (TotalCoursesAssined > 0) && (TotalCoursesCompleted == 0);
            }
        }

    }
}
