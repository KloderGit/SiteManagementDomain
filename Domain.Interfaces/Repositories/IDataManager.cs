

namespace Domain.Interfaces.Repositories
{
    public interface IDataManager
    {
        ICategoryRepository Categories { get; }
        IEducationalPlanRepository EducationalPlans { get; }
        IEducationTypeRepository EducationTypes { get; }
        IGroupRepository Groups { get; }
        IEducationProgramRepository EducationPrograms { get; }
        ISubGroupRepository SubGroups { get; }
        ISubjectRepository Subjects { get; }
        ICertificationRepository Certification { get; }
        ICertificationTypeRepository CertificationTypes { get; }
    }
}
