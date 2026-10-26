using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Dtos.Responses
{
    public record IncidentPropertyResponse(
        int PropertyId,
        string PropertyName
    );
}
