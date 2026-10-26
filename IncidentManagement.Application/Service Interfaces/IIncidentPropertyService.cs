using IncidentManagement.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Service_Interfaces
{
    public interface IIncidentPropertyService
    {
        Task<IEnumerable<IncidentPropertyResponse>> GetAllIncidentPropertyAsync();
    }
}
