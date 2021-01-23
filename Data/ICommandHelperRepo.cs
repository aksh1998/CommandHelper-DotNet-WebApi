using System.Collections.Generic;
using CommandHelper.Model;

namespace CommandHelper.Data
{
    public interface ICommandHelperRepo
    {
         IEnumerable<Command> GetAppCommands();
         Command GetCommandByID(int id);
    }
}