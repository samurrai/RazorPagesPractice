using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstagramCloneApp.Models
{
    public class Post
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public User User { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
        public List<Commentary> Commentary { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
    }
}
