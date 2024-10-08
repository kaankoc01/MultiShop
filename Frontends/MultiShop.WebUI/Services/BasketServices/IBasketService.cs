using MultiShop.DtoLayer.BasketDtos;

namespace MultiShop.WebUI.Services.BasketServices
{
    public interface IBasketService
    {
        Task<BasketTotalDto> GetBasket(); // sepetin tümünü getiriyor
        Task SaveBasket(BasketTotalDto basketTotalDto); // sepetin tümünü kaydediyor.
        Task DeleteBasket(string userId); //sepetin tamamını siliyor
        Task AddBasketItem(BasketItemDto basketItemDto); //sepetin içine yeni bir öğe 
        Task<bool> RemoveBasketItem(string productId); // sepetten bir öğe silmeye yarıyor.


    }
}
