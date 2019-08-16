﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using uController;

namespace Sample
{
    public static class JsonExtensions
    {
        public static IServiceCollection AddNewtonsoftJson(this IServiceCollection services)
        {
            return services.AddSingleton<IHttpRequestReader, NewtonsoftJsonRequestReader>()
                           .AddSingleton<IHttpResponseWriter, NewtonsoftJsonResponseWriter>();
        }

        public static IServiceCollection AddJson(this IServiceCollection services)
        {
            return services.AddSingleton<IHttpRequestReader, JsonRequestReader>()
                           .AddSingleton<IHttpResponseWriter, JsonResponseWriter>();
        }
    }
}
