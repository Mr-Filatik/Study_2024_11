using Swashbuckle.AspNetCore.Filters;

namespace Applications.Web.ApiApp.Models
{
    public class LoginRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequestExample : IMultipleExamplesProvider<LoginRequest>
    {
        public IEnumerable<SwaggerExample<LoginRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Vlad", new LoginRequest()
            {
                Login = "Vlad",
                Password = "password"
            });

            yield return SwaggerExample.Create("Not Vlad", new LoginRequest()
            {
                Login = "Viktor",
                Password = "password"
            });
        }
    }
}
