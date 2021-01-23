using System;
using System.Collections.Generic;
using CommandHelper.Model;

namespace CommandHelper.Data
{
    public class MockCommandHelperRepo : ICommandHelperRepo
    {
        public IEnumerable<Command> GetAppCommands()
        {
            var commands = new List<Command>{
                new Command{Id=0,HowTo="",Line="",Platform=""},
                new Command{Id=1,HowTo="",Line="",Platform=""},
                new Command{Id=2,HowTo="",Line="",Platform=""}
            };
            return commands;
        }

        public Command GetCommandByID(int id)
        {
            return new Command{Id=0,HowTo="",Line="",Platform=""};
        }
    }
}