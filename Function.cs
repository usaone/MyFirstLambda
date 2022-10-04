using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyFirstLambda;

public class Function
{

    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public string FunctionHandler(MyData data, ILambdaContext context)
    {
        return $"Hello {data.Name}".ToUpper();
    }

    public string FunctionHandler2(ILambdaContext context)
    {
        return $"Triggered from CloudWatch Rule";
    }
}

public class MyData
{
    public string Name { get; set; }
}