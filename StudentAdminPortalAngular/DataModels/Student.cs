namespace StudentAdminPortalAngular.DataModels
{
    public class Student
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBearth { get; set; }
        public string? Email { get; set; }
        public string ? Password { get; set; }

        public long Mobile { get; set; }

        public string? ProfileImageUrl { get; set; }

        public Guid GenderId { get; set; }
        
        //Navigation Property
        public Gender Gender { get; set; }

        public Address Address { get; set; }
    }
}
