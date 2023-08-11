using Skaalab_Exercise2.Models;

namespace Skaalab_Exercise2.Services;
public class StudentService
{
    private readonly IEnumerable<Course> _courses;
    private readonly IEnumerable<Student> _students;

    public StudentService()
    {
        _courses = GetCourses();
        _students = GetStudents();
    }

    public Student GetStudentWithMostCourses()
    {
        return _students.OrderByDescending(student => student.Courses.Count).First();
    }

    public Student? GetStudentWithHighestCredits()
    {
        return _students
               .Where(student => student.Courses.Count > 3)
               .OrderByDescending(student => student.Courses.Sum(course => course.Credits))
               .FirstOrDefault();
    }
    
    public IEnumerable<Student> GetStudentsTakingCourse(string course)
    {
        return _students
               .Where(student => student.Courses.Any(c => c.CourseName == course))
               .OrderBy(student => student.StudentName)
               .ToList();
    }

    private IEnumerable<Student> GetStudents()
    {

        return new List<Student>
        {
            new Student
            {
                StudentId = 1,
                StudentName = "Ahmed",
                Courses = _courses.Take(3).ToList()
            },
            new Student
            {
                StudentId = 2,
                StudentName = "Abdelmouain",
                Courses = _courses.Take(2..4).ToList()
            },
            new Student
            {
                StudentId = 3,
                StudentName = "Smail",
                Courses = _courses.Take(1).ToList()
            },
            new Student
            {
                StudentId = 4,
                StudentName = "Djawed",
                Courses = _courses.ToList()
            }
        };
    }

    private static IEnumerable<Course> GetCourses()
    {
        return new List<Course>
        {
            new Course
            {
                CourseId = 1,
                CourseName = "Algo",
                Credits = 5
            },
            new Course
            {
                CourseId = 2,
                CourseName = "Math",
                Credits = 3
            },
            new Course
            {
                CourseId = 3,
                CourseName = "English",
                Credits = 2
            },
            new Course
            {
                CourseId = 4,
                CourseName = "POO",
                Credits = 4
            },
            new Course
            {
                CourseId = 5,
                CourseName = "Database",
                Credits = 1
            },
        };
    }
}
