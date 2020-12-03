using DI_Test_ASP.Services;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_Test_ASP.Middleware
{
    public class TimerMiddleware
    {
        private readonly RequestDelegate _next;
        MyTimeService _timeService;

        public TimerMiddleware(RequestDelegate requestDelegate, MyTimeService timeService)
        {
            _next = requestDelegate;
            _timeService = timeService;
        }

        public async Task InvokeAsync(HttpContext context) {
            if (context.Request.Path.Value.ToLower() == "/timer")
            {
                context.Response.ContentType = "text/html; charset=utf-8";
                await context.Response.WriteAsync($"Current time: {_timeService?.Time}");
            }
            else {
                await _next.Invoke(context);
            }
        }
    }
}
