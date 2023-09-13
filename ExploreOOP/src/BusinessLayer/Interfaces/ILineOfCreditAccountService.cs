using ExploreOOP.src.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreOOP.src.BusinessLayer.Interfaces
{
    internal interface ILineOfCreditAccountService
    {

        public LineOfCreditAccount Get(int id);

        public void Delete(int id);
    }
}
