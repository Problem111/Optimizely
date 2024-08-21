    using hemsida1.Models.Pages;
    using EPiServer.Web.Mvc;
    using Microsoft.AspNetCore.Mvc;

    namespace hemsida.Models.Pages
    {
        public class Homepagecontroller : PageController<Homepage>
        {
            public IActionResult Index(Homepage currentContent)
            {
                return View(currentContent);
            }
        }
    }
