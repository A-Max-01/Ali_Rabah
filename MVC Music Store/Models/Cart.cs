using System.ComponentModel.DataAnnotations;
using MVC_Music_Store.Models;
namespace MvcMusicStore.Models
{
    public class Cart
    {
        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int AlbumId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Album Album { get; set; }
    }
}