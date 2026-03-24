using ApiCoreHospital.Data;
using ApiCoreHospital.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCoreHospital.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context)
        {
            this.context = context;
        }


        public async Task<List<Hospital>> GetHospitalesAsync()
        {
            return await this.context.Hospitales.ToListAsync();
        }

        public async Task<Hospital> FindHospitalIdAsync( int id)
        {
            return await this.context.Hospitales.FirstOrDefaultAsync(h => h.IdHospital == id);
        }
       
    }
}
