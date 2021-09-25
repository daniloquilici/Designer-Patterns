using System;
using System.Collections.Generic;

namespace Command
{
    public class FilaCommand
    {
        public IList<ICommand> ListCommand { get; private set; }

        public FilaCommand()
        {
            ListCommand = new List<ICommand>();
        }

        public void AddCommand(ICommand command)
        {
            ListCommand.Add(command);
        }

        public void ProcessaCommand()
        {
            foreach (var command in ListCommand)
            {
                command.Executa();
            }
        }
    }
}
