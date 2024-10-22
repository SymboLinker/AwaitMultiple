using System.Diagnostics;

namespace AwaitMultiple.Tests;

public class AwaitMultipleTests
{
    const int _expectedTotalTime = 140;

    [Fact]
    public async Task Test()
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
    public async Task Test02()
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
    public async Task Test03()
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
    public async Task Test04()
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
    public async Task Test05()
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
    public async Task Test06()
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
    public async Task Test07()
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
    public async Task Test08()
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
    public async Task Test09()
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
    public async Task Test10()
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
    public async Task Test11()
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
    public async Task Test12()
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
    public async Task Test13()
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
    public async Task Test14()
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
    public async Task Test15()
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
    public async Task Test16()
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

    [Fact]
    public async Task TestExceptionHandlingSingleError()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2) = await Tasks(
                Delay100AndReturn("uninteresting"),
                FailingTaskAfterMilliseconds(2));
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();

        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.NotNull(exception);
        Assert.Equal("One or more errors occurred. (Hi there from the 2ms task.)", exception.Message);

        var aggregateException = Assert.IsType<AggregateException>(exception);
        var message = aggregateException.InnerExceptions.Select(x => x.Message).Single();
        Assert.Equal("Hi there from the 2ms task.", message);
    }

    [Fact]
    public async Task TestExceptionHandlingMultipleErrors()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2, output3) = await Tasks(
                FailingTaskAfterMilliseconds(100),
                FailingTaskAfterMilliseconds(2),
                FailingTaskAfterMilliseconds(105));
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();

        Assert.True(stopWatch.ElapsedMilliseconds < _expectedTotalTime);

        Assert.NotNull(exception);
        Assert.Equal("""One or more errors occurred. (Hi there from the 2ms task.) (Hi there from the 100ms task.) (Hi there from the 105ms task.)""", exception.Message);

        var aggregateException = Assert.IsType<AggregateException>(exception);
        var messages = aggregateException.InnerExceptions.Select(x => x.Message);
        Assert.Contains("Hi there from the 2ms task.", messages);
        Assert.Contains("Hi there from the 100ms task.", messages);
        Assert.Contains("Hi there from the 105ms task.", messages);
    }

    [Fact]
    public async Task TestCancelledExceptionHandling2()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2) = await Tasks(
                Delay100AndReturn("uninteresting"),
                CancelAfterMilliseconds(150));
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();

        Assert.True(stopWatch.ElapsedMilliseconds < 190);

        Assert.NotNull(exception);
        Assert.Equal("A task was canceled.", exception.Message);
        Assert.IsType<TaskCanceledException>(exception);
    }

    [Fact]
    public async Task TestCancelledExceptionHandling1()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();

        Exception? exception = null;
        try
        {
            var (output1, output2) = await Tasks(
                Delay100AndReturn("uninteresting"),
                CancelAfterMilliseconds(10));
        }
        catch (Exception ex)
        {
            exception = ex;
        }

        stopWatch.Stop();

        Assert.True(stopWatch.ElapsedMilliseconds < 190);

        Assert.NotNull(exception);
        Assert.Equal("A task was canceled.", exception.Message);
        Assert.IsType<TaskCanceledException>(exception);
    }

    public static async Task<int> FailingTaskAfterMilliseconds(int milliseconds)
    {
        await Task.Delay(milliseconds);
        throw new Exception($"Hi there from the {milliseconds}ms task.");
    }

    public static async Task<int> CancelAfterMilliseconds(int milliseconds)
    {
        var cancellationToken = new CancellationTokenSource();
        cancellationToken.CancelAfter(milliseconds);
        await Task.Delay(milliseconds + 30, cancellationToken.Token);
        return 6789;
    }

    public static async Task<T> Delay100AndReturn<T>(T value)
    {
        await Task.Delay(100);
        return value;
    }
}
