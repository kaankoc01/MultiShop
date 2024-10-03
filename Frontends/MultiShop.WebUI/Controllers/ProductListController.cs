using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
    public class ProductListController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ProductListController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index(string id)
        {
            ViewBag.i = id;
            return View();
        }
        public IActionResult ProductDetail(string id)
        {
            ViewBag.x = id;
            return View();
        }
        [HttpGet]
        public PartialViewResult AddComment(string id)
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> AddComment(CreateCommentDto createCommentDto)
        {

            createCommentDto.ImageUrl = "test";
            createCommentDto.Rating = 1;
            createCommentDto.CreatedDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            createCommentDto.Status = false;
            createCommentDto.ProductId = "66fae94038273ced03cd69ca";
            // HttpClientHandler ile SSL doğrulamasını atlıyoruz.
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
            var client = new HttpClient(clientHandler);
            var jsondata = JsonConvert.SerializeObject(createCommentDto); //eklerken serialize
            StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7000/api/Comments", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index" , "Default");
            }
            
            return View();
        }
    }

}
