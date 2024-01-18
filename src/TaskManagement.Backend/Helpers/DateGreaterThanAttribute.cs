using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Backend.Helpers
{
    public class DateGreaterThanAttribute(string comparisonProperty) : ValidationAttribute
    {
        private readonly string _comparisonProperty = comparisonProperty;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime currentValue = (DateTime)value;

            DateTime comparisonValue = (DateTime)validationContext.ObjectType.GetProperty(_comparisonProperty).GetValue(validationContext.ObjectInstance);

            if (currentValue < comparisonValue)
            {
                return new ValidationResult(ErrorMessage = "End date must be later than start date");
            }

            return ValidationResult.Success;
        }
    }
}