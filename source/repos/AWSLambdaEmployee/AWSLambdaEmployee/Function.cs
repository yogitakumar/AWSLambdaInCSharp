using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambdaEmployee
{
    public class Function
    {
        
        /// <summary>
        /// A simple function that takes Employee data and display
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public string FunctionHandler(Employee input, ILambdaContext context)
        {
            return $"Name: {input.Name} Post: {input.Post} Email: {input.Email}";
        }
    }
}
