using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Core.DataAcces.EntityFramework
{
    public interface EFRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
    where TEntity : class, IEntity
    where TContext : IdentityDbContext, new()
    {
        
    }
}