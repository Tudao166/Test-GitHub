using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    internal class DatabaseAdmin
    {
        public void insert(Employees employees)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Connection.conection))
                {
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "Insert INTO NhanVien (IDNV, NameNV, SalaryNV, HireDay, BirthDay) Values (@id, @name, @salary, @hire, @birth)";
                    cmd.Parameters.AddWithValue("@id", employees.Id);
                    cmd.Parameters.AddWithValue("@name", employees.Name);
                    cmd.Parameters.AddWithValue("@salary", employees.Salary);
                    cmd.Parameters.AddWithValue("@hire", employees.HireDate);
                    cmd.Parameters.AddWithValue("@brith", employees.Yob);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Thêm không Thành Công, Vui Lòng Kiểm Tra Lại");
                return;
            }
        }
    }
}
