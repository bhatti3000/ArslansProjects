import express from 'express';
import cors from 'cors';

const app = express();
const PORT = 3000;

app.use(cors());
app.use(express.json());

// ---- In-memory storage ----
let users = [];
let todos = [];
let userIdCounter = 1;
let todoIdCounter = 1;

// ---- Helpers ----
function generateToken(email) {
	return `token-${email}-${Date.now()}`;
}

function authMiddleware(req, res, next) {
	const authHeader = req.headers.authorization;

	if (!authHeader || !authHeader.startsWith('Bearer ')) {
		return res.status(401).json({ message: 'Unauthorized' });
	}

	const token = authHeader.split(' ')[1];
	const user = users.find((u) => u.token === token);

	if (!user) {
		return res.status(401).json({ message: 'Invalid token' });
	}

	req.user = user;
	next();
}

// ---- Auth routes ----
app.post('/auth/register', (req, res) => {
	const { email, password } = req.body;

	if (!email || !password) {
		return res.status(400).json({ message: 'Email and password required' });
	}

	const existingUser = users.find((u) => u.email === email);
	if (existingUser) {
		return res.status(400).json({ message: 'User already exists' });
	}

	const newUser = {
		id: userIdCounter++,
		email,
		password,
		token: null,
	};

	users.push(newUser);

	res.status(201).json({
		id: newUser.id,
		email: newUser.email,
	});
});

app.post('/auth/login', (req, res) => {
	const { email, password } = req.body;

	const user = users.find((u) => u.email === email && u.password === password);

	if (!user) {
		return res.status(401).json({ message: 'Invalid credentials' });
	}

	const token = generateToken(email);
	user.token = token;

	res.json({ token });
});

// ---- Todo routes (protected) ----
app.get('/todos', authMiddleware, (req, res) => {
	const userTodos = todos.filter((t) => t.userId === req.user.id);
	res.json(userTodos);
});

app.post('/todos', authMiddleware, (req, res) => {
	const { title } = req.body;

	if (!title) {
		return res.status(400).json({ message: 'Title is required' });
	}

	const newTodo = {
		id: todoIdCounter++,
		title,
		completed: false,
		userId: req.user.id,
	};

	todos.push(newTodo);
	res.status(201).json(newTodo);
});

app.put('/todos/:id', authMiddleware, (req, res) => {
	const todoId = Number(req.params.id);
	const { title, completed } = req.body;

	const todo = todos.find((t) => t.id === todoId && t.userId === req.user.id);

	if (!todo) {
		return res.status(404).json({ message: 'Todo not found' });
	}

	if (title !== undefined) todo.title = title;
	if (completed !== undefined) todo.completed = completed;

	res.json(todo);
});

app.delete('/todos/:id', authMiddleware, (req, res) => {
	const todoId = Number(req.params.id);

	const index = todos.findIndex((t) => t.id === todoId && t.userId === req.user.id);

	if (index === -1) {
		return res.status(404).json({ message: 'Todo not found' });
	}

	todos.splice(index, 1);
	res.json({ message: 'Todo deleted' });
});

// ---- Health check ----
app.get('/', (req, res) => {
	res.json({ status: 'API is running' });
});

app.listen(PORT, () => {
	console.log(`Demo API running at http://localhost:${PORT}`);
});
