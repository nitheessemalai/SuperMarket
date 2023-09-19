using MarketLibrary.MarketModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketLibrary.MarketRepositoy
{
     public interface IEntityframRepository
    {
        public List<Market> SPMarketmodel();

        public Market SPmarketmodelID(int ID);

        public void SPInsert(Market detail);
        public void SPupdate(Market detail);
        public void SPDelete(int ID);
    }
}
