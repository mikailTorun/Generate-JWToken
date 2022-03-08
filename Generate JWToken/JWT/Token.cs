
namespace Generate_JWToken.JWT
{
    public class Token
    {
        private readonly IJwtautenticaitonManager jwtautenticaitonManager;

        public Token(IJwtautenticaitonManager jwtautenticaitonManager)
        {
            this.jwtautenticaitonManager = jwtautenticaitonManager;
        }
        public JwtInfo Authenticate()
        {
            JwtInfo token = new()
            {
                MyToken = jwtautenticaitonManager.Authenticate()
            };
            return token;
        }
    }
}
