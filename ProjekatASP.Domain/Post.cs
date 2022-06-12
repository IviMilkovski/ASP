using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Domain
{
    public class Post : Entity
    {
        
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }


        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<PostComment> PostComments { get; set; } = new List<PostComment>();
        public virtual ICollection<Like> PostLikes { get; set; } = new List<Like>();
    }
}
