using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filtros.Filters
{
    public class LoggingFilter : IActionFilter
    {
        private static string fileName = "Requisicoesinfo.log";

        private static string logFilePath;

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }


        private void SaveInfo(ControllerContext context)
        {
            string info = String.Format("Usuário:{0}, IP:{1}, Data/Hora:{2}, URL:{3}",
                context.HttpContext.User.Identity.Name,
                context.HttpContext.Request.UserHostAddress,
                DateTime.Now,
                context.HttpContext.Request.RawUrl);
            var path = GetLogFilePath(context);
            using (var logWrite = new StreamWriter(path, true))
            {
                logWrite.WriteLine(info);
            }
        }

        private static string GetLogFilePath(ControllerContext context)
        {
            if (LoggingFilter.logFilePath == null)
            {
                var logPath = context.HttpContext.Server.MapPath("~/Logs");
                if (!Directory.Exists(logPath))
                {
                    Directory.CreateDirectory(logPath);
                }
                var path = Path.Combine(logPath, fileName);
                LoggingFilter.logFilePath = path;
            }
            return LoggingFilter.logFilePath;
        }
    }
}