namespace ContosoUniversity.Models;

public class Student
{
    public int ID { get; set; }
    public required string LastName { get; set; }
    public required string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    //This is a navigation property
    public ICollection<Enrollment>? Enrollments { get; set; }
}