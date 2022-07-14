using EntityFrameWorkApplication.Data;
using Microsoft.EntityFrameworkCore;
using System;
namespace EntityFrameWorkApplication
{
    class Program
    {
        static void Main()
        {
            
        }
        static Teacher [] GetAllTeachersByStudent(string StudentName)
        {

            using (var db = new ApplicationDbContext())
            {
                Teacher[] teachers = (from a in db.PupilTeacherRels
                                      join p in db.Pupils
                                      on a.PupilId equals p.Id
                                      join t in db.Teachers
                                      on a.TeacherId equals t.Id
                                      where p.FirstName == StudentName
                                      select t).Distinct().ToArray();
                return teachers;

            }

        }
    }
}