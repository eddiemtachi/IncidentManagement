using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using IncidentManagement.Application.Interfaces;
using IncidentManagement.Application.Service_Interfaces;


namespace IncidentManagement.Application.Services
{
    public class IncidentRoleService : IIncidentRoleService
    {
        private readonly IUnitOfWork _unitOfWork;
        public IncidentRoleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<IncidentRoleResponse>> GetAllIncidentRoleAsync()
        {
            var Role = await _unitOfWork.Roles.GetAllAsync();

            return Role.Select(Roles => new IncidentRoleResponse(Roles.RoleId, Roles?.RoleName!));
        }
    }
}
