using System;
using System.Collections.Generic;
using Domain;

namespace API.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommandByID(Guid id);
    }
}