namespace Core_Ludoteca.Models
{
    public class Prestito
    {
        public DateOnly data_prestito { get; set; }
        public DateOnly data_restituzione { get; set; }
        public string note { get; set; }
        public int ID_Prestito { get; set; }
        public int ID_Gioco { get; set; }
        public string CF_Utente { get; set; }

        public override string ToString()
        {
            return $"{nameof(data_prestito)}={data_prestito.ToString()}," +
                $" {nameof(data_restituzione)}={data_restituzione.ToString()}," +
                $" {nameof(note)}={note}, {nameof(ID_Prestito)}={ID_Prestito.ToString()}," +
                $" {nameof(ID_Gioco)}={ID_Gioco.ToString()}, {nameof(CF_Utente)}={CF_Utente}";
        }
    }
}
