﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using uController;

namespace Sample
{
    public class MyController : Controller
    {
        //[HttpGet("/")]
        //public Task Get(HttpContext context)
        //{
        //    return context.Response.WriteAsync("Hello World");
        //}

        [HttpGet("/")]
        public Result Index([FromQuery]string name)
        {
            return Ok($"Hello {name}");
        }

        public static Task ExecuteIndex(HttpContext context) => null;

        //[HttpGet("/blah")]
        //public object Blah()
        //{
        //    return new { name = "David Fowler" };
        //}

        //[HttpGet("/status/{status}")]
        //public Result StatusCode([FromRoute]int status)
        //{
        //    return Status(status);
        //}

        //[HttpGet("/slow/status/{status}")]
        //public async Task<Result> SlowTaskStatusCode()
        //{
        //    await Task.Delay(1000);

        //    return StatusCode(400);
        //}

        //[HttpGet("/fast/status/{status}")]
        //public ValueTask<Result> FastValueTaskStatusCode([FromServices]ILoggerFactory loggerFactory)
        //{
        //    return new ValueTask<Result>(Status(201));
        //}

        //[HttpGet("/lag")]
        //public async Task DoAsync(HttpContext context, [FromQuery]string q)
        //{
        //    await Task.Delay(100);

        //    await context.Response.WriteAsync(q);
        //}

        //[HttpGet("/hey/david")]
        //public string HelloDavid() => "Hello David!";

        //[HttpGet("/hey/{name?}")]
        //public async Task<string> GetAsync([FromRoute]string name)
        //{
        //    await Task.Delay(500);

        //    return $"Hey {name ?? "David"}!";
        //}

        //[HttpGet("/hello")]
        //public string Hello() => "Hello!";

        //[HttpPost("/")]
        //public Result Post([FromBody]JsonDocument obj)
        //{
        //    return Ok(obj);
        //}

        //[HttpPost("/post-form")]
        //public void PostAForm(IFormCollection form)
        //{

        //}

        //[HttpGet("/auth")]
        //[Authorize]
        //public void Authed()
        //{

        //}
    }
}