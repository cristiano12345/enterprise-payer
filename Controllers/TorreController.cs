using System.Collections.Generic;
using System.Threading.Tasks;
using LoanPayer.domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("torre")]
public class TorreController : ControllerBase {

    [HttpGet]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<List<Torre>>> Get(
        [FromServices] DataContext context)
    { 
        var model = await context.Torre.AsNoTracking().ToListAsync();
        return Ok(model);
    }

    [HttpGet]
    [Route("{id:long}")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<Torre>> Get(
        long id,
        [FromServices] DataContext context)
    { 
        var model = await context.Torre
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id.Equals(id));
            
        return Ok(model);
    }


    [HttpPost]
    [Route("")]
    [Authorize(Roles="admin")]
    public async Task<ActionResult<Torre>> Post(
        [FromServices] DataContext context, 
        [FromBody]Torre model)
    {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Torre.Add(model);
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
    public async Task<ActionResult<Torre>> Put(
        int id, 
        [FromServices] DataContext context, 
        [FromBody]Torre model)
    {
            if(id != model.Id)
                return NotFound(new { message = "Não encontrado" });

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Entry<Torre>(model).State = EntityState.Modified;
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

            var model = await context.Torre.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if(model == null)
                return NotFound(new { message = "Não encontrado" });           

            try 
            {
                context.Torre.Remove(model);
                await context.SaveChangesAsync();
                return Ok(new { message = "Registro removido com sucesso" });
            }           
            catch
            {
                return BadRequest(new { message = "Não foi possivel deletar" });
            }       
    }

}