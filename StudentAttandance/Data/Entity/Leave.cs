namespace StudentAttandance.Data.Entity
{
    public class Leave : Base
    {
        public string Name { get; set; }
        public string RollNumber { get; set; }
        public string StandardName { get; set; }
        public string Message { get; set; }
        public int NumberOfDay { get; set;}
        public string Reply { get; set; }

    }
}
