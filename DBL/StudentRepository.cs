using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBL
{
    public class StudentRepository
    {

        DBHelper helper = new DBHelper();
        public void Save(string studentName, int studentAge)
        {
            helper.ExecuteNonQuery("insert into TBL_Students ([StudentName], [StudentAge]) values ('" + studentName + "'," + studentAge + ")");
        }

        public void Delete(int studentID)
        {
            helper.ExecuteNonQuery("delete from TBL_Students where StudentID=" + studentID);
        }

        public void Update(int studentID, string studentName, int studentAge)
        {
            helper.ExecuteNonQuery("UPDATE TBL_Students SET StudentName ='" + studentName + "', StudentAge =" + studentAge + " WHERE StudentID = " + studentID);
        }



        public DataTable GetAllData()
        {
            return helper.ExecuteReader("Select * from TBL_Students");
        }
    }
}
