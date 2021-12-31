using ApplicationDataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationDataAccess.Repository
{
    public class BaseRepo<T, TC> : IBaseRepo<T> where T : class where TC : DbContext
    {
        private readonly DbSet<T> _ContextSet;
        private readonly TC _Context;
        public BaseRepo(TC context)
        {
            this._Context = context;
            this._ContextSet = _Context.Set<T>();
        }

        public async Task<T> Create(T model)
        {
            await _ContextSet.AddAsync(model);
            await _Context.SaveChangesAsync();
            return model;
        }

        public async Task<T> Delete(int id)
        {
                var model = await GetByID(id);
                if (model != null)
                {
                    _ContextSet.Remove(model);
                    return await _Context.SaveChangesAsync() >= 0 ? 
                        model : throw new System.Exception("Id found But Can't Delete From DataBase");
                }
            return null;
        }
        public Task<T> Update(T models)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<T>> Get() =>
            await _Context.Set<T>().ToListAsync();

        public async Task<T> GetByID(int id) =>
            await _ContextSet.FindAsync(id);

        public async Task<bool> SaveChages() =>
            await _Context.SaveChangesAsync() >= 0;

    }
}
