using System;
using Xunit;
using FindMyUsers.Models;
using Moq;
using Microsoft.EntityFrameworkCore;
using FindMyUsers.Repository;

namespace Tests.FindMyUsers.RepositoryTests
{
    public class RepositoryTests
    {
        [Fact]
        public void Add_User_Passed_ProperMethodCalled()
        {
            // Arrange
            var user = new User
            {
                First = "Johny",
                Last = "Bigawski",
                Interests = "Wordpress, Html, Bootstrap, Php, Css, Dreamweaver, Cms, Ui, Ux, jquery, Sql, Seo, Maintenance, Problem-solving, HTML5, CSS3, HTML5, User Interface, Shopify (5 years), Magento (10+ years), PSD to HTML (10+ years)",
                City = "San Diego"
            };

            var context = new Mock<UsersContext>();
            var dbSetMock = new Mock<DbSet<User>>();
            context.Setup(x => x.Set<User>()).Returns(dbSetMock.Object);
            //dbSetMock.Setup(x => x.Add(It.IsAny<User>())).Returns(user);

            // Act
            IUsersRepository userRepo = new UsersRepository(context.Object);
            userRepo.Create(user);

            //Assert
            context.Verify(x => x.Set<User>());
            dbSetMock.Verify(x => x.Add(It.Is<User>(y => y == user)));
        }
    }
}
