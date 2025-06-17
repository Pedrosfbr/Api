using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly ApiContext _context;
       public ProdutosController(ApiContext c) 
        {
        _context = c;
        }

        [HttpPost, Route("Create")]

        public int Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return 0;
        }
        [HttpGet, Route("GetS/{id}")]
        public Produto Get(int id)
        {
            var P = _context.Produtos.FirstOrDefault(X => X.Id == id);
            if (P == null) 
            {
                return new Produto();
            }
            return P;
            
        }
        [HttpGet, Route("Get")]
        public List<Produto> GetProdutos() 
        {

            return _context.Produtos.ToList();
        }
        [HttpDelete, Route("Delete")]
        public void Delete(int id) 
        {
            var P = _context.Produtos.FirstOrDefault(X => X.Id == id);
            if (P != null)
            {
                _context.Produtos.Remove(P);
                _context.SaveChanges();
            }
        }

        [HttpPut, Route("Update")]
        public void Update(Produto produto)
        {
            var P = _context.Produtos.FirstOrDefault(X => X.Id == produto.Id);
            if (P != null)
            {
                P.Nome = produto.Nome;
                P.Preco = produto.Preco;
                _context.SaveChanges();
            }
        }

    }
}
