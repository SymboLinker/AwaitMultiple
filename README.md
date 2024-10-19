# AwaitMultiple

Await multiple tasks in parallel and get their return values with concise code.

AwaitMultiple can be used like this up to 16 arguments:
```cs
var (value1, value2, value3) = await tasks(task1, task2, task3);
```

Add:
```cs
global using static AwaitMultiple.Await;
```

Write
```cs
var (books, employees) = await tasks(
   dbConnection.GetAllAsync<Books>(),
   dbConnection.GetAllAsync<Employees>());
```
instead of
```cs
var books = await dbConnection.GetAllAsync<Book>();
var employees = await dbConnection.GetAllAsync<Employee>();
```
because the latter code is not executing the employee task until the books task has finished.


Available via NuGet.