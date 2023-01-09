namespace la_mia_pizzeria.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descrizione { get; set; }

        public double prezzo { get; set; }

        public string immagine { get; set; }

        public Pizza (int id, string nome, string descrizione, double prezzo, string immagine)
        {
            this.Id = id;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.immagine = immagine;
        }
    }
}
