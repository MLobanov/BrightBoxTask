<%@ WebHandler Language="C#" Class="GetStatus" %>

using Newtonsoft.Json;

using System;
using System.Configuration;
using System.Web;

public class GetStatus  : HandlerBase {

    protected override void process(HttpContext context)
    {
        context.Response.ContentType = "application/json";

        string statusJSON = ConfigurationManager.AppSettings["StatusJSON"];

        context.Response.Write(statusJSON);
    }
        
}