using Skaalab_Exercise2.Services;

var studentService = new StudentService();

// The student who is enrolled in the highest number of courses
var studentWithMostCourses = studentService.GetStudentWithMostCourses();
Console.WriteLine($"The student who is enrolled in the highest number of courses is: {studentWithMostCourses.StudentName}");

//the students who are taking more than 3 courses, find the student who is taking the highest total number of credits.
var studentWithHighestCredits = studentService.GetStudentWithHighestCredits();

if (studentWithHighestCredits != null)
{
    Console.WriteLine($"Student with the highest credits among those taking more than 3 courses: {studentWithHighestCredits.StudentName}");
}
else
{
    Console.WriteLine("No students found.");
}

// List of students who are taking a specific course, sorted by student name
string course = "Algo"; 
var studentsTakingCourse = studentService.GetStudentsTakingCourse(course);

if (studentsTakingCourse.Any())
{
    Console.WriteLine($"Students taking {course}:");
    foreach (var student in studentsTakingCourse)
    {
        Console.WriteLine($"Student Name: {student.StudentName}");
    }
}
else
{
    Console.WriteLine($"No students found taking {course}.");
}

Console.ReadKey();
