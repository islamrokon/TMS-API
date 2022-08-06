using AutoMapper;
using BLL.Entity;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthServices
    {
        public static TokenModel Authenticate(string username, string password)
        {
            var data = DataAccess.AuthDataAccess().Authenticate(username, password);
            if (data != null)
            {
                TokenModel tokenModel = new TokenModel()
                {
                    id = data.id,
                    clientid = data.clientid,
                    tokenaccess = data.tokenaccess,
                    Createdat = data.Createdat,
                    Expireat = data.Expireat
                };
                return tokenModel;
            }
            return null;
        }
        public static bool CheckValidityToken(string token)
        {
            var authCheck = DataAccess.AuthDataAccess().IsAuthenticated(token);
            return authCheck;
        }
        public static bool Logout(int uid)
        {
            var logout = DataAccess.AuthDataAccess().Logout(uid);
            return logout;
        }
    }
}
