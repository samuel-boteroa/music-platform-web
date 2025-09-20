using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class Follower
    {
        public DateOnly followingSince { get; }
        public Artist artist { get; }
        public User user { get; }

        public Follower(User user, Artist artist)
        {
            this.user = user;
            this.artist = artist;
            this.followingSince = DateOnly.FromDateTime(DateTime.Today);
        }
    }
}
