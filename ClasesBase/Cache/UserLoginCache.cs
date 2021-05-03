using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase.Cache
{
    public static class UserLoginCache
    {
        private static Usuario usuarioLogin = new Usuario();

        public static Usuario UsuarioLogin
        {
            get { return UserLoginCache.usuarioLogin; }
            set { UserLoginCache.usuarioLogin = value; }
        }



    }
}
