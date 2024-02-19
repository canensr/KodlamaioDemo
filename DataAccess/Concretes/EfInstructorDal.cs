using KodlamaioDemo.DataAccess.Abstracts;
using KodlamaioDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioDemo.DataAccess.Concretes
{
    public class EfInstructorDal : IInstructorDal
    {

        List<Instructor> _instructor;

        public EfInstructorDal()
        {
            _instructor = new List<Instructor>();
            {
                new Instructor { InstructorId = 1, FirstName = "Engin", LastName = "Demiroğ" };
                new Instructor { InstructorId = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };
            };
        }

        public void Add(Instructor instructor)
        {
            _instructor.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructor.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            _instructor.Remove(instructorToDelete);
        }

        public Instructor Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GetAll()
        {
            return _instructor;
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToUpdate = _instructor.SingleOrDefault(i => i.InstructorId == instructor.InstructorId);
            instructorToUpdate.FirstName = instructor.FirstName;
            instructorToUpdate.LastName = instructor.LastName;
        }
    }
}
