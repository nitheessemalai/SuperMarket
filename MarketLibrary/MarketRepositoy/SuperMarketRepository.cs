using MarketLibrary.MarketModels;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.MarketRepositoy
{
     public class SuperMarketRepository: IEntityframRepository
    {
        private readonly Marketcontext _context;


        public SuperMarketRepository(Marketcontext context)
        {
            _context = context;
        }
        public List<Market> SPMarketmodel()
        {
            try
            {
                var reg = _context.SuperMarket.FromSqlRaw<Market>("exec SPMarketmodel").ToList();
                return reg;
            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Market SPmarketmodelID(int ID)
        {
            try
            {
                var reg = _context.SuperMarket.FromSqlRaw<Market>($"exec SPmarketmodelID{ID} ").ToList();
                return reg.FirstOrDefault();
            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void SPInsert(Market detail)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec SPInsert'{detail.Name}','{detail.code}','{detail.Department}','{detail.salary}','{detail.DOB}");

            }
            catch (SqlException ep)
            {
                throw ep;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void SPupdate(Market detail)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec SPupdate '{detail.ID}','{detail.Name}','{detail.code}','{detail.Department}','{detail.salary}','{detail.DOB}");

            }
            catch (SqlException ep)
            {
                throw ep;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void SPDelete(int ID)
        {
            try
            {
                _context.Database.ExecuteSqlRaw($"exec SPDelete {ID}");
            }
            catch (SqlException ep)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
