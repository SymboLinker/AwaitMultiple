using System.Diagnostics;

namespace AwaitMultiple.Tests;

public class AwaitMultipleTests
{
    const int _expectedTotalTime = 140;

    [Fact]
    public async Task TestBasic()
    {
        var input1 = 4;
        var input2 = true;
        var input3 = "Hello";
        var input4 = DateTime.Now;
        var input5 = new object();

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
    }

    [Fact]
    public async Task TestBasicCombiningWithAndWithoutReturnValue()
    {
        var input1 = 4;
        var input2 = true;
        var input3 = "Hello";

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            [
                MyTaskWithoutReturnValue(),
                Task.Delay(200),
            ]);

        stopWatch.Stop();
        Assert.True(
            199 < stopWatch.ElapsedMilliseconds
                && stopWatch.ElapsedMilliseconds < 240);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
    }

    private Task MyTaskWithoutReturnValue() => Task.Delay(10);

    const int input1 = 1;
    const int input2 = 2;
    const int input3 = 3;
    const int input4 = 4;
    const int input5 = 5;
    const int input6 = 6;
    const int input7 = 7;
    const int input8 = 8;
    const int input9 = 9;
    const int input10 = 10;
    const int input11 = 11;
    const int input12 = 12;
    const int input13 = 13;
    const int input14 = 14;
    const int input15 = 15;
    const int input16 = 16;

    [Fact]
    public async Task TestReturnsCorrectValues02()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
    }

    [Fact]
    public async Task TestReturnsCorrectValues03()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
    }

    [Fact]
    public async Task TestReturnsCorrectValues04()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
    }

    [Fact]
    public async Task TestReturnsCorrectValues05()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
    }

    [Fact]
    public async Task TestReturnsCorrectValues06()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
    }

    [Fact]
    public async Task TestReturnsCorrectValues07()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
    }

    [Fact]
    public async Task TestReturnsCorrectValues08()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
    }

    [Fact]
    public async Task TestReturnsCorrectValues09()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
    }

    [Fact]
    public async Task TestReturnsCorrectValues10()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
    }

    [Fact]
    public async Task TestReturnsCorrectValues11()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10, output11) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
    }

    [Fact]
    public async Task TestReturnsCorrectValues12()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10, output11, output12) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11),
            Delay100AndReturn(input12));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
        Assert.Equal(input12, output12);
    }

    [Fact]
    public async Task TestReturnsCorrectValues13()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10, output11, output12, output13) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11),
            Delay100AndReturn(input12),
            Delay100AndReturn(input13));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
        Assert.Equal(input12, output12);
        Assert.Equal(input13, output13);
    }

    [Fact]
    public async Task TestReturnsCorrectValues14()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10, output11, output12, output13, output14) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11),
            Delay100AndReturn(input12),
            Delay100AndReturn(input13),
            Delay100AndReturn(input14));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
        Assert.Equal(input12, output12);
        Assert.Equal(input13, output13);
        Assert.Equal(input14, output14);
    }

    [Fact]
    public async Task TestReturnsCorrectValues15()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10, output11, output12, output13, output14, output15) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11),
            Delay100AndReturn(input12),
            Delay100AndReturn(input13),
            Delay100AndReturn(input14),
            Delay100AndReturn(input15));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
        Assert.Equal(input12, output12);
        Assert.Equal(input13, output13);
        Assert.Equal(input14, output14);
        Assert.Equal(input15, output15);
    }

    [Fact]
    public async Task TestReturnsCorrectValues16()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        var (output1, output2, output3, output4, output5, output6, output7, output8, output9, output10,
            output11, output12, output13, output14, output15, output16) = await Tasks(
            Delay100AndReturn(input1),
            Delay100AndReturn(input2),
            Delay100AndReturn(input3),
            Delay100AndReturn(input4),
            Delay100AndReturn(input5),
            Delay100AndReturn(input6),
            Delay100AndReturn(input7),
            Delay100AndReturn(input8),
            Delay100AndReturn(input9),
            Delay100AndReturn(input10),
            Delay100AndReturn(input11),
            Delay100AndReturn(input12),
            Delay100AndReturn(input13),
            Delay100AndReturn(input14),
            Delay100AndReturn(input15),
            Delay100AndReturn(input16));

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.Equal(input1, output1);
        Assert.Equal(input2, output2);
        Assert.Equal(input3, output3);
        Assert.Equal(input4, output4);
        Assert.Equal(input5, output5);
        Assert.Equal(input6, output6);
        Assert.Equal(input7, output7);
        Assert.Equal(input8, output8);
        Assert.Equal(input9, output9);
        Assert.Equal(input10, output10);
        Assert.Equal(input11, output11);
        Assert.Equal(input12, output12);
        Assert.Equal(input13, output13);
        Assert.Equal(input14, output14);
        Assert.Equal(input15, output15);
        Assert.Equal(input16, output16);
    }

    [Theory]
    [InlineData(ExceptionOption.Default)]
    [InlineData(ExceptionOption.Aggregate)]
    public async Task TestExceptionHandlingSingleError(ExceptionOption exceptionOption)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2) = await Tasks(
                Delay100AndReturn("uninteresting"),
                FailingTaskAfterMilliseconds(2),
                exceptionOption: exceptionOption);
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.NotNull(exception);
        if (exceptionOption is ExceptionOption.Aggregate)
        {
            Assert.Equal("One or more errors occurred. (Hi there from the 2ms task.)", exception.Message);

            var aggregateException = Assert.IsType<AggregateException>(exception);
            var message = aggregateException.InnerExceptions.Select(x => x.Message).Single();
            Assert.Equal("Hi there from the 2ms task.", message);
        }
        else
        {
            Assert.IsNotType<AggregateException>(exception);
            Assert.Equal("Hi there from the 2ms task.", exception.Message);
        }
    }

    [Theory]
    [InlineData(ExceptionOption.Default)]
    [InlineData(ExceptionOption.Aggregate)]
    public async Task TestExceptionHandlingMultipleErrors(ExceptionOption exceptionOption)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2, output3) = await Tasks(
                FailingTaskAfterMilliseconds(80),
                FailingTaskAfterMilliseconds(2),
                FailingTaskAfterMilliseconds(105),
                exceptionOption: exceptionOption);
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.NotNull(exception);
        if (exceptionOption is ExceptionOption.Aggregate)
        {
            Assert.Equal("""One or more errors occurred. (Hi there from the 2ms task.) (Hi there from the 80ms task.) (Hi there from the 105ms task.)""", exception.Message);

            var aggregateException = Assert.IsType<AggregateException>(exception);
            var messages = aggregateException.InnerExceptions.Select(x => x.Message);
            Assert.Contains("Hi there from the 2ms task.", messages);
            Assert.Contains("Hi there from the 80ms task.", messages);
            Assert.Contains("Hi there from the 105ms task.", messages);
        }
        else
        {
            Assert.IsNotType<AggregateException>(exception);
            Assert.Equal("Hi there from the 2ms task.", exception.Message);
        }
    }

    [Theory]
    [InlineData(ExceptionOption.Default, 10)]
    [InlineData(ExceptionOption.Aggregate, 10)]
    [InlineData(ExceptionOption.Default, 150)]
    [InlineData(ExceptionOption.Aggregate, 150)]
    public async Task TestCancelledExceptionHandling(ExceptionOption exceptionOption, int cancelAfterMilliseconds)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2) = await Tasks(
                Delay100AndReturn("uninteresting"),
                CancelAfterMilliseconds(cancelAfterMilliseconds),
                exceptionOption: exceptionOption);
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();
        Assert.True(stopWatch.ElapsedMilliseconds < 190);

        Assert.NotNull(exception);
        if (exceptionOption is ExceptionOption.Aggregate)
        {
            Assert.Equal("One or more errors occurred. (A task was canceled.)", exception.Message);
            var aggregateException = Assert.IsType<AggregateException>(exception);
            var innerException = Assert.Single(aggregateException.InnerExceptions);
            Assert.Equal("A task was canceled.", innerException.Message);
        }
        else
        {
            Assert.Equal("A task was canceled.", exception.Message);
            Assert.IsType<TaskCanceledException>(exception);
        }
    }

    [Fact]
    public async Task TestAwaitingIsStoppedAtCancellation()
    {
        var cancellationToken = new CancellationToken(canceled: true);

        var stopWatch = new Stopwatch();
        stopWatch.Start();

        try
        {
            var (output1, output2, output3) = await Tasks(
                Task.Run(() => DelayReturn(delayMilliseconds: 700, 1)),
                Task.Run(() => WaitEndlesslyForInt(2, cancellationToken)),
                Task.Run(() => DelayReturn(delayMilliseconds: 700, 3)),
                exceptionOption: ExceptionOption.Aggregate);
        }
        catch (Exception ex)
        {
            stopWatch.Stop();
            Assert.True(stopWatch.ElapsedMilliseconds < 150);

            var aggregateException = Assert.IsType<AggregateException>(ex);
            var taskCanceledException = Assert.IsType<TaskCanceledException>(Assert.Single(aggregateException.InnerExceptions));
            Assert.Equal("A task was canceled.", taskCanceledException.Message);
            return;
        }

        Assert.Fail();

        static async Task<int> DelayReturn(int delayMilliseconds, int i)
        {
            await Task.Delay(100);
            return i;
        }

        static async Task<int> WaitEndlesslyForInt(int i, CancellationToken cancellationToken)
        {
            await Task.Delay(-1, cancellationToken);
            return i;
        }
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions00(int numberOfTasksWithoutReturnValue)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        try
        {
            await Tasks(
                Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
                ExceptionOption.Aggregate);
        }
        catch (AggregateException ex)
        {
            stopWatch.Stop();
            Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

            var messages = ex.InnerExceptions.Select(x => x.Message);
            for (var i = 1; i <= numberOfTasksWithoutReturnValue; i++)
            {
                Assert.Contains($"Task without return value {i} has thrown.", messages);
            }
            return;
        }

        Assert.Fail();
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions01(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(1, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions02(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(2, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions03(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(3, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions04(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(4, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions05(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(5, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions06(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(6, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions07(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(7, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions08(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(8, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions09(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(9, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions10(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(10, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions11(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(11, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions12(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(12, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            ThrowWithTaskNumber(12),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions13(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(13, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            ThrowWithTaskNumber(12),
            ThrowWithTaskNumber(13),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions14(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(14, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            ThrowWithTaskNumber(12),
            ThrowWithTaskNumber(13),
            ThrowWithTaskNumber(14),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions15(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(15, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            ThrowWithTaskNumber(12),
            ThrowWithTaskNumber(13),
            ThrowWithTaskNumber(14),
            ThrowWithTaskNumber(15),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    [Theory]
    [InlineData(0)]
    [InlineData(1)]
    [InlineData(2)]
    public static async Task TestCanAggregateExceptions16(int numberOfTasksWithoutReturnValue)
    {
        await TestCanAggregateExceptions(16, numberOfTasksWithoutReturnValue, () => Tasks(
            ThrowWithTaskNumber(1),
            ThrowWithTaskNumber(2),
            ThrowWithTaskNumber(3),
            ThrowWithTaskNumber(4),
            ThrowWithTaskNumber(5),
            ThrowWithTaskNumber(6),
            ThrowWithTaskNumber(7),
            ThrowWithTaskNumber(8),
            ThrowWithTaskNumber(9),
            ThrowWithTaskNumber(10),
            ThrowWithTaskNumber(11),
            ThrowWithTaskNumber(12),
            ThrowWithTaskNumber(13),
            ThrowWithTaskNumber(14),
            ThrowWithTaskNumber(15),
            ThrowWithTaskNumber(16),
            Enumerable.Range(1, numberOfTasksWithoutReturnValue).Select(ThrowWithTaskNumberWithoutReturnValue),
            ExceptionOption.Aggregate)
        );
    }

    private static async Task TestCanAggregateExceptions(int withReturnValue, int withoutReturnValue, Func<Task> act)
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        try
        {
            await act();
        }
        catch (AggregateException ex)
        {
            stopWatch.Stop();
            Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

            var messages = ex.InnerExceptions.Select(x => x.Message);
            for (var i = 1; i <= withReturnValue; i++)
            {
                Assert.Contains($"Task with return value {i} has thrown.", messages);
            }
            for (var i = 1; i <= withoutReturnValue; i++)
            {
                Assert.Contains($"Task without return value {i} has thrown.", messages);
            }
            return;
        }

        Assert.Fail();
    }

    private static async Task<int> FailingTaskAfterMilliseconds(int milliseconds)
    {
        await Task.Delay(milliseconds);
        throw new Exception($"Hi there from the {milliseconds}ms task.");
    }

    private static async Task<int> CancelAfterMilliseconds(int milliseconds)
    {
        var cancellationToken = new CancellationTokenSource();
        cancellationToken.CancelAfter(milliseconds);
        await Task.Delay(milliseconds + 30, cancellationToken.Token);
        return 6789;
    }

    private static async Task<T> Delay100AndReturn<T>(T value)
    {
        await Task.Delay(100);
        return value;
    }

    private static async Task<int> ThrowWithTaskNumber(int i)
    {
        await Task.Delay(30);
        throw new Exception($"Task with return value {i} has thrown.");
    }

    private static async Task ThrowWithTaskNumberWithoutReturnValue(int i)
    {
        await Task.Delay(30);
        throw new Exception($"Task without return value {i} has thrown.");
    }
}