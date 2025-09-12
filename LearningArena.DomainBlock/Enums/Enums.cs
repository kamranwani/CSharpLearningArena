using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArena.DomainBlock.Enums
{
    public enum UserRole
    {
        Pharmacist=1,
        Radiologist=2,
        Cardiologist=3,
        Patient=4
    }

    public enum UserStatus
    {
        Pending=1,
        Accepted=2,
        Blocked=3,
    }
}
