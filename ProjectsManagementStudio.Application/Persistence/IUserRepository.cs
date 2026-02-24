using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectsManagementStudio.Application.Persistence
{
    public interface IUserRepository
    {
        Task<Domain.Entities.User> GetByEmailAsync(string email);
        Task<Domain.Entities.User> GetByIdAsync(Guid id);
        Task AddAsync(Domain.Entities.User user);
        Task UpdateAsync(Domain.Entities.User user);
        Task DeleteAsync(Domain.Entities.User user);
    }
}