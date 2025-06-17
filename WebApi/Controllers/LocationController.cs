using Domain;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly ApiContext _context;

        public LocationController(ApiContext c)
        {
            _context = c;
        }

        [HttpPost, Route("Create")]
        public int Create(Location location)
        {
            _context.Locations.Add(location);
            _context.SaveChanges();
            return 0;
        }
        [HttpGet, Route("GetS/{id}")]
        public Location Get(int id)
        {
            var P = _context.Locations.FirstOrDefault(X => X.Id == id);
            if (P == null)
            {
                return new Location();
            }
            return P;

        }
        [HttpGet, Route("Get")]
        public List<Location> GetLocation()
        {

            return _context.Locations.ToList();
        }
        [HttpDelete, Route("Delete")]
        public void Delete(int id)
        {
            var P = _context.Locations.FirstOrDefault(X => X.Id == id);
            if (P != null)
            {
                _context.Locations.Remove(P);
                _context.SaveChanges();
            }
        }

        [HttpPut, Route("Update")]
        public void Update(Location location)
        {
            var P = _context.Locations.FirstOrDefault(X => X.Id == location.Id);
            if (P != null)
            {
                P.Continente = location.Continente;
                P.Pais = location.Pais;
                P.Estado = location.Estado;
                P.Cidade = location.Cidade;
                _context.SaveChanges();
            }
        }
    }
}
