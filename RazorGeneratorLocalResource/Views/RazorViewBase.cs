using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RazorGeneratorLocalResource.Views
{
    public abstract class RazorViewBase<T> : System.Web.Mvc.WebViewPage<T> where T : class
    {
        public string LocalResource(string resourceName)
        {
            return ViewContext.HttpContext.GetLocalResourceObject(VirtualPath, resourceName) as string;
        }



    }
}