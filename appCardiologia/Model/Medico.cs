using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    public class Medico
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int crm { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\appCardiologia\\appCardiologia\\Database1.mdf;Integrated Security=True");

        public List<Medico> listaMedicos()
        {
            List<Medico> li = new List<Medico>();
            string sql = "SELECT * FROM Medico";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Medico c = new Medico();
                c.id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.crm = (int)dr["crm"];
                li.Add(c);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, int crm)
        {
            string sql = "INSERT INTO Medico(nome,crm) VALUES ('" + nome + "','" + crm + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Medico WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Medico WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                crm = (int)dr["crm"];
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(int crm)
        {
            string sql = "SELECT * FROM Medico WHERE crm='" + crm + "'";
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

