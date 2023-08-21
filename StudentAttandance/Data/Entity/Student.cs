namespace StudentAttandance.Data.Entity
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string DivisionName { get; set; }
        public DateTime DOB { get; set; }
        public string StandardName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public int Pincode { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }

    }
}
