namespace Ludoteca.Models
{
    public class Utente
    {
        public string Codicefiscale { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public DateOnly Data_Nascita { get; set; }
        public string Luogo_Nascita{ get; set; }
        public string Indirizo { get; set; }
        public string Cap { get; set; }
        public string Citta { get; set; }
        public string Provincia{ get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{nameof(Codicefiscale)}={Codicefiscale}," +
                $" {nameof(Cognome)}={Cognome}," +
                $" {nameof(Nome)}={Nome}," +
                $" {nameof(Data_Nascita)}={Data_Nascita.ToString()}," +
                $" {nameof(Luogo_Nascita)}={Luogo_Nascita}," +
                $" {nameof(Indirizo)}={Indirizo}," +
                $" {nameof(Cap)}={Cap}," +
                $" {nameof(Citta)}={Citta}," +
                $" {nameof(Provincia)}={Provincia}," +
                $" {nameof(Telefono)}={Telefono}," +
                $" {nameof(Email)}={Email}";
        }
    }
}
