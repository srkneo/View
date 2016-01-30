using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace View1.Infrastructure
{
    public class DebugDataViewEngine : IViewEngine
    {
        public ViewEngineResult FindView(ControllerContext controllerContext, string ViewName, string masterName, bool useCache)
        {
            if(ViewName == "DebugData")
            {
                return new ViewEngineResult(new DebugDataView(), this);
            }
            else
            {
                return new ViewEngineResult(new string[] { "No view Debug " });
            }
        }

        public ViewEngineResult FindPartialView(ControllerContext controllerContext, string PartialViewName, bool useCache)
        {
            return new ViewEngineResult(new string[] { "No view Debug " });
        }

        public void ReleaseView (ControllerContext controllerContext, IView view)
        {
            //Do nothing
        }
    }
}