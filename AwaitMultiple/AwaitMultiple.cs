﻿namespace AwaitMultiple
{
    public static class Await
    {
        public static async Task<(T1, T2)> tasks<T1, T2>(Task<T1> task1, Task<T2> task2)
        {
            await AggregateExceptions(task1, task2);
            return (await task1, await task2);
        }

        public static async Task<(T1, T2, T3)> tasks<T1, T2, T3>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            await AggregateExceptions(task1, task2, task3);
            return (await task1, await task2, await task3);
        }

        public static async Task<(T1, T2, T3, T4)> tasks<T1, T2, T3, T4>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
        {
            await AggregateExceptions(task1, task2, task3, task4);
            return (await task1, await task2, await task3, await task4);

        }

        public static async Task<(T1, T2, T3, T4, T5)> tasks<T1, T2, T3, T4, T5>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5);
            return (await task1, await task2, await task3, await task4, await task5);

        }

        public static async Task<(T1, T2, T3, T4, T5, T6)> tasks<T1, T2, T3, T4, T5, T6>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6);
            return (await task1, await task2, await task3, await task4, await task5, await task6);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7)> tasks<T1, T2, T3, T4, T5, T6, T7>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7);
            return (await task1, await task2, await task3, await task4, await task5, await task6, await task7);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> tasks<T1, T2, T3, T4, T5, T6, T7, T8>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8);
            return (await task1, await task2, await task3, await task4, await task5, await task6, await task7, await task8);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9);
            return (await task1, await task2, await task3, await task4, await task5, await task6, await task7, await task8, await task9);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10, task11);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
                                task11, task12);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11, await task12);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
                                task11, task12, task13);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11, await task12, await task13);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
                                task11, task12, task13, task14);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11, await task12, await task13, await task14);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
                                task11, task12, task13, task14, task15);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11, await task12, await task13, await task14, await task15);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15,
            Task<T16> task16)
        {
            await AggregateExceptions(task1, task2, task3, task4, task5, task6, task7, task8, task9, task10,
                                task11, task12, task13, task14, task15, task16);
            return (await task1, await task2, await task3, await task4, await task5,
                    await task6, await task7, await task8, await task9, await task10,
                    await task11, await task12, await task13, await task14, await task15,
                    await task16);
        }

        private static async Task AggregateExceptions(params Task[] tasks)
        {
            var whenAll = Task.WhenAll(tasks);
            try
            {
                await whenAll;
            }
            catch (Exception ex)
            {
                throw whenAll.Exception ?? ex;
            }
        }
    }
}
