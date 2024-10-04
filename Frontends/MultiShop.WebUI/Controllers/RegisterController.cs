using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.IdentityDtos.RegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace MultiShop.WebUI.Controllers
{
	public class RegisterController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public RegisterController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Index(CreateRegisterDto createRegisterDto)
		{
			if (createRegisterDto.Password == createRegisterDto.ConfirmPassword)
			{
				// HttpClientHandler ile SSL doğrulamasını atlıyoruz.
				var clientHandler = new HttpClientHandler();
				clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

				// IHttpClientFactory kullanarak client'ı oluşturuyoruz ve custom handler ekliyoruz.
				var client = new HttpClient(clientHandler);
				var jsondata = JsonConvert.SerializeObject(createRegisterDto); //eklerken serialize
				StringContent stringContent = new StringContent(jsondata, Encoding.UTF8, "application/json");
				var responseMessage = await client.PostAsync("http://localhost:5001/api/Registers", stringContent);
				if (responseMessage.IsSuccessStatusCode)
				{
					return RedirectToAction("Index", "Login");
				}
			}

			return View();
		}
	}
}