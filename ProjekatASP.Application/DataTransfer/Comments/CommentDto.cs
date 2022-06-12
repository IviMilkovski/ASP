using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Comments
{
    public class CommentDto
    {
        public string Text { get; set; }
        public int? UserId { get; set; }
        public int? PostId { get; set; }
    }
}
