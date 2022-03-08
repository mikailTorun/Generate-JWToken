
namespace Generate_JWToken.JWT
{
    public class Login
    {
        private readonly Token token;
        public Login(Token token)
        {
            this.token = token;
        }
        public JwtInfo GetToken()
        {
            return token.Authenticate();
        }
    }
}
