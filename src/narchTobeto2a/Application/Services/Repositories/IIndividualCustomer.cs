using Domain.Entities;
using NArchitecture.Core.Persistence.Repositories;


namespace Application.Services.Repositories;
public interface IIndividualCustomer : IAsyncRepository<IndividualCustomer, Guid>, IRepository<IndividualCustomer, Guid>
{

}
