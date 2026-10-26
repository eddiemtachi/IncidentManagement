using IncidentManagement.Application.GenericInterfaces;
using IncidentManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Interfaces
{
    public interface IIncidentPropertyRepository : IRepository<IncidentProperty>
    {
    }
}
