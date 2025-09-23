using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses.Interfaces
{
    public interface IUserDataService
    {
        public User validateUserInformation(string username, string password);

        public void RegisterUser(User newUser);

        
       
    }
}
