namespace StudentAttandance.Data.Entity
{
    public class Attendance : Base
    {
        public string RollNumber { get; set; }
        public string Name { get; set;}
        public DateTime AttendanceDate { get; set;}
        public string Status { get; set; }
        public string StaffName { get; set; }

    }
}
