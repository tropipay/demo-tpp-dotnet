namespace deno_tpp_dotnet.Models
{
    public class TokenResponse
    {
        public string? access_token { get; set; }
        public string? refresh_token { get; set; }
        public string? scope { get; set; }
        public int? expires_in { get; set; }
    }
}