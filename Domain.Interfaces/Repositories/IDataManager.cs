

using System;

namespace Domain.Interfaces.Repositories
{
    public interface IDataManager : IDisposable
    {
        ICategoryRepository Categories { get; }
        IEducationalPlanRepository EducationalPlans { get; }
        IEducationTypeRepository EducationTypes { get; }
        IGroupRepository Groups { get; }
        IEducationProgramRepository EducationPrograms { get; }
        IExamRepository Exams { get; }
        IExamCommentRepository ExamComments { get; }
        IStatementRepository Statements { get; }
        ISharedStatementRepository SharedStatements { get; }
        ISubGroupRepository SubGroups { get; }
        ISubjectRepository Subjects { get; }
        ICertificationRepository Certifications { get; }
        ICertificationTypeRepository CertificationTypes { get; }

        IUserRepository Users { get; }
        IUserCardRepository UserCards { get; }
        IUserCommentRepository UserComments { get; }
        IUserContractRepository UserContracts { get; }
        IUserLocationRepository UserLocations { get; }
        IUserPhotoRepository UserPhotos { get; }
        IUserProfileRepository UserProfiles { get; }

        void Save();
    }
}
