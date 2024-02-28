using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;
using Persistence.Contexts;


namespace Persistence.Repositories;
public class IndividualCustomerRepository : EfRepositoryBase<IndividualCustomer, Guid, BaseDbContext>, IIndividualCustomer
{
    public IndividualCustomerRepository(BaseDbContext context) : base(context)
    {
    }
}
