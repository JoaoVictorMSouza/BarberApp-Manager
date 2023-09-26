namespace BarberApp_Manager.Aux
{
    public static class CriptografiaUtil
    {
        public static bool CheckPassword(string password, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(password, hash);
        }

        public static string EncryptPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}