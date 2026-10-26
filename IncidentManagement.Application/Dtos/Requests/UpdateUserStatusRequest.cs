using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Dtos.Requests
{
    public record UpdateUserStatusRequest(
        int UserId,
        bool IsActive
    );
}
