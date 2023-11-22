using EasyAuthSamples.Common.Middlewares;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    public static  class BuilderExtensions
    {
        public static IApplicationBuilder UseEasyAuth(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<EasyAuthMiddleware>();
        }
    }
}
