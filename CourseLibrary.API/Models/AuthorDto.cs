using System;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    
    // The Dto that is sent back with some custom fields not included in the DB entity 
    public class AuthorDto
    {
        public Guid Id { get; set; }

        public string FullName { get; set; }
        
        public int Age { get; set; }
        
        public string MainCategory { get; set; } 
    }
}