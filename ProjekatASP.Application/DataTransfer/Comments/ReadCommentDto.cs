using ProjekatASP.Application.DataTransfer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Comments
{
    public class ReadCommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public UserDto User { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
