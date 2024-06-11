namespace SchoolFinder.Domain.Common.ValueObjects
{
    public class ContatoEscola
    {
        public string? Telefone { get; private set; }
        public string? Celular { get; private set; }
        public string? Email { get; private set; }
        public string? SiteUrl { get; private set; }
        public string? FacebookUrl { get; private set; }
        public string? InstagramUrl { get; private set; }
        public string? LinkedinUrl { get; private set; }
        public string? TikTokUrl { get; private set; }

        public ContatoEscola()
        {            
        }

        public ContatoEscola(string? telefone, string? celular, string? email, string? siteUrl, string? facebookUrl, string? instagramUrl, string? linkedinUrl, string? tikTokUrl)
        {
            Telefone = telefone;
            Celular = celular;
            Email = email;
            SiteUrl = siteUrl;
            FacebookUrl = facebookUrl;
            InstagramUrl = instagramUrl;
            LinkedinUrl = linkedinUrl;
            TikTokUrl = tikTokUrl;

            Validate();
        }

        // TODO: Implementar...
        private void Validate()
        {

        }
    }
}
