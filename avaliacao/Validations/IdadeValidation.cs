using System.ComponentModel.DataAnnotations;

namespace avaliacao.Validations
{
    public class IdadeValidation:ValidationAttribute
    {
        protected override ValidationResult? IsValid(Object? value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return new ValidationResult(ErrorMessage);
            }
            int idade = (int)value;

            return idade >= 15 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
