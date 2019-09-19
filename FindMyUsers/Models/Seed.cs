using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FindMyUsers.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UsersContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<UsersContext>>()))
            {
                // Look for any users.
                if (context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.AddRange(
                    new User
                    {
                        //Id = 1,
                        First = "Johny",
                        Last = "Bigawski",
                        Interests = "Wordpress, Html, Bootstrap, Php, Css, Dreamweaver, Cms, Ui, Ux, jquery, Sql, Seo, Maintenance, Problem-solving, HTML5, CSS3, HTML5, User Interface, Shopify (5 years), Magento (10+ years), PSD to HTML (10+ years)",
                        City = "San Diego"
                    },

                    new User
                    {
                        //Id = 2,
                        First = "Brad",
                        Last = "Adams",
                        Interests = "Html, Javascript, Mongoose, Node.js, Vue.js, Webpack, Software development, Ec2, Mongodb, Crm, Software architecture, Css, Architecture, Graphic design, Illustrator, Digital media, Marketing, Customer service, Photoshop, Strategic planning, CSS3, Front End, React",
                        City = "Salt Lake City"
                    },

                    new User
                    {
                        //Id = 3,
                        First = "Ricky",
                        Last = "Carter",
                        Interests = "DJANGO, DOCKER, HTML, JAVASCRIPT, NODE.JS, REDUX, WEBPACK, PYTHON, SWIFT, MONGODB, ANGULARJS, jQuery, MYSQL, SQLITE, CSS, React.js (1 year), MongoDB (2 years), IOS, PostgreSQL, Redis, Cassandra, Jest, Enzyme, Chai, Nginx, Mocha, Express.js, Socket.io, AWS",
                        City = "Salt Lake City"
                    },

                    new User
                    {
                        //Id = 4,
                        First = "Bob",
                        Last = "Stewart",
                        Interests = "Api, Git, Javascript, Oop, Php, Laravel, Symfony, Python, Regex, Svn, Systems analysis, Dns, nginx, Web services, Data manipulation, Mysql, Oracle, Postgresql, Sqlite, Apache",
                        City = "New York"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}