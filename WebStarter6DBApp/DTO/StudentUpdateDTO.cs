using System.ComponentModel.DataAnnotations;

namespace WebStarter6DBApp.DTO
{
    public class StudentUpdateDTO : BaseDTO
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [MinLength(1, ErrorMessage = "Firstname must be at least 1 character long.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MinLength(1, ErrorMessage = "Lastname must be at least 1 character long.")]
        public string? Lastname { get; set; }

        public StudentUpdateDTO() { }

        public StudentUpdateDTO(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }

    //public record StudentUpdateDTO(
    //    [property: Required(ErrorMessage = "Firstname is required.")]
    //    [property: MinLength(1, ErrorMessage = "Firstname must be at least 1 character long.")]
    //    string? Firstname,

    //    [property: Required(ErrorMessage = "Lastname is required.")]
    //    [property: MinLength(1, ErrorMessage = "Lastname must be at least 1 character long.")]
    //    string? Lastname,

    //    int Id
    //) : BaseDTO(Id)
    //{
    //    // Parameterless constructor for model binding
    //    public StudentUpdateDTO() : this(null, null, 0) { }
    //}
}
