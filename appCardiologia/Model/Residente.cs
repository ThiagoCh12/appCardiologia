using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    internal class Residente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int crm { get; set; }
        public DateTime data_residencia { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\appCardiologia\\appCardiologia\\Database1.mdf;Integrated Security=True");

        public List<Residente> listaResidente()
        {
            List<Residente> li = new List<Residente>();
            string sql = "SELECT * FROM Residente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Residente c = new Residente();
                c.id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.crm = (int)dr["crm"];
                c.data_residencia = (DateTime)dr["data_residencia"];
                li.Add(c);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, int crm, DateTime data_residencia)
        {
            string sql = "INSERT INTO Residente(nome,crm,data_residencia) VALUES ('" + nome + "','" + crm + "','" + data_residencia + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Residente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Residente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                crm = (int)dr["crm"];
                data_residencia = (DateTime)dr["data_residencia"];
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(int crm)
        {
            string sql = "SELECT * FROM Residente WHERE crm='" + crm + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return (int)result > 0;
            }
            con.Close();
            return false;
        }
    }
}
