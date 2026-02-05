using System.Collections.ObjectModel;
using WSE.Domain;

namespace WSE.StudentApp.ViewModels;

public class CoursesViewModel
{
    public ObservableCollection<Course> Courses { get; set; } = new();

    public void LoadMockData()
    {
        Courses.Add(new Course { Title = "Algebra I", Description = "Basics of linear equations." });
        Courses.Add(new Course { Title = "Calculus II", Description = "Integration and series." });
    }
}
