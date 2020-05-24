using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;

namespace cw6_v2.Services
{

    interface IHospitalDbService
    {
        List<Object[]> ExecuteSelect(SqlCommand command);
        void ExecuteInsert(SqlCommand command);
        SqlConnection GetConnection();
    }
}