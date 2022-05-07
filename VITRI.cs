using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class VITRI
    {
        DB db = new DB();

        //Xe dap
        public string getOneViTriEmpty() //Lay vi tri trong dau tien
        {
            SqlCommand command = new SqlCommand("SELECT TOP(1) ViTri FROM VITRI WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if(table.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return table.Rows[0][0].ToString().Trim();
            }
        }
        public DataTable getAllViTriEmpty() //Lay tat ca vi tri trong
        {
            SqlCommand command = new SqlCommand("SELECT * ViTri FROM VITRI WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

       //Xe may
        public string getOneViTri1Empty()//Lay vi tri trong dau tien
        {
            SqlCommand command = new SqlCommand("SELECT TOP(1) ViTri FROM VITRI1 WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return table.Rows[0][0].ToString().Trim();
            }
        }
        public DataTable getAllViTri1Empty()//Lay tat ca vi tri trong
        {
            SqlCommand command = new SqlCommand("SELECT * ViTri FROM VITRI1 WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //Xe hoi
        public string getOneViTri2Empty()//Lay vi tri trong dau tien
        {
            SqlCommand command = new SqlCommand("SELECT TOP(1) ViTri FROM VITRI2 WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                return "";
            }
            else
            {
                return table.Rows[0][0].ToString().Trim();
            }
        }
        public DataTable getAllViTri2Empty()//Lay tat ca vi tri trong
        {
            SqlCommand command = new SqlCommand("SELECT * ViTri FROM VITRI2 WHERE Trong = false", db.getConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
