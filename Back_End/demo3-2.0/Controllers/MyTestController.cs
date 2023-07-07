using Microsoft.AspNetCore.Mvc;

namespace MyWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> GetBasic()
        {
            //这里可以处理数据
            return "Hello, World!VUE!!!";
        }
        /* ActionResult 是 ASP.NET Core MVC 中的一个基类，它表示控制器方法的返回值。
         * 控制器方法可以返回不同类型的 ActionResult 对象，例如 ViewResult、JsonResult、RedirectResult 等，
         * 这些对象表示不同的响应结果。在控制器方法中，你可以通过返回不同的 ActionResult 对象来控制响应的内容、格式和状态码。
         * 
         * 在上面的代码中，ActionResult<string> 表示控制器方法返回一个字符串类型的响应结果。
         * 在这个方法中，我们直接返回了一个字符串 "Hello, World!VUE!!!"。在返回结果时，
         * ASP.NET Core MVC 会自动将这个字符串封装到一个 ContentResult 对象中，并将其作为 HTTP 响应返回给客户端。
         * ContentResult 是 ActionResult 的一个子类，它表示返回的内容是一个字符串或字节数组。 
         
         ps:这个返回类型控制还用很多，可以gpt问一下，这不是必须的，我们一般用string等基础类型也是可以的*/

        [HttpGet("GetParams")] //进一步的路由:api/HelloWorld/GetParams
        public string GetParams(int num, string str)//前端带参传入，注意数据类型、变量名和顺序的对应
        {
            //这里可以处理数据
            return num.ToString() + str;
        }

        //下面将几个基础的请求全部写一个demo
        /*HTTP 协议定义了多种请求类型（也称为方法或动作），常见的请求类型包括：
         * 
         * GET：用于获取资源，不会修改服务器上的数据。
         * POST：用于向服务器提交数据，可能会修改服务器上的数据。
         * PUT：用于更新服务器上的数据。
         * DELETE：用于删除服务器上的数据。
         * HEAD：类似于 GET 请求，但只返回响应头部，不返回实体内容。
         * OPTIONS：用于获取服务器支持的请求类型、跨域访问等信息。*/

        [HttpPost("PostParams")] //进一步的路由:api/HelloWorld/GetParams
        public int PostParams(int num1, int num2)//前端带参传入，注意数据类型、变量名和顺序的对应
        {
            //这里可以处理数据
            return num1 + num2;
        }

        [HttpDelete("Delete")]
        public double Delete() 
        {
            //处理数据
            return 3.1415926535;
        }

        [HttpPut("Put")]
        public string Put()
        {
            return "HttpPut的测试";
        }

        /*解释下面的两种请求，对于不是处理数据的请求，可能会有不同的操作，更具体的请查阅资料：
         * 
         * IActionResult 是 ASP.NET Core MVC 中的一个接口，它定义了控制器方法的返回类型。
         * 使用 IActionResult 接口作为返回类型，可以让你更加灵活地控制控制器方法的响应结果，
         * 例如返回不同类型的视图、文件、JSON 数据等。IActionResult 接口定义了以下几个方法：
         * ExecuteResultAsync(ActionContext)：执行控制器方法并返回结果。FindAsync(ActionContext)：查找控制器方法的结果（异步）。
         * GetActionResult()：获取控制器方法的结果。
         * 在 ASP.NET Core MVC 中，控制器方法可以返回实现了 IActionResult 接口的对象，
         * 例如 ViewResult、JsonResult、FileResult 等。这些对象实现了 IActionResult 接口，
         * 并提供了不同的响应结果，例如返回视图、返回 JSON 数据、返回文件等。在控制器方法中，
         * 你可以根据具体的业务需求，选择合适的 IActionResult 对象作为响应结果。
         * 
         * 下面的 OK 是内置方法
         * 在 Head() 方法中，我们返回响应头部信息，并使用 Ok() 方法返回成功状态码 200。
         * 在 Options() 方法中，我们返回支持的请求类型和跨域访问等信息，并使用 Ok() 方法返回成功状态码 200。
         */

        [HttpHead("Head")]
        public IActionResult Head()
        {
            // 返回响应头部信息，不返回实体内容
            Response.Headers.Add("X-Test-Header", "Test");
            return Ok();
        }

        [HttpOptions("Options")]
        public IActionResult Options()
        {
            // 返回支持的请求类型、跨域访问等信息，不返回实体内容
            Response.Headers.Add("Allow", "GET, POST, PUT, DELETE");
            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok();
        }
    }
}