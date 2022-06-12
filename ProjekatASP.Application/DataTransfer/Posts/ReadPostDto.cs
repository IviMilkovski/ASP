using ProjekatASP.Application.DataTransfer.Categories;
using ProjekatASP.Application.DataTransfer.Users;
using ProjekatASP.Application.DataTransfer.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Posts
{
    public class ReadPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CategoryName { get; set; }
        public string Username { get; set; }

        public IEnumerable<string> Comments { get; set; } = new List<string>();
    }
}
