namespace WebStarter6DBApp.DTO
{
    public class StudentReadOnlyDTO : BaseDTO
    {
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public StudentReadOnlyDTO() { }

        public StudentReadOnlyDTO(string? firstname, string? lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }

//    public record StudentReadOnlyDTO(
//        string? Firstname,
//        string? Lastname,
//        int Id
//    ) : BaseDTO(Id)
//    {
//        // Parameterless constructor for model binding / object initializers
//        public StudentReadOnlyDTO() : this(null, null, 0) { }
//    }
}
