<%@ WebHandler Language="C#" Class="SetStatus" %>

using Newtonsoft.Json;

using System;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Configuration;

public class SetStatus : HandlerBase {

    protected override void process(HttpContext context)
    {
        if (context.User == null || context.User.Identity == null || String.IsNullOrEmpty(context.User.Identity.Name))
        {
            context.Response.Write(JsonConvert.SerializeObject(new Result() { NeedAuth = true }));
            return;
        }
        Configuration config = WebConfigurationManager.OpenWebConfiguration("/");
        Dictionary<string, string> data = new Dictionary<string, string>();
        data.Add("statusCode", context.Request["statusCode"]);
        data.Add("date", context.Request["date"]);
        Result result = new Result() { Data = data };
        string json = JsonConvert.SerializeObject(result);
        config.AppSettings.Settings["StatusJSON"].Value = json;
        config.Save(ConfigurationSaveMode.Modified);
        context.Response.Write(json);
    }

}