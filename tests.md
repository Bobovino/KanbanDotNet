# API Endpoint Tests

## Boards

### Get all boards

curl -X GET http://localhost:5000/api/boards

curl -X GET http://localhost:5000/api/boards/1

curl -X POST http://localhost:5000/api/boards \
-H "Content-Type: application/json" \
-d '{"id": 1, "name": "New Board", "tasks": []}'

curl -X PUT http://localhost:5000/api/boards/1 \
-H "Content-Type: application/json" \
-d '{"id": 1, "name": "Updated Board", "tasks": []}'curl -X DELETE http://localhost:5000/api/boards/1

curl -X GET http://localhost:5000/api/tasks

curl -X GET http://localhost:5000/api/tasks/1curl -X POST http://localhost:5000/api/tasks \
-H "Content-Type: application/json" \
-d '{"id": 1, "title": "New Task", "description": "Task description", "status": "ToDo", "boardId": 1}'

curl -X PUT http://localhost:5000/api/tasks/1 \
-H "Content-Type: application/json" \
-d '{"id": 1, "title": "Updated Task", "description": "Updated description", "status": "InProgress", "boardId": 1}'

curl -X DELETE http://localhost:5000/api/tasks/1