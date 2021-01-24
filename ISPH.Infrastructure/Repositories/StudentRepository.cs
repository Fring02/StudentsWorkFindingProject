﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISPH.Infrastructure.Data;
using ISPH.Core.Models;
using ISPH.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using ISPH.Core.Interfaces.Authentification;
using ISPH.Infrastructure.Services.Hashing;
using ISPH.Core.DTO;

namespace ISPH.Infrastructure.Repositories
{
    public class StudentRepository : EntityRepository<Student, StudentDto>, IUserAuthentification<Student>, IStudentsRepository
    {
        private readonly DataHashService<Student> _hashService = new StudentsHashService();
        public StudentRepository(EntityContext context) : base(context)
        {
        }
        public override async Task<bool> HasEntity(Student entity)
        {
            return await Context.Students.AnyAsync(st => st.Email == entity.Email);
        }
        public override async Task<IEnumerable<StudentDto>> GetAll()
        {
           return await Context.Students.AsNoTracking().OrderBy(st => st.StudentId).
               Include(student => student.Resume).Select(st => new StudentDto(st)
               {
                   ResumeId = st.Resume.ResumeId,
                   ResumeName = st.Resume.Name
               }).
               ToListAsync();
        }

        public override async Task<Student> GetById(Guid id)
        {
           return await Context.Students.AsNoTracking().
                Include(st => st.Resume).
                FirstOrDefaultAsync(st => st.StudentId == id);
        }

        public async Task<bool> UpdatePassword(Student student, string password)
        {
            _hashService.CreateHashedPassword(password, out byte[] hashedPass, out byte[] saltPass);
            student.HashedPassword = hashedPass;
            student.SaltPassword = saltPass;
            Context.Students.Update(student);
            return await Context.SaveChangesAsync() > 0;
        }
        //Auth

        public async Task<Student> Register(Student user, string password)
        {
            _hashService.CreateHashedPassword(password, out byte[] hashedPass, out byte[] saltPass);
            user.HashedPassword = hashedPass;
            user.SaltPassword = saltPass;
            Context.Students.Add(user);
            await Context.SaveChangesAsync();
            return user;
        }

        public async Task<Student> Login(string email, string password)
        {
            var user = await Context.Students.AsNoTracking().FirstOrDefaultAsync(st => st.Email == email);
            if (user == null) return null;
            return _hashService.CheckHashedPassword(user, password) ? user : null;
        }

        public async Task<bool> UserExists(Student user)
        {
            return await Context.Students.AnyAsync(st => st.Email == user.Email);
        }

    }
}
