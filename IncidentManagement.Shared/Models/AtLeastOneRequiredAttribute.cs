using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace IncidentManagement.Shared.Models
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class AtLeastOneRequiredAttribute : ValidationAttribute
    {
        private readonly string[] _propertyNames;

        public AtLeastOneRequiredAttribute(params string[] propertyNames)
        {
            _propertyNames = propertyNames;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            var type = validationContext.ObjectType;
            var properties = _propertyNames.Select(name => type.GetProperty(name, BindingFlags.Public | BindingFlags.Instance));

            bool anySupplied = properties.Any(p =>
            {
                var propValue = p?.GetValue(value);
                return propValue != null && !string.IsNullOrWhiteSpace(propValue.ToString());
            });

            if (!anySupplied)
            {
                return new ValidationResult(ErrorMessage ?? $"At least one of [{string.Join(", ", _propertyNames)}] must be supplied.");
            }

            return ValidationResult.Success;
        }
    }
}
