using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Filters;

namespace core.Filter
{
    public class SampleActionFilter: ActionFilterAttribute
    {
        private readonly ILogger<SampleActionFilter> _logger;

        public SampleActionFilter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<SampleActionFilter>();
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            _logger.LogInformation("[SampleFilter - BEFORE]");
        }

         public override void OnActionExecuted(ActionExecutedContext context)
        {
            _logger.LogInformation("[SampleFilter - AFTER]");
        }
    }
}