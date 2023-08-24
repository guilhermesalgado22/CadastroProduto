using Microsoft.AspNetCore.Mvc;
using Tarefa02.API.Model;
using Tarefa02.Data;

namespace Tarefa02.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        [Route("/")]
        public List<Produto> Get(
            [FromServices] AppDbContext context
        )
        {
            return context.Produto!.ToList(); // Use Ok() para retornar a lista de produtos
        }

        [HttpGet("/{id:int}")]
        
        public Produto GetById([FromRoute] int id,
        [FromServices] AppDbContext context)
        {
            return context.Produto.FirstOrDefault(e => e.ProdutoId == id);
        }


        [HttpPost("/")]
        public Produto Post(
            [FromBody] Produto produto,
            [FromServices] AppDbContext context)
            {
                context.Produto!.Add(produto);
                context.SaveChanges();
                return produto;
            }

            [HttpPut("/{id:int}")]
            public Produto Put([FromRoute] int id,
            [FromBody] Produto produto,
            [FromServices] AppDbContext context)
            {
                var model = context.Produto!.FirstOrDefault(e => e.ProdutoId == id);
                if (model == null){
                    return produto;
                }

                model.ProdutoId = produto.ProdutoId;
                model.Nome = produto.Nome;
                model.Preco = produto.Preco;
                model.Quantidade = produto.Quantidade;

                context.Produto!.Update(model);
                context.SaveChanges();
                return model;

            }
         [HttpDelete("/{id:int}")]
         public Produto Delete ([FromRoute] int id,
         [FromServices] AppDbContext context)
         {
            var model = context.Produto!.FirstOrDefault(e => e.ProdutoId == id);

            context.Produto!.Remove(model);
            context.SaveChanges();
            return model;
         }
    }
}