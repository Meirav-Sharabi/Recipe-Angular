namespace RecipesApi.Entities
{
    public class UserLogin
    {
        public string nameUser { get; set; }
        public string passwordUser { get; set; }
        public UserLogin()
        {

        }
        public UserLogin(string u, string p)
        {
            nameUser = u;
            passwordUser = p;
        }
    }
}
