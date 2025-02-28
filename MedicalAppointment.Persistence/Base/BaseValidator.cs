
using MedicalAppointment.Domain.Base;

namespace MedicalAppointment.Persistence.Base
{
    public static class BaseValidator<TEntity>
    {
        public static async Task<OperationResult> ValidateNull(TEntity entity)
        {
            OperationResult operationResult = new OperationResult();
            if (entity == null)
            {
                operationResult.Success = false;
                operationResult.Message = "The entity is null";
                return operationResult;
            }
            return operationResult;
        }

        public static OperationResult ValidateNullData(dynamic data)
        {
            OperationResult operationResult = new OperationResult();
            if (data == null)
            {
                operationResult.Success = false;
                operationResult.Message = "The ID does not exist in the database";
                return operationResult;
            }
            return data;
        }

        public static OperationResult ValidateID(int id)
        {
            OperationResult operationResult = new OperationResult();
            if (id <= 0)
            {
                operationResult.Success = false;
                operationResult.Message = "The ID must be positive or an integer";
                return operationResult;
            }
            return operationResult;
        }
    }
}
