namespace Library.Service
{
    public interface ILoginService
    {
        bool AuthenticateUser(string username, string password);
    }
}