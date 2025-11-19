using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ETMS2026CORE10WA.Model
{
    public class EmployeeInfo : Employee
    {



        public List<EmployeeCourse> EmployeeCourseList { get; set; }

        public List<Course> CourseList { get; set; }

        public int TotalCoursesAssined
        {
            get
            {
                return EmployeeCourseList.Count;
            }
        }

        public bool isAllCourseCompleted
        {
            get
            {
                return (TotalCoursesAssined >0) && (TotalCoursesAssined == TotalCoursesCompleted);
            }
        }

        public bool isAllCoursePending
        {
            get
            {
                return (TotalCoursesAssined > 0) && ( TotalCoursesCompleted ==0);
            }
        }

        public int TotalCoursesCompleted
        {
            get
            {
                return EmployeeCourseList.Where(e => e.isComplete == true).ToList().Count;
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

        public string cssStyle
        {
            get
            {
                string cssStyle = "";
                if (TotalCoursesCompleted == 0)
                {
                    cssStyle = "danger";
                }
                if (TotalCoursesAssined == TotalCoursesCompleted)
                {
                    cssStyle = "success";
                }
                if (TotalCoursesCompleted > 0 && TotalCoursesCompleted < TotalCoursesAssined)
                {
                    cssStyle = "warning";
                }

                return cssStyle;
            }
        }

    }
}
