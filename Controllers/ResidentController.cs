﻿using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using multilang.Middlewares;
using multilang.Models;

namespace multilang.Controllers
{
    [MiddlewareFilter(typeof(CultureMiddleware))]
    public class ResidentController : Controller
    {
        private readonly IStringLocalizer _localizer;
        //private readonly IStringLocalizer _sharedLocalizer;

        public ResidentController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
            // _sharedLocalizer = sharedLocalizer;
        }

        public IActionResult Index()
        {
            return View();
        }

        public string Content()
        {
            return $"CurrentCulture: {CultureInfo.CurrentCulture.Name}\r\n"
                 + $"CurrentUICulture: {CultureInfo.CurrentUICulture.Name}\r\n"
                 + $"Resources\\Controllers\\HomeController: {_localizer["Hello"]}\r\n";
                //  + $"Resources\\SharedResource: {_sharedLocalizer["Hello"]}";
        }
    }
}