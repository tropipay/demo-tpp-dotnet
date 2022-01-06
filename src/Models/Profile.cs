namespace deno_tpp_dotnet.Models
{
    public class Profile
    {
        public string? name { get; set; }
        public string? surname { get; set; }
        public string? email { get; set; }
        public string? phone { get; set; }
        public string? address { get; set; }
        public string? province { get; set; }
        public DateTime? lastLogin { get; set; }
        public DateTime? documentExpirationDate { get; set; }
        public float balance { get; set; }
    }
};

