using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CommentDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/Comment")]
    public class CommentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CommentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Yorumlar";
            ViewBag.v3 = "Yorum Listesi";
            ViewBag.v0 = "Yorum İşlemleri";

            // HttpClientHandler ile SSL doğrulamasını atlıyoruz.
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
            var client = new HttpClient(clientHandler);

            var responseMessage = await client.GetAsync("https://localhost:7000/api/Comments");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCommentDto>>(jsonData); // listelerken deserialize
                return View(values);
            }

            return View();
        }
        
        [Route("DeleteComment/{id}")]

        public async Task<IActionResult> DeleteComment(string id)
        {
            // HttpClientHandler ile SSL doğrulamasını atlıyoruz.
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
            var client = new HttpClient(clientHandler);
            var responseMessage = await client.DeleteAsync("https://localhost:7000/api/Comments?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Comment", new { area = "Admin" });
            }
            return View();
        }
        [Route("UpdateComment/{id}")]
        [HttpGet]
        public async Task<IActionResult> UpdateComment(string id)
        {
            ViewBag.v1 = "Ana Sayfa";
            ViewBag.v2 = "Yorumlar";
            ViewBag.v3 = "Yorum Listesi";
            ViewBag.v0 = "Yorum İşlemleri";
            // HttpClientHandler ile SSL doğrulamasını atlıyoruz.
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
            var client = new HttpClient(clientHandler);
            var responseMessage = await client.GetAsync("https://localhost:7000/api/Comments/" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateCommentDto>(jsonData);
                return View(values);

            }
            return View();
        }
        [Route("UpdateComment/{id}")]
        [HttpPost]
        public async Task<IActionResult> UpdateComment(UpdateCommentDto updateCommentDto)
        {
            updateCommentDto.Status = true;
            // HttpClientHandler ile SSL doğrulamasını atlıyoruz.
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            // IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
            var client = new HttpClient(clientHandler);
            var jsonData = JsonConvert.SerializeObject(updateCommentDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7000/api/Comments/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {

                return RedirectToAction("Index", "Comment", new { area = "Admin" });

            }
            return View();
        }
    }
}
