using LibrarianSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibrarianSystem.Database;
using System.Security.Claims;

namespace LibrarianSystem.Services
{
    public class HomeService
    {
        private readonly HttpClient httpClient;
        private static string ActualApiKey { get; set; }
        private readonly ApplicationDbContext dbContext;

        public HomeService(IHttpClientFactory clientFactory, ApplicationDbContext dbContext)
        {
            httpClient = clientFactory.CreateClient();
            httpClient.DefaultRequestHeaders.Add("apikey", ActualApiKey);
            this.dbContext = dbContext;
        }
        
        public async Task Login(string login, string password)
        {
            var entityUser = dbContext.Clients.FirstOrDefault(u => u.Login.Equals(login) && u.Password.Equals(password));
            
            var claims = new List<Claim> { new Claim(ClaimTypes.Name, entityUser.Login) };
            var identity = new ClaimsIdentity(claims, "CookieAuth");
            var principle = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(principle);

            var returnUrl = TempData["returnUrl"] as string;

            return LocalRedirect(returnUrl ?? "/");
        }
    }
}
