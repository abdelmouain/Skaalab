using Skalaab_Exercise4.Dtos;
using Skalaab_Exercise4.Entities;
using Skalaab_Exercise4.Repositories;

namespace Skalaab_Exercise4.Services;

public class LearnResourceService
{
    private readonly ILearnResourceRepository _resourceRepository;
    public LearnResourceService(ILearnResourceRepository resourceRepository)
    {
        _resourceRepository = resourceRepository;
    }

    public async Task<IEnumerable<LearnResource>> GetAllLearnResources(CancellationToken cancellationToken = default)
    {
        return await _resourceRepository.GetAllLearnResources(cancellationToken);
    }

    public async Task AddLearnResource(LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default)
    {
        await _resourceRepository.AddLearnResource(learnResourceDto, cancellationToken);
    }

    public async Task EditLearnResource(int id, LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default)
    {
        await _resourceRepository.EditLearnResource(id, learnResourceDto, cancellationToken);
    }

    public async Task DeleteLearnResource(int id, CancellationToken cancellationToken = default)
    {
        await _resourceRepository.DeleteLearnResource(id, cancellationToken);
    }

}
