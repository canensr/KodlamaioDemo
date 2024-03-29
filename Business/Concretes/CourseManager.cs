﻿using KodlamaioDemo.Business.Abstracts;
using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.Business.Concretes
{
    public class CourseManager : ICourseService
    {

        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
