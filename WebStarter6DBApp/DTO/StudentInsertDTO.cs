using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace WebStarter6DBApp.DTO
{
    public class StudentInsertDTO
    {
        [Required(ErrorMessage = "Firstname is required.")]
        [MinLength(1, ErrorMessage = "Firstname must be at least 1 character long.")]
        public string? Firstname { get; set; }

        [Required(ErrorMessage = "Lastname is required.")]
        [MinLength(1, ErrorMessage = "Lastname must be at least 1 character long.")]
        public string? Lastname { get; set; }

        public StudentInsertDTO() { }

        public StudentInsertDTO(string? firstname, string? lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }

    //public record StudentInsertDTO(
    //    [property: Required(ErrorMessage = "Firstname is required.")]
    //    [property: MinLength(1, ErrorMessage = "Firstname must be at least 1 character long.")]
    //    string Firstname,

    //    [property: Required(ErrorMessage = "Lastname is required.")]
    //    [property: MinLength(1, ErrorMessage = "Lastname must be at least 1 character long.")]
    //    string Lastname,

    //    int Id
    //)
    //{
    //    // Parameterless constructor for model binding
    //    public Student() : this(string.Empty, string.Empty, 0) { }
    //}
}
