using SixMinAPI.Models;

namespace SixMinAPI.Data
{
    public interface ICommandRepo
    {
        // Asyncronous methods
        Task SaveChanges();
        Task<Command?> GetCommandById(int id);
        Task<IEnumerable<Command>> GetAllCommands();
        Task CreateCommand(Command cmd);

        // Not asyncronous
        void DeleteCommand(Command cmd);
    }
}