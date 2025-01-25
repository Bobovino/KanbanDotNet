# Kanban API

This is a simple Kanban API built with ASP.NET Core. It allows users to manage boards and tasks in a Kanban-style project management system.

## Project Structure

- **Controllers**
  - `BoardController.cs`: Handles HTTP requests related to boards.
  - `TaskController.cs`: Handles HTTP requests related to tasks.

- **Models**
  - `Board.cs`: Defines the properties of a board.
  - `Task.cs`: Defines the properties of a task.

- **Services**
  - `BoardService.cs`: Contains business logic for managing boards.
  - `TaskService.cs`: Contains business logic for managing tasks.

- **KanbanApi.csproj**: Project file containing dependencies and build settings.

- **Program.cs**: Entry point of the application.

- **Startup.cs**: Configures services and the application's request pipeline.

## Setup Instructions

1. Clone the repository:
   ```
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```
   cd KanbanApi
   ```

3. Restore the dependencies:
   ```
   dotnet restore
   ```

4. Run the application:
   ```
   dotnet run
   ```

## API Usage

### Boards

- **GET /api/boards**: Retrieve all boards.
- **GET /api/boards/{id}**: Retrieve a specific board by ID.
- **POST /api/boards**: Create a new board.
- **PUT /api/boards/{id}**: Update an existing board.
- **DELETE /api/boards/{id}**: Delete a board.

### Tasks

- **GET /api/tasks**: Retrieve all tasks.
- **GET /api/tasks/{id}**: Retrieve a specific task by ID.
- **POST /api/tasks**: Create a new task.
- **PUT /api/tasks/{id}**: Update an existing task.
- **DELETE /api/tasks/{id}**: Delete a task.

## Contributing

Feel free to submit issues or pull requests for improvements or bug fixes.