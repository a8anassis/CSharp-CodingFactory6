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
}
