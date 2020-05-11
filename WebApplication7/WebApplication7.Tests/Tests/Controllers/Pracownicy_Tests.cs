using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

using System.Text;
using Moq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.DependencyInjection;
using WebApplication7;
using WebApplication7.Controllers;
using WebApplication7.Models;



namespace WebApplication7.Tests
{
    public class Pracownicy_tests
    {

        [Fact]
        public void Index_Test()
        {
            var builder = new DbContextOptionsBuilder<WebApplication7Context>().UseInMemoryDatabase("WebApplication7");
            var context = new WebApplication7Context(builder.Options);

            // var mockrepo1 = new Mock<WebApplication7Context>() ;//Brak bezparametrycznego konstruktora - dostepny konstruktor nie moze byc bezposrednio uzywany
            var mockrepo2 = new Mock<ILogger<Pracownicy>>();
            //  mockrepo1.Object.Pracownik.ToListAsync();

            var controller = new Pracownicy(context, mockrepo2.Object);

            var result = controller.Index().Result;

            Assert.IsType<ViewResult>(result);
        }
 
       
      
        
        [Fact]
        public void Zaloguj_Admin_Tests()
        {
            var builder = new DbContextOptionsBuilder<WebApplication7Context>().UseInMemoryDatabase("WebApplication7");
            var context = new WebApplication7Context(builder.Options);
            var mockrepo2 = new Mock<ILogger<Pracownicy>>();
            var controller = new Pracownicy(context, mockrepo2.Object);
            string login, haslo;
            login = "kasjer1"; haslo = "kasjer1";

            var result = controller.Zaloguj_admin(login, haslo).Result as ViewResult;



            Assert.IsType<ViewResult>(result);
            
        }
    }
}
