using System;
using System.Collections.Generic;
using API.Data;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //api/commands
    [Route("api/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
       
        //GET api/commands
        [HttpGet]
        public ActionResult <IEnumerable<Command>> GetAllCommands()
        {
            var commandItems = _repository.GetAllCommands();
            return Ok(commandItems);
        }

        //GET api/commands/{id}
        [HttpGet("{id}")]
        public ActionResult <Command> GetCommandById(Guid id)
        {
            var commandItem = _repository.GetCommandByID(id);
            return Ok(commandItem);
        }
    }
}