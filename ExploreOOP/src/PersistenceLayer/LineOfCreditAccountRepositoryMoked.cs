﻿using ExploreOOP.src.BusinessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer
{
    public class LineOfCreditAccountRepositoryMoked : ILineOfCreditAccountRepository
    {
        static List<LineOfCreditAccount> s_List = new List<LineOfCreditAccount>();

        public LineOfCreditAccountRepositoryMoked()
        {
            s_List.Add(new LineOfCreditAccount("Cuenta 1",10,0));
            s_List.Add(new LineOfCreditAccount("Cuenta 2", 10, 0));
            s_List.Add(new LineOfCreditAccount("Cuenta 3", 10, 0));
        }
        public void Add(LineOfCreditAccount lineOfCreditAccount)
        {
            s_List.Add(lineOfCreditAccount);
        }

        public void Delete(int id)
        {
            

            s_List.RemoveAt(id);
        }

        public LineOfCreditAccount Get(int id)
        {
            return s_List[id];
        }

        public List<LineOfCreditAccount> GetAll()
        {
            return s_List;
        }
    }
}
