using BarberApp_Manager.Aux;

namespace BarberApp_Manager.Domain.Security
{
    internal class SecurityDomain : ISecurityDomain
    {
        public bool CheckPassword(string password, string hash)
        {
            return CriptografiaUtil.CheckPassword(password, hash);
        }

        public string Encrypt(string password)
        {
            return CriptografiaUtil.EncryptPassword(password);
        }
    }
}
