namespace BarberApp_Manager.Domain.Security
{
    internal interface ISecurityDomain
    {
        bool CheckPassword(string password, string hash);
        string Encrypt(string password);
    }
}
