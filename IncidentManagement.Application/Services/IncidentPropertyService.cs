using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.Service_Interfaces;
using IncidentManagement.Application.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Services
{
    public class IncidentPropertyService : IIncidentPropertyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IncidentPropertyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<IncidentPropertyResponse>> GetAllIncidentPropertyAsync()
        {
            var incidentProperites = await _unitOfWork.Properties.GetAllAsync();

            return incidentProperites.Select(c => new IncidentPropertyResponse(c.PropertyId, c?.PropertyName!));
        }
    }
}
