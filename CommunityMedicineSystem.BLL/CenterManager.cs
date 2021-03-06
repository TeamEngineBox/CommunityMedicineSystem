﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CommunityMedicineSystem.DAL;
using CommunityMedicineSystem.DAO;

namespace CommunityMedicineSystem.BLL
{
    public class CenterManager
    {
        CenterDBGateway aCenterDbGateway = new CenterDBGateway();

        public List<Center> GetSelectedCenters(int thanaId)
        {
            return aCenterDbGateway.GetSelectedCenters(thanaId);
        }
    }
}
