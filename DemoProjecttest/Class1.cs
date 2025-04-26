using System.Collections.Generic;
using NUnit.Framework;
using TestingTask1;
namespace DemoProjecttest
{
    [TestFixture]
    public class Class1
    {
        List<Employee> li;

        [Test]
        public void Testlogin()
        {
            Program p = new Program();
            string x, y, z;
            x = p.Login("", "");
            y = p.Login("Admin", "Admin");
            z = p.Login("asdasd", "23");

            Assert.That(x, Is.EqualTo("Username or password are empty"));
            Assert.That(y, Is.EqualTo("Login successful , Welcome Admin"));
            Assert.That(z, Is.EqualTo("Login failed"));
        }
        [Test]
        public void CheckDetails()
        {
            Program p = new Program();
            li = p.AllUsers();
            foreach (var item in li)
            {
                Assert.That(item.Id, Is.Not.Null);
                Assert.That(item.Name, Is.Not.Null);
                Assert.That(item.Salary, Is.Not.Null);
                Assert.That(item.Gender, Is.Not.Null);
            }
        }
        [Test]
        public void GetuserDetails() 
        {
            Program p = new Program();
            var x = p.GetEmployees(1);
            foreach (var item in x)
            {
                Assert.That(item.Id, Is.EqualTo(1));
                Assert.That(item.Name, Is.EqualTo("Mawlana"));
                Assert.That(item.Gender, Is.EqualTo("Male"));
                Assert.That(item.Salary, Is.EqualTo(1000));
            }

        }
    }
}
