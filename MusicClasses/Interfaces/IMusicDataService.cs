using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses.Interfaces
{
    public interface IMusicDataService
    {
        public List<Playlist>? getUserPlaylists(User user);


    }
}
