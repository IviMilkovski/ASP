using ProjekatASP.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ProjekatASP.Domain;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjekatASP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
         [HttpPost]
        public IActionResult Post()
        {
            var categories = new List<Category>()
            {
                new Category {Name = "Nature"},
                new Category {Name = "Tehnology"},
                new Category {Name = "Discusions"},
                new Category {Name = "Travel"},
                new Category {Name = "Food and Drinks"},
                new Category {Name = "Study"},
                new Category {Name = "Animals"}
                
            };

            var users = new List<User>()
            {
                new User {FirstName = "Mika", LastName="Mikic", Email="mikamikic@gmail.com", Password="c0e6ed4fdd30fb6942df392b53818081", Username="MikaMikic"},
                new User {FirstName = "Mile", LastName="Mikic", Email="milemikic@gmail.com", Password="c0e6ed4fdd30fb6942df392b53818081", Username="Mile"},
                new User {FirstName = "Ana", LastName="Anic", Email="anaanic@gmail.com", Password="c0e6ed4fdd30fb6942df392b53818081", Username="anci"}
            };

            var comments = new List<Comment>()
            {
                new Comment {Text="Cute pet.", User= users.ElementAt(1)},
                new Comment {Text="I also got a new pet.", User= users.ElementAt(2)},
                new Comment {Text="Cute plant.",User= users.ElementAt(1)},
                new Comment {Text="Nice computer.",User= users.ElementAt(2)}

            };
            var posts = new List<Post>()
            {
                new Post {Title="New Puppy" , User= users.First(), Image="image1.jpg", Content="My parents finally bought me a new puppy", Category=categories.ElementAt(6)},
                new Post {Title="Aloa vera" , User= users.First(), Image="image2.jpg", Content="My aloa vera has grown so much in the last year.", Category=categories.First()},
                new Post {Title="Making my first computer" , User= users.ElementAt(1), Image="image3.jpg", Content="This is my first time making a computer from scrach and I must say it was very fun.", Category=categories.ElementAt(1)}
            };
            var likes = new List<Like>()
            {
                new Like {Liked=1, Post=posts.First(), User=users.ElementAt(1)}
            };

            var postcomments = new List<PostComment>()
            {
                new PostComment {Post=posts.First(), Comment=comments.First()},
                new PostComment {Post=posts.First(), Comment=comments.ElementAt(1)},
                new PostComment {Post=posts.ElementAt(1), Comment=comments.ElementAt(2)},
                new PostComment {Post=posts.ElementAt(2), Comment=comments.ElementAt(3)},
            };

            var context = new ProjekatContext();

            context.Users.AddRange(users);
            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.Comments.AddRange(comments);
            context.PostComments.AddRange(postcomments);
            context.Likes.AddRange(likes);


            context.SaveChanges();

            return StatusCode(201);
        }

    }
}
