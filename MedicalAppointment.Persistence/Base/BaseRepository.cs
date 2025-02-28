using MedicalAppointment.Domain.Base;
using MedicalAppointment.Domain.Repository;
using MedicalAppointment.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

namespace MedicalAppointment.Persistence.Base
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly MedicalAppointmentContext _Context;
        private DbSet<TEntity> Entity { get; set; }
        private OperationResult Result = new OperationResult();

        public BaseRepository(MedicalAppointmentContext context)
        {
            _Context = context;
            Entity = _Context.Set<TEntity>();
        }

        public virtual async Task<OperationResult> GetEntityByIdAsync(int id)
        {
            Result = BaseValidator<TEntity>.ValidateID(id);
            if (Result.Success)
            {
                Result.Data = await Entity.FindAsync(id);
                Result.Success = true;
            }

            return Result;
        }

        public virtual async Task<OperationResult> UpdateEntityAsync(TEntity entity)
        {
            try
            {
                Result = await BaseValidator<TEntity>.ValidateNull(entity);
                if (Result.Success)
                {
                    var validationResults = ValidateEntity(entity);
                    if (validationResults.Any())
                    {
                        Result.Success = false;
                        Result.Message = string.Join("; ", validationResults);
                        return Result;
                    }
                }
                Entity.Update(entity);
                await _Context.SaveChangesAsync();
                Result.Success = true;
            }
            catch (Exception ex)
            {
                Result.Success = false;
                Result.Message = "Error actualizando los datos.";
            }

            return Result;
        }

        public virtual async Task<OperationResult> SaveEntityAsync(TEntity entity)
        {
            try
            {
                Result = await BaseValidator<TEntity>.ValidateNull(entity);
                if (Result.Success)
                {
                    var validationResults = ValidateEntity(entity);
                    if (validationResults.Any())
                    {
                        Result.Success = false;
                        Result.Message = string.Join("; ", validationResults);
                        return Result;
                    }
                }
                Entity.Add(entity);
                await _Context.SaveChangesAsync();
                Result.Success = true;
            }
            catch (Exception ex)
            {
                Result.Success = false;
                Result.Message = $"Error ingresando los datos.{ex.Message} ";
            }

            return Result;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await Entity.ToListAsync();
        }

        public virtual async Task<OperationResult> GetAllAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                await Entity.Where(filter).ToListAsync();
                Result.Success = true;
            }
            catch (Exception ex)
            {
                Result.Success = false;
                Result.Message = "Error obteniendo los datos.";
            }

            return Result;
        }

        public virtual async Task<bool> ExistsAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await Entity.AnyAsync(filter);
        }

        /// <summary>
        /// Valida una entidad con Data Annotations antes de guardarla en la base de datos.
        /// </summary>
        private List<string> ValidateEntity(TEntity entity)
        {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(entity, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(entity, validationContext, validationResults, validateAllProperties: true);

            return validationResults.Select(vr => vr.ErrorMessage).ToList();
        }
    }
}
