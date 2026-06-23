using Core.DataAccess.Repositories;
using DataAccessLayer.EntityFramework.Abstracts;
using DataAccessLayer.EntityFramework.Context;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework.Concretes
{
    public class OnBilgilendirmeRepository : EfRepositoryBase<OnBilgilendirme, BaseDbContext>, IOnBilgilendirmeRepository
    {
        public OnBilgilendirmeRepository(BaseDbContext context) : base(context)
        {
        }
    }
}
