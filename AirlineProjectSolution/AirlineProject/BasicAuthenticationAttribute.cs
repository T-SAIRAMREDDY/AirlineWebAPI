using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using AirlineProject.Controllers;

namespace AirlineProject
{
    public class BasicAuthenticationAttribute: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if(actionContext.Request.Headers.Authorization ==null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                //base 64 decoded from server to client //
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                //string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
               string[] usernamePasswordArray= authenticationToken.Split(':');
                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];

                if (username.Equals("admin", StringComparison.OrdinalIgnoreCase) && password.Equals("adminpass"))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }

            }
        }
    }
}