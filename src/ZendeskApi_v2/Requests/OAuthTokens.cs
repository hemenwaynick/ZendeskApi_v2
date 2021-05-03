using ZendeskApi_v2.Models.OAuthTokens;

namespace ZendeskApi_v2.Requests
{
    public interface IOAuthTokens
    {
        OAuthTokenResponse CreateTokenForPasswordGrantType(OAuthTokenPasswordGrantTypeRequest request);
    }

    public class OAuthTokens : Core, IOAuthTokens
    {
        public OAuthTokens(string yourZendeskUrl, string user, string password, string apiToken, string p_OAuthToken)
            : base(yourZendeskUrl, user, password, apiToken, p_OAuthToken)
        {
        }

        public OAuthTokenResponse CreateTokenForPasswordGrantType(OAuthTokenPasswordGrantTypeRequest request)
        {
            return GenericPost<OAuthTokenResponse>("/oauth/tokens", new { grant_type = request.GrantType, client_id = request.ClientId, client_secret = request.ClientSecret, scope = request.Scope, username = request.Username, password = request.Password, token = request.Token });
        }
    }
}
