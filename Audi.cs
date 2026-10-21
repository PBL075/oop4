using System;

namespace audi
{
    class Audi
    {
        public string model;
        public string culoare;
        private int pret;

        public int Pret
        {
            get
            {
                Console.Write("Rezultat: " );
                return this.pret;
            }
            set
            {
                if(value < 1)
                     this.pret = 1;
                else if (value > 5000)
                     this.pret = 5000;
                else
                     this.pret = value;
            }
        }
        public int Width { get ;  set; }
        

        public Audi(string model, string culoare, int pret)
        {
            this.model = model;     
            this.culoare = culoare;
            this.pret = pret;
            
        }

        public void setDate()
        {
            Console.WriteLine("Model la audi: " + this.model + " | culoarea: " + this.culoare + " | pretul in euro: " + this.pret);
        }
    }
}