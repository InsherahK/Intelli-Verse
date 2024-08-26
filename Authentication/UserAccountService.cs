using ModelLayer;
using UserInterface.Authentication;
using System.Threading.Tasks;
namespace UserInterface.Authentication
{
    public class UserAccountService
    {

        public async Task<ModelMI> GetByUserName(String username, string userpass)
        {
            ModelMI ua = new ModelMI();
            ua = await DataAccessLayer.DALUserAuth.Authenticate(username, userpass);

            return ua;
        }
    }

}

/*
using ModelLayer;
using System.Threading.Tasks;

namespace UserInterface.Authentication
{
    public class UserAccountService
    {
        public async Task<ModelMI> GetByUserName(string username, string userpass)
        {
            ModelMI ua = new ModelMI();
            ua = await DataAccessLayer.DALUserAuth.Authenticate(username, userpass);
            return ua;
        }

        public async Task<string> GetUserIdByUsername(string username)
        {
            // Implement the logic to retrieve the user's ID based on the username
            // For demonstration purposes, you can return a known user ID
            if (username == "Maham")
            {
                return "100"; // Replace with the actual user ID
            }
            else if (username == "Rijja")
            {
                return "101"; // Replace with the actual user ID
            }
            else
            {
                return null; // Handle the case where the username is not found
            }
        }
    }
}*/
