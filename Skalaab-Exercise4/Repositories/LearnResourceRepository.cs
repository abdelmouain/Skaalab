using Microsoft.EntityFrameworkCore;
using Skalaab_Exercise4.Dtos;
using Skalaab_Exercise4.Entities;
using Skalaab_Exercise4.Persistence;

namespace Skalaab_Exercise4.Repositories;

public class LearnResourceRepository : ILearnResourceRepository
{
    private readonly AppDbContext _dbContext;

    public LearnResourceRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddLearnResource(LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default)
    {
        //We can use a mapping library later (like AutoMapper)
        var learnResource = new LearnResource
        {
            Description = learnResourceDto.Description,
            EndDate = learnResourceDto.EndDate,
            StartDate = learnResourceDto.StartDate,
            Title = learnResourceDto.Title,
        };

        await _dbContext.LearnResources.AddAsync(learnResource, cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task DeleteLearnResource(int id, CancellationToken cancellationToken = default)
    {
        var learnResource = await _dbContext.LearnResources.FindAsync(id, cancellationToken);
        if (learnResource == null)
            throw new Exception("Item not found in the database");

        _dbContext.LearnResources.Remove(learnResource);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task EditLearnResource(int id, LearnResourceDto learnResourceDto, CancellationToken cancellationToken = default)
    {
        var learnResource = await _dbContext.LearnResources.FindAsync(id, cancellationToken);
        if (learnResource == null)
            throw new Exception("Item not found in the database");

        learnResource.StartDate = learnResourceDto.StartDate;
        learnResource.EndDate = learnResourceDto.EndDate;
        learnResource.Description = learnResourceDto.Description;
        learnResource.Title = learnResourceDto.Title;

        _dbContext.Update(learnResource);
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<IEnumerable<LearnResource>> GetAllLearnResources(CancellationToken cancellationToken = default)
    {
        //we can use a maaping library to make a projection on the Dto class 
        return await _dbContext.LearnResources.ToListAsync(cancellationToken);
    }
}
