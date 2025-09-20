using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class Artist
    {
        public Guid id { get; }
        public string name { get; set; }
        List<Follower> followers;
        List<Song> songs;

        public Artist(string artistName)
        {
            this.id = Guid.NewGuid();
            this.name = artistName;
            this.followers = new List<Follower>();
            this.songs=new List<Song>();
        }

        public Song addSong(Song song) {
            this.songs.Add(song);
            return song;

        }

        public bool removeSong(Song song) {
            bool deleted = false;
            return deleted = this.songs.Remove(song);
        }

        public Follower addFollower(Follower follower) {
            this.followers.Add(follower);
            return follower;
        }
        
        public bool deleteFollower(Follower follower) {
            bool deleted = false;
            return deleted = this.followers.Remove(follower);
        }

    }
}
