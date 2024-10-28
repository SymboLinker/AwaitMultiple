[![NuGet](https://img.shields.io/nuget/vpre/AwaitMultiple.svg)](https://www.nuget.org/packages/AwaitMultiple)

# AwaitMultiple

Await multiple tasks in parallel and get their return values with concise code.


## How to use and why

AwaitMultiple can be used like this up to 16 arguments:
```cs
var (value1, value2, value3) = await Tasks(task1, task2, task3);
```

Add:
```cs
global using static AwaitMultiple.__Await;
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


## Optional feature
Await tasks with and without return value in a single call:
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
For code consistency, you can also use:
```cs
await Tasks([
   dbConnection.InsertHistoryRecordAsync(),
   // ... any number of tasks...
]);
```


## Exception handling options

By default, only the first occurring exception is thrown (and the others are caught but not re-thrown).
This is consistent with `Task.WhenAll` and more parts of the C# language.

### Continue if one task fails
You may want to continue if "getting value `b`" fails. In that case, you could use the NuGet package [TaskExceptionCatcher](https://github.com/Symbolinker/TaskExceptionCatcher#readme) like this:
```cs
var (a, catchResultB, c) = await Tasks(
   StartTaskAAsync(),
   Catcher.Run(() => StartTaskBAsync()),
   StartTaskCAsync());
if (catchResultB.Exception is { } exception)
{
   // no problem!
}
else
{
   var b = catchResultB.Value;
   // use `b`.
}

// use `a` and `c`.
```

### Getting all the exceptions
If you're interested in not only the first, but all the exceptions:
- set the `exceptionOption` to `ExceptionOption.Aggregate`
- use `Task.Run` on all arguments, all tasks.
```cs
var (a, b) = await Tasks(
   Task.Run(() => StartTaskAAsync()),
   Task.Run(() => StartTaskBAsync()),
   exceptionOption: ExceptionOption.Aggregate);
```
Then all errors are returned in a single `AggregateException`. Its `Message` property is like:

> One or more errors occurred. (First exception message.) (Second exception message.)

Use the property `aggregateException.InnerExceptions` for more details like `StackTrace`s etc.

Why is `Task.Run` needed? Because `async` functions don't return a task until the first `await` keyword.
If an exception occurs before that, then that function throws even before it passes an argument into `Tasks`.


## Configuring awaits

**This section is for nerds only. Using `ConfigureAwait` is NOT necessary.**

AwaitMultiple uses `.ConfigureAwait(false)` internally. Programmers using AwaitMultiple in their own library can use `.ConfigureAwait(false)`:
```cs
var (books, employees) = await Tasks(
   dbConnection.GetAllAsync<Books>(),
   dbConnection.GetAllAsync<Employees>())
   .ConfigureAwait(false);
```

More details:
- The above is slightly better for performance. Normally, after having `await`ed an async operation, the "context" is set to the same as before the `await`. That costs time. In most libraries there is no need to capture and return to a specific context, so one might want to set `continueOnCapturedContext` to `false` in those libraries.
- Library writers using the above also avoid some deadlock problems for consumers that use their library wrongly.
- In app-level code you will probably not see `.ConfigureAwait(false)` being used. The performance gain is very small.
- One must not use `.ConfigureAwait(false)` in a method body that interacts with UI. It is fine to never use it at all.
- Writing `await task.ConfigureAwait(true);` is functionally identical to `await task;`, so you never need to use `.ConfigureAwait(true)`.

**Conclusion for consumers of this library**:
You don't need to use `ConfigureAwait` at all unless you're writing your own library code and want extra performance.


## Get it

Available via [NuGet](https://www.nuget.org/packages/AwaitMultiple).
