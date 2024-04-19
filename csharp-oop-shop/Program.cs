namespace csharp_oop_shop
{


    internal class Program
    {
        static void Main()
        {

            Prodotto nuovoProdotto = new Prodotto();
            
            nuovoProdotto.prezzo = 50.99m;
            nuovoProdotto.Nome = "Prodotto";
            nuovoProdotto.Descrizione = "Descrizione del prodotto";

            Console.WriteLine($"NOME: {nuovoProdotto.Nome}");
            Console.WriteLine($"DESCRIZIONE: {nuovoProdotto.Descrizione}");
            Console.WriteLine($"Il codice del prodotto è: {nuovoProdotto.codice}");
            Console.WriteLine($"Prezzo base: {nuovoProdotto.PrezzoBase()} euro");
            Console.WriteLine($"Il prezzo del prodotto compreso di Iva: {nuovoProdotto.PrezzoConIVA():F2}");
            nuovoProdotto.NomeConCodice();

            //BONUS 1
            Console.WriteLine($"Codice con padding: {nuovoProdotto.CodiceConPadding()}");

            //BONUS 2
            Prodotto[] elencoProdotti = new Prodotto[2];

            //prodotti
            elencoProdotti[0] = new Prodotto 
            { 
                Nome = "Telefono",  
                Descrizione = "Descrizione telefono", 
                prezzo = 123.12m 
            };
            elencoProdotti[1] = new Prodotto
            { 
                Nome = "Computer",
                Descrizione = "Descrizione computer",
                prezzo = 1234.12m 
            };

            Console.WriteLine();
            Console.WriteLine("Elenco dei prodotti nel negozio:");
            foreach (Prodotto prodotto in elencoProdotti)
            {
                Console.WriteLine();
                Console.WriteLine($"- Nome: {prodotto.Nome}, \nDescrizione: {prodotto.Descrizione}, \nCodice: {prodotto.codice},\nPrezzo base: {prodotto.PrezzoBase()}, \nPrezzo compreso di IVA al 22%: {prodotto.PrezzoConIVA():F2} euro");
            }
        }
    }
}
