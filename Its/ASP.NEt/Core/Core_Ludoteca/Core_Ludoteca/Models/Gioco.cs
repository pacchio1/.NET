namespace Ludoteca.Models
{
    public class Gioco
    {
        public string Denominazione { get; set; }
        public string Descrizione { get; set; }
        public string Tipologia{ get; set; }
        public string Eta_dei_giocatori { get; set; }
        public string Numero_di_giocatori { get; set; }
        public string Durata_partita { get; set; }
        public int Numero_di_pezzi { get; set; }
        public int ID_Gioco { get; set; }

        public override string ToString()
        {
            return $"{nameof(Denominazione)}={Denominazione}," +
                $" {nameof(Descrizione)}={Descrizione}," +
                $" {nameof(Tipologia)}={Tipologia}," +
                $" {nameof(Eta_dei_giocatori)}={Eta_dei_giocatori}," +
                $" {nameof(Numero_di_giocatori)}={Numero_di_giocatori}," +
                $" {nameof(Durata_partita)}={Durata_partita}," +
                $" {nameof(Numero_di_pezzi)}={Numero_di_pezzi.ToString()}," +
                $" {nameof(ID_Gioco)}={ID_Gioco.ToString()}";
        }
    }
}
