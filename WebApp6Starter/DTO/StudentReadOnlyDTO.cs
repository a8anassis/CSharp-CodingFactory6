namespace WebApp6Starter.DTO
{
    public class StudentReadOnlyDTO
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public StudentReadOnlyDTO() { }

        public StudentReadOnlyDTO(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string? ToString()
        {
            return $"{Id} {Firstname} {Lastname}";
        }
    }
}
