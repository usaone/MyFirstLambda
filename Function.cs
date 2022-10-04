using Amazon.Lambda.Core;
using Newtonsoft.Json;

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

    public string FunctionHandler2(object o, ILambdaContext context)
    {
        LambdaLogger.Log($"FunctionHandler2 begins\n");
        LambdaLogger.Log("CONTEXT: " + JsonConvert.SerializeObject(context));
        LambdaLogger.Log($"Retuning");
        return $"Triggered from CloudWatch Rule";
    }
}

public class MyData
{
    public string Name { get; set; }
}