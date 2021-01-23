using System.Collections.Generic;
using CommandHelper.Data;
using CommandHelper.Model;
using Microsoft.AspNetCore.Mvc;

namespace CommandHelper.Controllers
{
    [Route("api/commands")]
    [ApiController]
    public class CommandsController:ControllerBase
    {
        private readonly ICommandHelperRepo _repository;
        public CommandsController(ICommandHelperRepo repository)
        {
            this._repository=repository;
        }
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAllCommands(){
            var commandsItem =  _repository.GetAppCommands();
            return Ok(commandsItem);
        }

        //Get api/commands/{id}
        [HttpGet("{id}")]//<- Binding sources for e.g [FromQuery],[FromHeader] 
        public ActionResult<Command> GetCommandById(int id){
            var commandItem = _repository.GetCommandByID(id);
            return commandItem;
        }
    }
}