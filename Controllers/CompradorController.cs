using System.Collections.Generic;
using System.Threading.Tasks;
using LoanPayer.domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("comprador")]
public class CompradorController : ControllerBase {

    [HttpGet]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<List<Comprador>>> Get(
        [FromServices] DataContext context)
    { 
        var model = await context.Comprador.AsNoTracking().ToListAsync();
        return Ok(model);
    }

    [HttpGet]
    [Route("{id:long}")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<Comprador>> Get(
        long id,
        [FromServices] DataContext context)
    { 
        var model = await context.Comprador
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id.Equals(id));
            
        return Ok(model);
    }


    [HttpPost]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<Comprador>> Post(
        [FromServices] DataContext context, 
        [FromBody]Comprador model)
    {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Comprador.Add(model);
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch
            {
                return BadRequest(new { message = "Não foi possivel concluir o cadastro" });
            }       
    }

    [HttpPut]
    [Route("{id:int}")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<Comprador>> Put(
        int id, 
        [FromServices] DataContext context, 
        [FromBody]Comprador model)
    {
            if(id != model.Id)
                return NotFound(new { message = "Não encontrado" });

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Entry<Comprador>(model).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(model);
            }
            catch(DbUpdateConcurrencyException)
            {
                return BadRequest(new { message = "Registro ja fpoi atualizado" });
            }   
            catch
            {
                return BadRequest(new { message = "Não foi possivel atualizar o cadastro" });
            }       
    }

    [HttpDelete]
    [Route("{id:int}")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<string>> Delete(
        long id, 
        [FromServices] DataContext context 
        )
    {

            var model = await context.Comprador.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if(model == null)
                return NotFound(new { message = "Não encontrado" });           

            try 
            {
                context.Comprador.Remove(model);
                await context.SaveChangesAsync();
                return Ok(new { message = "Registro removido com sucesso" });
            }           
            catch
            {
                return BadRequest(new { message = "Não foi possivel deletar" });
            }       
    }

}