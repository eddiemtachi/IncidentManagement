using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Domain.Entities
{
    public class IncidentProperty
    {
        public int PropertyId { get; private set; }
        public string? PropertyName { get; private set; }
    }
}
