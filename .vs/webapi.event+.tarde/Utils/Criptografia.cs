namespace webapi.event_.tarde.Utils
{
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash a partir da senha
        /// </summary>
        /// <param name="senha">Senha que recebrá a hash</param>
        /// <returns></returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica se a hash da senha informada é igual à hash salva no bd
        /// </summary>
        /// <param name="senhaForm">Senha passada no form de login</param>
        /// <param name="senhaBanco">Senha cadastrada no banco</param>
        /// <returns>True ou False</returns>
        public static bool CompararHash(string senhaForm, string senhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, senhaBanco);
        }
    }
}

