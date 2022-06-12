using ProjekatASP.Application.DataTransfer.Categories;
using ProjekatASP.Application.DataTransfer.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Posts
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
     //   public IFormFile Image { get; set; }
        public int? CategoryId { get; set; }
        public int? UserId { get; set; }
    }
}
