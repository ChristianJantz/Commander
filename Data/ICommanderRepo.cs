using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int CommandID);
        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);

    }
}