using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Domain
{
    public class PostComment 
    {
        public int PostId { get; set; }
        public int CommentId { get; set; }
        public virtual Post Post { get; set; }
        public virtual Comment Comment { get; set; }

    }
}
