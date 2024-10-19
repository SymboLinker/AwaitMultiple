namespace AwaitMultiple
{
    public static class Await
    {
        public static async Task<(T1, T2)> tasks<T1, T2>(
            Task<T1> task1, Task<T2> task2)
        {
            var t1 = await task1;
            var t2 = await task2;
            return (t1, t2);
        }

        public static async Task<(T1, T2, T3)> tasks<T1, T2, T3>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            return (t1, t2, t3);
        }

        public static async Task<(T1, T2, T3, T4)> tasks<T1, T2, T3, T4>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            return (t1, t2, t3, t4);
        }

        public static async Task<(T1, T2, T3, T4, T5)> tasks<T1, T2, T3, T4, T5>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            return (t1, t2, t3, t4, t5);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6)> tasks<T1, T2, T3, T4, T5, T6>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            return (t1, t2, t3, t4, t5, t6);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7)> tasks<T1, T2, T3, T4, T5, T6, T7>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            return (t1, t2, t3, t4, t5, t6, t7);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8)> tasks<T1, T2, T3, T4, T5, T6, T7, T8>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            return (t1, t2, t3, t4, t5, t6, t7, t8);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9)> tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5, Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            var t12 = await task12;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            var t12 = await task12;
            var t13 = await task13;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            var t12 = await task12;
            var t13 = await task13;
            var t14 = await task14;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            var t12 = await task12;
            var t13 = await task13;
            var t14 = await task14;
            var t15 = await task15;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15);
        }

        public static async Task<(T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16)>
            tasks<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(
            Task<T1> task1, Task<T2> task2, Task<T3> task3, Task<T4> task4, Task<T5> task5,
            Task<T6> task6, Task<T7> task7, Task<T8> task8, Task<T9> task9, Task<T10> task10,
            Task<T11> task11, Task<T12> task12, Task<T13> task13, Task<T14> task14, Task<T15> task15,
            Task<T16> task16)
        {
            var t1 = await task1;
            var t2 = await task2;
            var t3 = await task3;
            var t4 = await task4;
            var t5 = await task5;
            var t6 = await task6;
            var t7 = await task7;
            var t8 = await task8;
            var t9 = await task9;
            var t10 = await task10;
            var t11 = await task11;
            var t12 = await task12;
            var t13 = await task13;
            var t14 = await task14;
            var t15 = await task15;
            var t16 = await task16;
            return (t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16);
        }
    }
}
