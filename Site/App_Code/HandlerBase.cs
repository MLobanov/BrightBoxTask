
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Сводное описание для HandlerBase
/// </summary>
public abstract class HandlerBase : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "application/json";

        try
        {
            process(context);
        }
        catch(Exception ex)
        {
            Result result = new Result() { ErrorMessage = ex.Message };
            context.Response.Write(JsonConvert.SerializeObject(result));
        }
    }

    protected abstract void process(HttpContext context);

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}