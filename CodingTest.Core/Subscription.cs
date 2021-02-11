using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CodingTest.Core
{
    public class Subscription
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Email adress is required")]        
        [EmailAddress]
        public string Email { get; set; }
        
        [DisplayName("How did you hear about us")]
        public SourceType SourceOfInformation { get; set; }
        
        [DisplayName("Reason for signing up")]
        [StringLength(255)]
        public string SignupReason { get; set; }
    }
}
