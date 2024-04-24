using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyIOC.Console
{
    public class DALFactory
    {
        public DALFactory() { }
        public static IDAL GetSQLDal()
        {
            return new DAL();
        }

        public static IDAL GetOracleDal()
        {
            return new OracleDAL();
        }
    }
}
