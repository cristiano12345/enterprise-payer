using System.Collections.Generic;
using System.Threading.Tasks;
using LoanPayer.domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("venda/status")]
public class StatusVendaController : ControllerBase {

    [HttpGet]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<List<StatusVenda>>> Get(
        [FromServices] DataContext context)
    { 
        var model = await context.StatusVenda.AsNoTracking().ToListAsync();
        return Ok(model);
    }

    [HttpGet]
    [Route("{id:long}")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<StatusVenda>> Get(
        long id,
        [FromServices] DataContext context)
    { 
        var model = await context.StatusVenda
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id.Equals(id));
            
        return Ok(model);
    }


    [HttpPost]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<StatusVenda>> Post(
        [FromServices] DataContext context, 
        [FromBody]StatusVenda model)
    {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.StatusVenda.Add(model);
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
    public async Task<ActionResult<StatusVenda>> Put(
        int id, 
        [FromServices] DataContext context, 
        [FromBody]StatusVenda model)
    {
            if(id != model.Id)
                return NotFound(new { message = "Não encontrado" });

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Entry<StatusVenda>(model).State = EntityState.Modified;
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

            var model = await context.StatusVenda.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if(model == null)
                return NotFound(new { message = "Não encontrado" });           

            try 
            {
                context.StatusVenda.Remove(model);
                await context.SaveChangesAsync();
                return Ok(new { message = "Registro removido com sucesso" });
            }           
            catch
            {
                return BadRequest(new { message = "Não foi possivel deletar" });
            }       
    }

}