# Todo REST API with Postman Automation

A simple REST API backend for a Todo application built with **Node.js**. This project demonstrates REST API development, CRUD operations, authentication, environment variables, and automated API testing using **Postman**.

## Features

- REST API built with Node.js
- Complete CRUD operations for Todos
- User authentication with token
- Postman Environment Variables
- Automated API validation using Postman Tests
- Response validation
- Error handling
- Variable chaining between requests

---

## Technologies

- Node.js
- JavaScript
- Express.js
- Postman
- REST API

---

## Project Structure

```
project/
│
├── index.js                 # REST API server
├── package.json
├── Postman Collection.json
├── Postman Environment.json
└── README.md
```

---

## API Endpoints

| Method | Endpoint | Description |
|---------|----------|-------------|
| POST | /login | User login |
| POST | /todos | Create Todo |
| GET | /todos | Get all Todos |
| GET | /todos/:id | Get Todo by ID |
| PUT | /todos/:id | Update Todo |
| DELETE | /todos/:id | Delete Todo |

---

## Postman Testing

The project includes automated API tests using Postman.

The tests verify:

- Status codes
- Response body
- Required fields
- Authentication
- CRUD functionality
- Environment variables
- Dynamic Todo ID storage

---

## Learning Objectives

This project was created to practice:

- REST API development
- HTTP methods (GET, POST, PUT, DELETE)
- Authentication
- API testing with Postman
- Writing automated API tests
- Using Postman Environment Variables
- Response validation
- API debugging

---

## Future Improvements

- Database integration (MongoDB)
- Docker support
- CI/CD pipeline
- Newman automated test execution
- GitHub Actions

---

## Author

**Muhammad Arslan Majid**
<<<<<<< HEAD
