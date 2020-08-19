using System.Collections.Generic;
using System.Threading.Tasks;
using LoanPayer;
using LoanPayer.domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("Usuario")]
public class UsuarioController : ControllerBase {


    [HttpPost]
    [Route("login")]
    public async Task<ActionResult<dynamic>> Login(
        [FromServices] DataContext context, 
        [FromBody]Usuario model)
    {           

            try 
            {
               var usuario = await context.Usuario
                .AsNoTracking()
                .FirstOrDefaultAsync(x => 
                        x.Login.Equals(model.Login) &&
                        x.Password.Equals(model.Password));

                if(usuario == null)
                    NotFound(new { message = "Usuario não encontrado" });

                var token = TokenService.GenerateToken(usuario);

                return new 
                {
                    usuario = usuario,
                    token = token
                };

            }
            catch
            {
                return BadRequest(new { message = "Erro ao localizar o usuario" });
            }       
    }





    [HttpGet]
    [Route("")]
    public async Task<ActionResult<List<Usuario>>> Get(
        [FromServices] DataContext context)
    { 
        var model = await context.Usuario.AsNoTracking().ToListAsync();
        return Ok(model);
    }

    [HttpGet]
    [Route("{id:long}")]
    public async Task<ActionResult<Usuario>> Get(
        long id,
        [FromServices] DataContext context)
    { 
        var model = await context.Usuario
            .AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id.Equals(id));
            
        return Ok(model);
    }


    [HttpPost]
    [Route("")]
    public async Task<ActionResult<Usuario>> Post(
        [FromServices] DataContext context, 
        [FromBody]Usuario model)
    {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Usuario.Add(model);
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
    public async Task<ActionResult<Usuario>> Put(
        int id, 
        [FromServices] DataContext context, 
        [FromBody]Usuario model)
    {
            if(id != model.Id)
                return NotFound(new { message = "Não encontrado" });

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            try 
            {
                context.Entry<Usuario>(model).State = EntityState.Modified;
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
    public async Task<ActionResult<string>> Delete(
        long id, 
        [FromServices] DataContext context 
        )
    {

            var model = await context.Usuario.FirstOrDefaultAsync(x => x.Id.Equals(id));

            if(model == null)
                return NotFound(new { message = "Não encontrado" });           

            try 
            {
                context.Usuario.Remove(model);
                await context.SaveChangesAsync();
                return Ok(new { message = "Registro removido com sucesso" });
            }           
            catch
            {
                return BadRequest(new { message = "Não foi possivel deletar" });
            }       
    }

}