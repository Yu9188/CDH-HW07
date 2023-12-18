using WfpApp1;
using System;
using System.Collections.ObjectModel;

namespace WfpApp1
{
    internal class Teacher
    {
        public String TeacherName { get; set; }
        public ObservableCollection<Course> TeachingCourses { get; set; }

        public Teacher()
        {
            this.TeachingCourses = new ObservableCollection<Course>();
        }

        public override string ToString()
        {
            return $"{TeacherName}";
        }
    }
}