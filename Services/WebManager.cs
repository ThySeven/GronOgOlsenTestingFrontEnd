using GronOgOlsenFrontEnd.Models;
using Microsoft.AspNetCore.Components;
using UserService.Models;

namespace GronOgOlsenFrontEnd.Services
{
    public class WebManager
    {
        [Inject]
        UserState UserState { get; set; }
        [Inject]
        LotState LotState { get; set; }

        private static WebManager _instance = new WebManager();
        public static WebManager GetInstance {  get { return _instance; } }
        private string _serverUrl = "https://api.gronogolsen.dk";
        public string ServerUrl
        {
            get => _serverUrl;
            set
            {
                if (_serverUrl != value)
                {
                    _serverUrl = value;
                    UserState.OnUserChanged();
                    LotState.OnLotChanged();
                }
            }
        }
        public HttpClient HttpClient;
        public string jwtToken = "";


        public WebManager()
        {
            HttpClient = new HttpClient();
        }
    }
}
