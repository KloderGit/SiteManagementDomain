using Domain.Core.Education;
using System.Collections.Generic;
using System.Linq;

namespace Domain.Interfaces.Repositories
{
    public interface IEducationProgramRepository : ICommonRepository<EducationProgram>
    {
        IQueryable<EducationProgram> GetAllWithReferences();

        IQueryable<EducationProgram> GetAllWithChildren();
    }
}
