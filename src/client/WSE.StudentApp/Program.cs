using Microsoft.UI.Xaml;
using System;
namespace WSE.StudentApp {
    public partial class Program {
        [STAThread]
        static void Main(string[] args) {
            Application.Start((p) => new App());
        }
    }
}
