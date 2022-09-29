using Microsoft.AspNetCore.Mvc;
using OnlineCourse.Shared.Dtos;

namespace OnlineCourse.Shared.BaseClasses
{
    public class CustomControllerBase : ControllerBase
    {
        public IActionResult CreateActionResultInstance<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
