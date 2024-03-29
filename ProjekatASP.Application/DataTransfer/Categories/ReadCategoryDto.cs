﻿using ProjekatASP.Application.DataTransfer.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatASP.Application.DataTransfer.Categories
{
    public class ReadCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<PostsOfCategoryDto> Posts { get; set; } = new List<PostsOfCategoryDto>();

    }
}
