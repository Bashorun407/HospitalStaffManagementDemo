using HSMD.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.CommonContract
{
    public interface IRepositoryManager
    {
        IHospitalRepository hospitalRepository { get; }
        IStaffRepository staffRepository { get; }
        Task SaveAsync();
    }
}
