using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDModeloApi.Domain.Core.Data
{
    public interface IUnitOfWork
    {
        IDbContextTransaction Transaction { get; }
        Task BeginTransaction();
        Task CreateSavepoint(string savePointName);
        Task RollbackToSavepoint(string savePointName);
        Task<bool> Commit();
    }
}
