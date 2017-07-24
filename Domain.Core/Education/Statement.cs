using System;
using System.Collections.Generic;

namespace Domain.Core.Education
{
    public class Statement
    {
        public Statement()
        {
            Exams = new HashSet<Exam>();
        }

        public Int32 Id { get; set; }
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public Int32 EducationProgramId { get; set; }
        public virtual EducationProgram EducationProgram { get; set; }

        public Int32 SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public Int32 UserId { get; set; }
        public virtual Core.User.User User { get; set; }

        public Int32 CertificationId { get; set; }
        public virtual Certification Certification { get; set; }

        public Int32? GroupId { get; set; }
        public virtual Group Group { get; set; }

        public virtual ICollection<Exam> Exams { get; set; }
    }
}
