using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class EfCourseDal : ICourseDal
    {

        List<Course> _course;

        public EfCourseDal()
        {
            _course = new List<Course>()
    {
        new Course { CourseId = 1, CourseName = "C# + Angular", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 2, CourseName = "Javascript", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 3, CourseName = "Java + React", CourseDescription = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 },
        new Course { CourseId = 4, CourseName = ".Net", CourseDescription = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 }
    };
        }



        public void Add(Course course)
        {
            _course.Add(course);
        }

        public void Delete(Course course)
        {
            Course productToDelete = _course.SingleOrDefault(c => c.CourseId == course.CourseId);
            _course.Remove(productToDelete);
        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GetAll()
        {
           return _course;
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _course.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CourseName = course.CourseName;
            courseToUpdate.CourseDescription = course.CourseDescription;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
        }
    }
}
