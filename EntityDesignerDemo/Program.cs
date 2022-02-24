using EntityDesignerDemo.Data.Contexts;
using EntityDesignerDemo.Domain.Entities;
using EntityDesignerDemo.Domain.Enums;
using EntityDesignerDemo.Service.Interfaces;
using EntityDesignerDemo.Service.Services;
using System;

namespace EntityDesignerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITeacherService teacherService = new TeacherService();

            var res = teacherService.GetTeacherAsync(p => p.Id == 1).Result;
            Console.WriteLine(res.FirstName);

            //Teacher teacher = new Teacher()
            //{
            //    FirstName = "Ali",
            //    LastName = "Komilov",
            //    BirthDate = DateTime.Now,
            //    CardNumber = "8600 0011 2233 4567",
            //    Dapartment = Department.Education,
            //    Experence = 12,
            //    Gender = Gender.Male,
            //    PhoneNumber = "+998881134455",
            //    StartedDate = DateTime.Now, 
            //    Subject = Subject.NodeJs
            //};

            //dbContext.Teachers.Add(teacher);
            //dbContext.SaveChanges();
            //var res = dbContext.Teachers.Find(1);

            //Console.WriteLine(res.FirstName);
        }
    }
}
