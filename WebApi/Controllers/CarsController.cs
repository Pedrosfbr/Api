using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {

        private readonly ApiContext _context;
        public CarsController(ApiContext c)
        {
            _context = c;
        }

        [HttpPost, Route("Create")]

        public int Create(Cars carros)
        {
            _context.Carss.Add(carros);
            _context.SaveChanges();
            return 0;
        }
        [HttpGet, Route("GetS/{id}")]
        public Cars Get(int id)
        {
            var P = _context.Carss.FirstOrDefault(X => X.Id == id);
            if (P == null)
            {
                return new Cars();
            }
            return P;

        }
        [HttpGet, Route("Get")]
        public List<Cars> GetCars()
        {

            return _context.Carss.ToList();
        }
        [HttpDelete, Route("Delete")]
        public void Delete(int id)
        {
            var P = _context.Carss.FirstOrDefault(X => X.Id == id);
            if (P != null)
            {
                _context.Carss.Remove(P);
                _context.SaveChanges();
            }
        }

        [HttpPut, Route("Update")]
        public void Update(Cars carros)
        {
            var P = _context.Carss.FirstOrDefault(X => X.Id == carros.Id);
            if (P != null)
            {
                P.Marca = carros.Marca;
                P.Modelo = carros.Modelo;
                P.Placa = carros.Placa;
                _context.SaveChanges();
            }
        }

    }
}