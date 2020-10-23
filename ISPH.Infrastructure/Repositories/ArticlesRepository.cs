﻿using ISPH.Core.Data;
using ISPH.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISPH.Infrastructure.Repositories
{
    public class ArticlesRepository : IEntityRepository<Article>
    {
        private readonly EntityContext _context;
        public ArticlesRepository(EntityContext context) 
        {
            _context = context;
        }
        public async Task<bool> Create(Article entity)
        {
            _context.Articles.Add(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> Delete(Article entity)
        {
            _context.Articles.Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> HasEntity(Article entity)
        {
            return await _context.Articles.AnyAsync(Article => Article.Title == entity.Title);
        }
        public async Task<IList<Article>> GetAll()
        {
           return await _context.Articles.AsQueryable().OrderBy(article => article.PublishDate).ToListAsync();
        }

        public async Task<Article> GetById(int id)
        {
            return await _context.Articles.FindAsync(id);
        }

        public bool Update(Article entity)
        {
            _context.Articles.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
