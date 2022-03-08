using Generate_JWToken.JWT;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Generate_JWToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenerateJWTController : ControllerBase
    {
        private readonly Login login;

        public GenerateJWTController( Login login)
        {
            this.login = login;
        }
        [HttpGet]
        public JwtInfo Get()
        {
            return FillJwt(200, "", login.GetToken().MyToken);
        }

        private static JwtInfo FillJwt(int errorCode, string error, string token)
        {
            JwtInfo jwt = new();
            jwt.MyToken = token;
            jwt.Error = error;
            jwt.Code = errorCode;
            return jwt;
        }
    }
}
