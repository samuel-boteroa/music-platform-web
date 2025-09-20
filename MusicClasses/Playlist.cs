using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicClasses
{
    public class Playlist
    {
        public Guid id {get;}
        public string name { get; set; }
        public DateOnly DateCreated { get; }
        List<PlaylistItem> items;


        public Playlist(string playlistName) { 
        
            this.id = Guid.NewGuid();   
            this.DateCreated = new DateOnly();
            this.name = playlistName;
            this.items = new List<PlaylistItem>();
        }

                

        public PlaylistItem addItem(Song song) {
            PlaylistItem newItem = new PlaylistItem(song);
            items.Add(newItem);
            
            return newItem;
        }

        public List<PlaylistItem> getItems() {
            return this.items;
        
        }

        public int getItemNumber()
        {
            return this.items.Count;
        }


        public bool deleteItem(int position) {
            bool deleted = false;
            if (this.items.Count > position)
            {
                this.items.RemoveAt(position);
                deleted = true;
            }
            return deleted;
        
        }

    }
}
