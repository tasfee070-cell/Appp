# WSE Math Student Platform

A specialized educational platform for math students featuring real-time collaboration, function plotting, and course management.

## 🚀 Tech Stack
- **Client:** WinUI 3 (Windows App SDK)
- **Backend:** ASP.NET Core 9.0 Web API
- **Real-time:** SignalR for Live Classes
- **Database:** PostgreSQL via Entity Framework Core
- **Infra:** Docker & Docker Compose
- **CI/CD:** GitHub Actions

## 🏗️ Architecture
The project follows a **Clean Architecture** pattern to separate concerns:
- `src/libs/WSE.Domain`: Core models and business rules.
- `src/server/WSE.Api`: RESTful endpoints and database logic.
- `src/client/WSE.StudentApp`: Windows desktop UI using MVVM.
- `src/client/WSE.Tools`: Reusable math-specific UI controls.

## 🛠️ Getting Started
1. **Infra:** Run `docker-compose up` in the `src/infra` folder to start the DB.
2. **Backend:** Navigate to `src/server/WSE.Api` and run `dotnet run`.
3. **Frontend:** Open the solution in Visual Studio 2022 and launch `WSE.StudentApp`.

## 📈 Math Features
Includes a custom **Plotting Engine** capable of generating coordinate sets for complex functions, ready to be rendered in the WinUI 3 Canvas.
