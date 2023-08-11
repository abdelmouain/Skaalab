using Skalaab_Exercise4.Dtos;
using Skalaab_Exercise4.Entities;

namespace Skalaab_Exercise4.Repositories;

public interface ILearnResourceRepository
{
    Task<IEnumerable<LearnResource>> GetAllLearnResources(CancellationToken cancellationToken = default);
    Task AddLearnResource(LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default);
    Task EditLearnResource(int id, LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default);
    Task DeleteLearnResource(int id, CancellationToken cancellationToken = default);
}