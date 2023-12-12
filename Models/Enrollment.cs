using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models;

public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{
    //This is the primary key
    //Ef Core automatically interprets it if its either:
    //ID {get; set;}
    //EnrollmentID {get; set;}
    public int EnrollmentID { get; set; }

    //These are foreign keys
    //Ef Core automatically interprets it if its either:
    //NavigationPropertyNameID {get; set;}
    //EnrollmentID {get; set;}
    public int CourseID { get; set; }
    public int StudentID { get; set; }

    //This is a nullable Enum
    [DisplayFormat(NullDisplayText = "No grade")]
    public Grade? Grade { get; set; }

    //These are navigation properties
    public Course? Course { get; set; }
    public Student? Student { get; set; }
}