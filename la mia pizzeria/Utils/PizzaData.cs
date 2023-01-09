using la_mia_pizzeria.Models;

namespace la_mia_pizzeria.Utils
{
    public static class PizzaData
    {
        static private List<Pizza> ListaPizze = new List<Pizza>()
        {
            new Pizza (0,"Zeus Padre", "La Zeus padre nasce in venerazione del padre di tutti gli dei Zeus, unisce una sfiziosa stracciatella di burrata pugliese, cicoria di campo, pomodorini del piennolo e fiori di zucca, con un goccio di olio EVO umbro.", 14, "https://citynews-firenzetoday.stgy.ovh/~media/horizontal-hi/31855285755656/vecchio-mare-2.jpg"),
            new Pizza (1, "Ade", "Il regno dei morti, in tutto il suo valore, la Ade è fatta con curry verde di verdure bio, pollo allevato a terra marinato CBT, gel di curry affumicato, crumble di arachidi e coriandolo.", 17, "https://scontent.fmxp6-1.fna.fbcdn.net/v/t1.6435-9/125043892_2247437868750350_5692989777439114219_n.jpg?_nc_cat=104&ccb=1-7&_nc_sid=730e14&_nc_ohc=vg0NNV6UzcQAX_rLahF&_nc_ht=scontent.fmxp6-1.fna&oh=00_AfBIkJUJFQANX9EhjgITZA4vfvi56-JXqQ2gP1wZBB1s8Q&oe=63E3AB2F"),
            new Pizza (2, "Persefone", "Il regno dei morti ha accolto Persefone, ma la natura l'ha richiamata, e questa pizza testimonia tutto il suo amore per il mondo. Scarola riccia dell’orto biologico di Imma Migliaccio, pomodorini del piennolo, olive caiazzane, capperi di Salina, alici di Cetara e burrata di bufala.",12, "https://www.scattidigusto.it/wp-content/uploads/2017/03/pizza-riccia-di-mamma-Francesco-Martucci.jpg")
        };

        public static List<Pizza> GetPizze()
        {
            return ListaPizze;
        }
    }
}
