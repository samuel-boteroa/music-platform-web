using MusicClasses;
using MusicClasses.Interfaces;

namespace MusicPlatform.Services
{
    public class UserDataService: IUserDataService
    {
        private Dictionary<string, User> testUserList;
        private readonly Guid dummyId = new Guid("11223344-5566-7788-99aa-bbccddeeff00");

        private User? currentUser;
        public UserDataService()
        { 
            this.testUserList = new();
            this.testUserList.Add("JohnnyBravo", new User(this.dummyId, "Johnny Bravo", "bravo@gmail.com", "contraseña"));


        }

        public User validateUserInformation(string username, string password) 
        {
            if (testUserList.TryGetValue(username, out User userFound))
            {
                if (!userFound.password.Equals(password))
                {
                    throw new Exception("Invalid Password");
                }
                else
                {
                    return userFound;
                }
            }
            else
            {
                throw new Exception("User does not exist or invalid username");
            }
            
        }




        public void RegisterUser(User newUser)
        {
            this.testUserList.Add(newUser.username,newUser);
        }
        public User? GetCurrentUser() => currentUser;

        public void SetCurrentUser(User user) => currentUser = user;

    


    }
}