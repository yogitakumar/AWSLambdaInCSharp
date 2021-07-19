using Xunit;
using Amazon.Lambda.TestUtilities;

namespace AWSLambdaEmployee.Tests
{
    public class FunctionTest
    {
        [Fact]
        public void TestEmployeeDataDisplayFunction()
        {

            // Invoke the lambda function and confirm Employee details
            var function = new Function();
            var context = new TestLambdaContext();

            Employee emp = new Employee
            {
                EmployeeId = 101,
                Name = "Yogita Kumar",
                Email = "abc@gmail.com",
                Post = "Software Developer",
                Salary = 50000
            };
            var result = function.FunctionHandler(emp, context);

            Assert.Equal($"Name: {emp.Name} Post: {emp.Post} Email: {emp.Email}", result);
        }
    }
}
