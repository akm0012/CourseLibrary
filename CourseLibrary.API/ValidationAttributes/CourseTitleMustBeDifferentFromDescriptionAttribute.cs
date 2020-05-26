using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.Models;

namespace CourseLibrary.API.ValidationAttributes
{
    public class CourseTitleMustBeDifferentFromDescriptionAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var course = (CourseForManipulationDto) validationContext.ObjectInstance;
            
            if (course.Title == course.Description)
            {
                var errorMessage = "The provided description should be different than the title.";

                if (!string.IsNullOrWhiteSpace(ErrorMessage))
                {
                    errorMessage = ErrorMessage;
                }
                
                return new ValidationResult(
                    errorMessage,
                    new[] {nameof(CourseForManipulationDto)});
            }

            return ValidationResult.Success;
        }
    }
}