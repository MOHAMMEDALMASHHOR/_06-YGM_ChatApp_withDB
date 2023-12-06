using ChatEntities;
using ChatRepositories;
using Microsoft.AspNetCore.Mvc;

namespace ChatApi.Controller;
[ApiController]
[Route("api/chats")]
public class ChatsController:ControllerBase
{
    private readonly RepositoryContext _repositoryContext;

    public ChatsController(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }
    [HttpGet]
    public IActionResult GetAll(){
        return Ok(_repositoryContext.Chats);
    }
    [HttpGet("{id:int}")]
    public IActionResult GetOne(int id){
        var item = _repositoryContext.Chats.Where(chat=>chat.Id.Equals(id)).SingleOrDefault();
        if (item is null)
        {
            return NoContent();
        }
        return Ok(item);
    }
    [HttpPost]
    public IActionResult AddChat(Chats chats){
        if (chats is null)
        {
            return BadRequest("You can't add an empty item!!!!");
        }
        _repositoryContext.Chats.Add(chats);
        _repositoryContext.SaveChanges();
        return Ok("The Chat is added successfully!!!");
    }
    [HttpPut]
    public IActionResult Upadate(int id, Chats chats){
        if (chats is null && id == null)
        {
            return BadRequest("You can't add an empty item!!!!");
        }
      var item =  _repositoryContext.Chats.SingleOrDefault(chat=>chat.Id.Equals(id));
      if (item is not null)
      {
        item.UserName = chats.UserName;
        item.Message=chats.Message;
        item.SendDate=chats.SendDate;
        _repositoryContext.Chats.Update(item);
        _repositoryContext.SaveChanges();
      }
        return NoContent();
    }
    [HttpDelete]
    public IActionResult Delete(){
        foreach (var item in _repositoryContext.Chats)
        {
            
        _repositoryContext.Chats.Remove(item);
        }
        _repositoryContext.SaveChanges();
        return Ok("The Table is cleared!!");
    }
    [HttpDelete("{id:int}")]
    public IActionResult DeleteOne(int id){
        var item = _repositoryContext.Chats.SingleOrDefault(chat=>chat.Id.Equals(id));
        if (item is null)
        {
            return NotFound();
        }
        _repositoryContext.Chats.Remove(item);
        _repositoryContext.SaveChanges();
        return Ok("it is deleted!!");

    }
}