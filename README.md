# AwaitMultiple

Await multiple tasks in parallel and get their return values with concise code.


## How to use and why

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
because the latter code is not executing the employees-related task until the books-related task has finished.


## Exception handling

If one or multiple tasks throw, then
- in case of a cancellation, a `TaskCanceledException` is thrown
- otherwise, all errors are returned in a single `AggregateException`. Use the property `aggregateException.InnerExceptions` to find them.


## Get it

Available via [NuGet](https://www.nuget.org/packages/AwaitMultiple).