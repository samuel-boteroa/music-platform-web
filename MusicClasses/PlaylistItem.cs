using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class PlaylistItem
    {
        public DateOnly dateAdded { get; }
        public Song song {get;set;}
        public int timesListened {get; set;}

        public PlaylistItem(Song song)
        {
            this.dateAdded = DateOnly.FromDateTime(DateTime.Today);
            this.song = song;
            this.timesListened = 0;
        }


    }
}
