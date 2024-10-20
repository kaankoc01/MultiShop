using Microsoft.AspNetCore.SignalR;
using MultiShop.SignalRRealTimeApi.Services;

namespace MultiShop.SignalRRealTimeApi.Hubs
{
    public class SignalRHub :Hub
    {
        private readonly ISignalRService _signalRService;

        public SignalRHub(ISignalRService signalRService)
        {
            _signalRService = signalRService;
        }
    }
}
