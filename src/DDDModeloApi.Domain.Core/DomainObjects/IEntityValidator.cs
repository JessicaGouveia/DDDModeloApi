using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;

namespace DDDModeloApi.Domain.Core.DomainObjects
{
    public interface IEntityValidator<TEntity> : IValidator<TEntity> where TEntity : Entity
    {
        ValidationResult ValidationResult { get; }
        Task<bool> IsValidAsync(TEntity entity);
    }
}
