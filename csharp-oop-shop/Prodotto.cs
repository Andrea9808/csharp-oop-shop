namespace csharp_oop_shop
{
    public class Prodotto
    {

        //imposto la variabile in private
        private int Codice;

        //accedo al codice tramite una proprietà pubblica
        public int codice 
        {
            get
            {
                return Codice;
            }
        }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        private decimal Prezzo;
        public decimal prezzo { get; set; }
        public int Iva { get; set; }

        //COSTRUTTORE PER NUMERI RANDOM
        //(viene chiamato automaticamente ogni volta che viene creata un'istanza)
        public Prodotto()
        {
            Random rnd = new Random();
            Codice = rnd.Next(1000, 3000);
        }

        public decimal PrezzoBase()
        {
            return prezzo;
        }

        public decimal PrezzoConIVA()
        {
            this.Iva = 22;
            decimal prezzoConIVA = prezzo * ((decimal)Iva / 100);
            decimal prezzoComplessivo = prezzo + prezzoConIVA;
            return prezzoComplessivo;
        }

        public void NomeConCodice()
        {
            Console.WriteLine($"NOME {this.Nome} + CODICE: {this.Codice}");
        }

        //BONUS
        public string CodiceConPadding()
        {
            //8 cifre con carattere 0 da sinistra, il padding funziona solo con stringa,
            //perciò trasformo il codice in stringa
            return Codice.ToString().PadLeft(8, '0');
        }

    }
}
