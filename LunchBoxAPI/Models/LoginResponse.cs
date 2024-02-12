namespace LunchBox.API.Models
{
    public class LoginResponse
    {
        public string Token { get; set; }
        public string Username { get; set; } = string.Empty;
    }
}
