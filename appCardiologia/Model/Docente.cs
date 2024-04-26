using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appCardiologia.Model
{
    internal class Docente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int crm { get; set; }
        public string titulacao { get; set; }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Aluno\\source\\repos\\appCardiologia\\appCardiologia\\Database1.mdf;Integrated Security=True");

        public List<Docente> listaDocente()
        {
            List<Docente> li = new List<Docente>();
            string sql = "SELECT * FROM Docente";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Docente c = new Docente();
                c.id = (int)dr["Id"];
                c.nome = dr["nome"].ToString();
                c.crm = (int)dr["crm"];
                c.titulacao = dr["titulacao"].ToString();
                li.Add(c);
            }
            dr.Close();
            con.Close();
            return li;
        }

        public void Inserir(string nome, int crm, string titulacao)
        {
            string sql = "INSERT INTO Docente(nome,crm,titulacao) VALUES ('" + nome + "','" + crm + "','" + titulacao + "')";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Excluir(int Id)
        {
            string sql = "DELETE FROM Docente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Localizar(int Id)
        {
            string sql = "SELECT * FROM Docente WHERE Id='" + Id + "'";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                nome = dr["nome"].ToString();
                crm = (int)dr["crm"];
                titulacao = dr["titulacao"].ToString();
            }
            dr.Close();
            con.Close();
        }

        public bool RegistroRepetido(int crm)
        {
            string sql = "SELECT * FROM Docente WHERE crm='" + crm + "'";
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
