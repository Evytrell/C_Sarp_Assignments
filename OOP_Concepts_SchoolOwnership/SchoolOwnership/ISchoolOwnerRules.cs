using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOwnership
{
    public interface ISchoolOwnerRules
    {
    public string NumberOfTeachers();

    // This is a rule that all intending school owners shoud have gone to a teacher's training college
    public string IsTrainingProvided();
    }
}

 