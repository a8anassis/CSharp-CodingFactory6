namespace WebAppStarter.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }

        public Student() { }

        public Student(int id, string? firstname, string? lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }

        public override string? ToString()
        {
            return $"{Firstname} {Lastname}";
        }
    }
}
