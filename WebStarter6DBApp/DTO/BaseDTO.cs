using System.ComponentModel.DataAnnotations;

namespace WebStarter6DBApp.DTO
{
    public abstract class BaseDTO
    {
        [Required(ErrorMessage = "The {0} is required.")]
        public int Id { get; set; }

        public BaseDTO() { }

        protected BaseDTO(int id)
        {
            Id = id;
        }
    }

//    public abstract record BaseDTO(
//    [property: Required(ErrorMessage = "The {0} is required.")]
//    int Id
//)
//    {
//        // Parameterless constructor → allows object initializers / model binding
//        public BaseDTO() : this(0) { }
//    }
}
