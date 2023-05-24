using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ConnesioneDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("connesione al database microsoft sql");
            //acceso db
            SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
            connection.DataSource = @".\MSSQLSERVER01";
            connection.UserID = "backend";
            connection.Password = "Its-2023";
            connection.InitialCatalog = "Anagrafica";
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = connection.ConnectionString;
            sqlConnection.Open();
            Console.WriteLine("Connesione al Database efetuato con successo");
            //filtri sui campi
            Console.WriteLine("inserire classe");
            string Classe =Console.ReadLine();

            //interrogo db
            string Comando = "Select * From Studenti where Classe like '"+Classe+"'";
            SqlCommand cmd= new SqlCommand();
            cmd.Connection= sqlConnection;
            cmd.CommandText= Comando;
            cmd.CommandType=CommandType.Text;

            //visualizazione dei dati
            SqlDataReader sdr =cmd.ExecuteReader();
            while (sdr.Read())
            {
                Console.Write(" Matricola: "+sdr.GetInt16(0));
                Console.Write(" Nome: " + sdr.GetString(1));
                Console.Write(" Cognome: "+ sdr.GetString(2));
                Console.Write(" Email: " + sdr.GetString(3));
                Console.Write(" Classe: " + sdr.GetString(4));
                Console.WriteLine();


            }
            //stacca stacca ci stanno tracciando
            sdr.Close();sqlConnection.Close();
            
        }
    }
}