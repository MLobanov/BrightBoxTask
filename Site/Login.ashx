<%@ WebHandler Language="C#" Class="Login" %>

using Newtonsoft.Json;

using System;
using System.Web;
using System.Web.Security;

public class Login  : HandlerBase {

    protected override void process(HttpContext context)
    {
        Result result;
        if (FormsAuthentication.Authenticate(context.Request["Login"], context.Request["Password"]))
        {
            FormsAuthentication.SetAuthCookie(context.Request["Login"], true);
            result = new Result { Data = "OK" };
        }
        else
        {
            result = new Result { NeedAuth = true };
        }
        context.Response.ContentType = "application/json";
        context.Response.Write(JsonConvert.SerializeObject(result));
    }

}