using System.ComponentModel.DataAnnotations;

namespace ShriSoft.SharedKernel.Entities
{
    public interface IMasterEntity
    {

        /// <summary>
        /// Alternate key. This is the unique code that will be used for retriving the values. 
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Please enter name with Minimum 7 character and maximum 200 charater.", MinimumLength = 7)]
        abstract string Code { get; set; }

        /// <summarys
        /// This is the display text for the master entity. This column detials will be used for displaying to user.  
        /// </summary>
        [Required]
        [StringLength(200, ErrorMessage = "Please enter name with Minimum 7 character and maximum 200 charater.", MinimumLength = 7)]
        abstract string Name { get; set; }
    }
}

