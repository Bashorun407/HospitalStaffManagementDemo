using HSMD.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSMD.Application.Contracts
{
    public interface IHospitalRepository
    {
        Task<IEnumerable<Hospital>> GetHospitals(bool trackChanges);
        Task<Hospital> GetHospitalById(long Id, bool trackChanges);
        Task<Hospital> GetHospitalByName(string Name, bool trackChanges);
        void CreateHospital(Hospital hospital);
        //void UpdateHospital(Hospital hospital); //This may not be needed as 'save' functionality can do same
        void DeleteHospital(Hospital hospital);

    }
}
