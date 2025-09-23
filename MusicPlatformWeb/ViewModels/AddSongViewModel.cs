using System.ComponentModel.DataAnnotations;
namespace MusicPlatformWeb.ViewModels
{
    public class AddSongViewModel
    {
        [Required]
        public string name { get; set; }
    }
}
