# WSE Math API Specification

## Authentication
- **POST** `/api/auth/register`: Create a new student account.
- **POST** `/api/auth/login`: Returns a JWT token.

## Courses
- **GET** `/api/courses`: Retrieve all math courses.
- **POST** `/api/courses`: Add a new course (Admin only).

## Real-time (SignalR)
- **Hub URL**: `/hubs/classroom`
- **Methods**: 
    - `SendDrawCommand(x, y, color)`: Syncs whiteboard data.
    - `JoinClass(classId)`: Subscribes to a specific session.
