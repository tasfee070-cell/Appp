using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace WSE.StudentApp.ViewModels {
    public class CourseDto {
        public string Id { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string PriceText => Price <= 0 ? "Free" : $"${Price:F2}";
        public ICommand OpenCommand { get; set; }
    }
    public class CoursesViewModel : ObservableObject {
        public ObservableCollection<CourseDto> Courses { get; } = new();
        public CoursesViewModel() {
            Courses.Add(new CourseDto { Id = "math101", Title = "Calculus I", Price = 0, OpenCommand = new RelayCommand(() => {}) });
        }
    }
}
