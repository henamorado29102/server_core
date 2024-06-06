using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace core.Filter
{
    public class SimpleAsyncActionFilter : IAsyncActionFilter
    {
        private readonly ILogger<SampleActionFilter> _logger;

        public SimpleAsyncActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SampleActionFilter>();
        }
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            _logger.LogInformation("[AsyncFilter - BEFORE]");
            await next();
            _logger.LogInformation("[AsyncFilter - AFTER]");
        }


    }
}