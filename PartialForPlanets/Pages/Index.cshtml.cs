using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PartialForPlanets.Models;

namespace PartialForPlanets.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public List<Planets> planet { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            planet = new List<Planets>();
            planet.Add(new Planets() { Name = "Mercury", Description = "Mercury is the smallest planet in the Solar System and the closest to the Sun", Position = 1, Size = 2439.7M, Features = new List<string>() { "No Satellites", "Dark gray in Color", "Mercury is a terrestrial planet. It is small and rocky" } });
            planet.Add(new Planets() { Name = "Venus", Description = "Venus is named after the Roman goddess of love and beauty", Position = 2, Size = 6051.8M, Features = new List<string>() { "No Satellites", "Orange in Color", "Hottest planet in our solar system" } });
            planet.Add(new Planets() { Name = "Earth", Description = "Our home planet Earth is a rocky, terrestrial planet.", Position = 3, Size = 6371M, Features = new List<string>() { "One Satellite", "Blue in Color", "Only Planet in Solar Sytem that supports life" } });
            planet.Add(new Planets() { Name = "Mars", Description = "Mars is a cold desert world. It is half the Size of Earth", Position = 4, Size = 3389.5M, Features = new List<string>() { "Two Satellites", "Red in Color due to rusty iron on the ground", "Mars is the only planet we have sent rovers to." } });
            planet.Add(new Planets() { Name = "Jupiter", Description = "Jupiter is a gas giant and doesn't have a solid surface, but it may have a solid inner core about the Size of Earth", Position = 5, Size = 69911M, Features = new List<string>() { "Seventy Nine Satellites", "Orange-Yellow in Color", "Jupiter is the biggest planet in our solar system" } });
            planet.Add(new Planets() { Name = "Saturn", Description = "Saturn has a lovely set of seven main rings with spaces between them", Position = 6, Size = 58232M, Features = new List<string>() { "Sixty two Satellites", "Yellow-Brown in Color", "Saturn isn’t the only planet to have rings, but it definitely has the most beautiful ones" } });
            planet.Add(new Planets() { Name = "Uranus", Description = "Uranus is made of water, methane, and ammonia fluids above a small rocky center", Position = 7, Size = 25362M, Features = new List<string>() { "Twenty Seven Satellites", "Blue-Green in Color due to methane in the atmosphere", "Uranus rotates on its side" } });
            planet.Add(new Planets() { Name = "Neptune", Description = "Neptune is made of a thick fog of water, ammonia, and methane over an Earth-Sized solid center", Position = 8, Size = 24622M, Features = new List<string>() { "Fourteen Satellites", "Blue in Color due to methane in the atmosphere", "Neptune has six rings, but they're very hard to see" } });
        }


    

        public void OnGet()
        {

        }
    }
}
