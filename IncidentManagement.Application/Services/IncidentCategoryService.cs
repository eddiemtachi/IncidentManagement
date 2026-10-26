using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.Service_Interfaces;
using IncidentManagement.Application.UnitOfWork;

namespace IncidentManagement.Application.Services
{
    public class IncidentCategoryService : IIncidentCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IncidentCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<IncidentCategoryResponse>> GetAllIncidentCategoryAsync()
        {
            var incidentCategories = await _unitOfWork.IncidentCategories.GetAllAsync();

            return incidentCategories.Select(c => new IncidentCategoryResponse(c.CategoryId, c?.CategoryName!));
        }
    }
}
