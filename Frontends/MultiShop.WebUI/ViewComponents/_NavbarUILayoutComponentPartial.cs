using Microsoft.AspNetCore.Mvc;

namespace MultiShop.WebUI.ViewComponents
{
    public class _NavbarUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
