using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.AboutDtos;
using MultiShop.WebUI.Services.CatalogServices.AboutServices;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text.Json.Nodes;

namespace MultiShop.WebUI.ViewComponents.UILayoutViewComponents
{
    public class __FooterUILayoutComponentPartial : ViewComponent
    {
        private readonly IAboutService aboutService;
        public __FooterUILayoutComponentPartial(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await aboutService.GetAllAboutAsync();
            return View(values);
        }
    }
}
