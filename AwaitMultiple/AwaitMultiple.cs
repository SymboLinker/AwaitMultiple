namespace AwaitMultiple;

public static class Await
{
    public static Task Tasks(IEnumerable<Task> tasksWithoutReturnValue, bool continueOnCapturedContext = true) => AggregateExceptions([], tasksWithoutReturnValue, continueOnCapturedContext);

    public static async Task<T1> Tasks<T1>(
        Task<T1> task1,
        IEnumerable<Task> tasksWithoutReturnValue,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1], tasksWithoutReturnValue, continueOnCapturedContext);
        return task1.Result;
    }

    public static async Task<(T1, T2)> Tasks<T1, T2>(
        Task<T1> task1, Task<T2> task2,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result);
    }

    public static async Task<(T1, T2, T3)> Tasks<T1, T2, T3>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result);
    }

    public static async Task<(T1, T2, T3, T4)> Tasks<T1, T2, T3, T4>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5)> Tasks<T1, T2, T3, T4, T5>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6)> Tasks<T1, T2, T3, T4, T5, T6>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7)> Tasks<T1, T2, T3, T4, T5, T6, T7>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result);

    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result, task12.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result, task12.Result, task13.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result, task12.Result, task13.Result, task14.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result, task12.Result, task13.Result, task14.Result, task15.Result);
    }

    public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)> Tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
        Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10, Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15, Task<T16> task16,
        IEnumerable<Task>? tasksWithoutReturnValue = null,
        bool continueOnCapturedContext = true)
    {
        await AggregateExceptions([task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11, task12, task13, task14, task15, task16], tasksWithoutReturnValue, continueOnCapturedContext);
        return (task1.Result, task2.Result, task3.Result, task4.Result, task5.Result, task6.Result, task7.Result, task8.Result, task9.Result, task10.Result, task11.Result, task12.Result, task13.Result, task14.Result, task15.Result, task16.Result);
    }

    private static async Task AggregateExceptions(IEnumerable<Task> tasks, IEnumerable<Task>? moreTasks, bool continueOnCapturedContext)
    {
        if (moreTasks != null)
        {
            tasks = tasks.Concat(moreTasks);
        }
        var whenAll = Task.WhenAll(tasks);
        try
        {
            await whenAll.ConfigureAwait(continueOnCapturedContext);
        }
        catch (Exception ex)
        {
            throw whenAll.Exception ?? ex;
        }
    }
}