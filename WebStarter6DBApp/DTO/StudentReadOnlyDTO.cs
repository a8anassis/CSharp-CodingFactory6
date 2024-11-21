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
}
