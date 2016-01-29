using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace View1.Infrastructure
{
    public class DebugDataView : IView
    {
        public void Render(ViewContext viewContext, TextWriter writter)
        {
            Write(writter, "--Routing Data--");

            foreach (string key in viewContext.RouteData.Values.Keys)
            {
                Write(writter, "Key: {0}, Value: {1}", key, viewContext.RouteData.Values[key]);
            }

            Write(writter, "---View Data---");

            foreach (string key in viewContext.ViewData.Keys)
            {
                Write(writter, "Key: {0}, Value: {1}", key, viewContext.ViewData[key]);
            }
        }

        private void Write(TextWriter writer, string template, params object[] values)
        {
            writer.Write(string.Format(template, values) + "<p/>");
        }
    }
}