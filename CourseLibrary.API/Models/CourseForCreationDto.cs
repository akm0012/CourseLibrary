using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    [CourseTitleMustBeDifferentFromDescription(ErrorMessage = "The title must be different son!")]
    public class CourseForCreationDto //: IValidatableObject
    {
        private const int MaxTitleLength = 100; 
        
        [Required(ErrorMessage = "You need a title yo!")] 
        [MaxLength(MaxTitleLength, ErrorMessage = "The Title is toooooo long. Can only be 100 characters.")] 
        public string Title { get; set; }

        [MaxLength(1500, ErrorMessage = "The Description is toooooo long. Can only be 1500 characters.")] 
        public string Description { get; set; }

        // public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        // {
        //     // BizLogic: The Title can not match the description 
        //     if (Title == Description)
        //     {
        //         yield return new ValidationResult(
        //             "The provided description should be different than the title.",
        //             new[] {"CourseForCreationDto"});
        //     }
        // }
    }
}