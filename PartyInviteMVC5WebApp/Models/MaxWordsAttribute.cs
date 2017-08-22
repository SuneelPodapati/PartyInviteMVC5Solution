using System.ComponentModel.DataAnnotations;

namespace PartyInviteMVC5WebApp.Models
{
    public class MaxWordsAttribute: ValidationAttribute
    {
        readonly int _maxWords;
        public MaxWordsAttribute(int maxWords): base("{0} has to may words")
        {
            _maxWords = maxWords;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            //return base.IsValid(value, validationContext);
            if (value != null)
            {
                var valueAsString = value.ToString();
                if (valueAsString.Split(' ').Length > _maxWords)
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}