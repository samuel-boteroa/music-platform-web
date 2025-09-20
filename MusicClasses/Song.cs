using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class Song
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        List<Artist> artists;

        public Song(string songName )
        {
            this.id = Guid.NewGuid();
            this.name = songName;
            this.artists = new List<Artist>();
        }

        public Artist addPerformer(Artist artist) {
            this.artists.Add( artist );
            return artist;
        }

        public bool deletePerformer(Artist artist) {
            bool removed = false;
            return artists.Remove(artist );
        }
    }
}
