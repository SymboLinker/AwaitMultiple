# AwaitMultiple

Await multiple tasks in parallel and get their return values with concise code.


## How to use and why

AwaitMultiple can be used like this up to 16 arguments:
```cs
var (value1, value2, value3) = await Tasks(task1, task2, task3);
```

Add:
```cs
global using static AwaitMultiple.Await;
```

Write
```cs
var (books, employees) = await Tasks(
   dbConnection.GetAllAsync<Books>(),
   dbConnection.GetAllAsync<Employees>());
```
instead of
```cs
var books = await dbConnection.GetAllAsync<Book>();
var employees = await dbConnection.GetAllAsync<Employee>();
```
because the latter code is not executing the employees-related task until the books-related task has finished.

## Additional option
Await tasks with and without return value together:
```cs
var (books, employees) = await Tasks(
   dbConnection.GetAllAsync<Books>(),
   dbConnection.GetAllAsync<Employees>(),
   [
      dbConnection.InsertHistoryRecordAsync(),
      // ... any number of tasks...
   ]);
```
or
```cs
var books = await Tasks(
   dbConnection.GetAllAsync<Books>(),
   [
      dbConnection.InsertHistoryRecordAsync(),
      // ... any number of tasks...
   ]);
```
or even (for code consistency):
```cs
await Tasks([
   dbConnection.InsertHistoryRecordAsync(),
   // ... any number of tasks...
]);
```

## Exception handling

In case of a cancellation, a `TaskCanceledException` is thrown.

Otherwise, all errors are returned in a single `AggregateException`. Its `Message` property is like:

> One or more errors occurred. (First exception message.) (Second exception message.)

Use the property `aggregateException.InnerExceptions` for more details like `StackTrace`s etc.


## Configuring the await

Optionally, you can configure the await:
```cs
var (books, employees) = await Tasks(
   dbConnection.GetAllAsync<Books>(),
   dbConnection.GetAllAsync<Employees>(),
   continueOnCapturedContext: false);
```


## Get it

Available via [NuGet](https://www.nuget.org/packages/AwaitMultiple).