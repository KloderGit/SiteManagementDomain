using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Core.Education
{
    public class Subject
    {
        public Subject()
        {
            EducationalPlanList = new HashSet<EducationalPlan>();
        }

        public Int32 Id { get; set; }
        public Guid Guid { get; set; }
        public string Title { get; set; }
        public Int32? Duration { get; set; }

        public Int32? AssessmentId { get; set; }
        public virtual Certification Assessment { get; set; }

        public virtual ICollection<EducationalPlan> EducationalPlanList { get; set; }
    }
}
