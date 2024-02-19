namespace Classes
{
    public class Obdelnik
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        public int Obvod {  get; set; }
        public int Obsah {  get; set; }
        public double Uhlopricka { get; set; }

        public void SpoctiObvod()
        {
            Obvod = 2 * (StranaA + StranaB);
        }

        public void SpoctiObsah()
        {
            Obsah = StranaA * StranaB;
        }

        public void SpoctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(Math.Pow(Uhlopricka, 2) + Math.Pow(Uhlopricka, 2));
        }

        public void Vypocet()
        {
            SpoctiObvod();
            SpoctiObsah();
            SpoctiUhlopricku();
        }
}
}
