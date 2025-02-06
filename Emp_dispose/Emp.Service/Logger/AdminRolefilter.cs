using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Emp.Service.Logger
{
    public class AdminRolefilter
    {
       
            public void OnActionExecuting(ActionExecutingContext context)
            {
                var isAdmin = context.HttpContext.Request.Headers["Role"].ToString() == "Admin";
                if (!isAdmin)
                {
                    context.Result = new ForbidResult();
                }
            }

            public void OnActionExecuted(ActionExecutedContext context) { }
        

    }
}
