using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net60, baseline:true)]
[SimpleJob(RuntimeMoniker.Net70)]

//dotnet run -c Release -f net6.0 --runtimes net6.0 net7.0

public class TestBenchmark
{
    private readonly PassValue _objetctPassValue = new();
    private readonly PassRef _objetctPassref = new();

    [Benchmark]
    public void CallValue()
    {
        _objetctPassValue.SomeMethod();
    }

    [Benchmark]
    public void CallRef()
    {
        _objetctPassref.SomeMethod();
    }
}