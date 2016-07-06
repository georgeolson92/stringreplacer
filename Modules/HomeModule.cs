using System.Collections.Generic;
using Nancy;
using System;
using StringReplacer.Objects;

namespace StringReplacer
{
  public class HomeModule: NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/result"] = _ => {
        Replacer replacer = new Replacer();
        string result = replacer.FindAndReplace(Request.Form["phrase"], Request.Form["search"], Request.Form["replacement"]);
        return View["/result.cshtml", result];
      };
    }
  }
}
