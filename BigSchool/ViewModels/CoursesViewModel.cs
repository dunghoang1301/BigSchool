using BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
        public List<Category> Categories { get; internal set; }
        public object Date { get; internal set; }
        public object Time { get; internal set; }
        public object Category { get; internal set; }
        public object Place { get; internal set; }
    }
}