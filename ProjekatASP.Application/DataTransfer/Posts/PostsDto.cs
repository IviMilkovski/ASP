using ProjekatASP.Application.DataTransfer.Categories;
using ProjekatASP.Application.DataTransfer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Posts
{
    public class PostsDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CategoryName { get; set; }
        public string Username { get; set; }
    }
}
