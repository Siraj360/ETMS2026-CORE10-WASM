using System;
using System.Collections.Generic;
using System.Text;

namespace ETMS2026CORE10WA.Model
{
    public class EmployeeCourseInfo : EmployeeCourse
    { 
        public EmployeeInfo EmployeeInfo { get; set; }
        
        public CourseInfo CourseInfo { get; set; }

        public int TotalEmployeeNotStarted
        {
            get
            {
                return EmployeeInfo.TotalCoursesAssined - EmployeeInfo.TotalCoursesCompleted;
            }
        }

        public int TotalEmployeeCompleted
        {
            get
            {
                return EmployeeInfo.TotalCoursesCompleted;
            }
        }

        public string PercentEmployeCompleted
        {
            get
            {
                double total = TotalEmployeeCompleted + TotalEmployeeNotStarted;
                if (total == 0) return "0.00%";

                double fraction = (double)TotalEmployeeCompleted / total;
                return fraction.ToString("P2"); // exactly 2 decimals
            }
        }


        public int TotalCourseNotStarted
        {
            get
            {
                return CourseInfo.TotalCoursesAssined - CourseInfo.TotalCoursesCompleted;
            }
        }

        public int TotalCourseCompleted
        {
            get
            {
                return CourseInfo.TotalCoursesCompleted;
            }
        }


        public string PercentCourcesCompleted
        {
            get
            {
                double total = TotalCourseCompleted + TotalCourseNotStarted;
                if (total == 0) return "0.00%";

                double fraction = (double)TotalCourseCompleted / total;
                return fraction.ToString("P2");
            }
        }




        public string cellCSS
        {
            get
            {
                string cellCSS = "";
                if(TotalEmployeeCompleted == 0)
                {
                    cellCSS = "table-danger";
                }
                if (TotalEmployeeNotStarted == 0)
                {
                    cellCSS = "table-success";
                }
                if (TotalEmployeeNotStarted == 0 && TotalEmployeeCompleted == 0)
                {
                    cellCSS = "table-secondry";
                }

                return cellCSS;
            }
        }




    }
}
