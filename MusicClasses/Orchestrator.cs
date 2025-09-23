using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using MusicClasses.Interfaces;
namespace MusicClasses
{
    public class Orchestrator
    {
        User currentUser;
        private readonly IMusicDataService _musicDataService;
        private readonly IUserDataService _userDataService;
        public string getVersion()
        {
            return "v1";
        }

        public Orchestrator(IUserDataService userDataService, IMusicDataService musicDataService)
        {

            this._userDataService = userDataService;

            this._musicDataService = musicDataService;

        }


        public List<Playlist> getPlaylists(User user)
        {
            return _musicDataService.getUserPlaylists(user);
        }


        public string validateUserInformation(string userName, string password)
        {
            string informationValidity = "invalid";

            User currentUser = _userDataService.validateUserInformation(userName, password);
            this.currentUser = currentUser;
            return informationValidity;
        }



        public void registerUser(User newUser)
        {
            this._userDataService.RegisterUser(newUser);
            // Do not auto-login on registration
        }


        public void setCurrentUser(User currentUser)
        {
            this.currentUser = currentUser;
        }

        public User getCurrentUser()
        {
            return this.currentUser;

        }

        public void addNewPlaylist(Playlist newPlaylist)
        {
            _musicDataService.addNewPlaylist(currentUser.id, newPlaylist);
        }

        public void DeletePlaylist(Playlist playlist)
        {
            
            if (currentUser != null)
            {
                _musicDataService.deletePlaylist(currentUser.id, playlist);
            }
        }
    }
}