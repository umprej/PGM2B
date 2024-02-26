namespace Classes
{
    public class Obdelnik2
    {
        public int StranaA { get; set; }
        public int StranaB { get; set; }
        public int Obvod => 2 * (StranaA + StranaB);
        public int Obsah => StranaA * StranaB;
        public double Uhlopricka { get; set; }

        public void SpoctiUhlopricku()
        {
            Uhlopricka = Math.Sqrt(Math.Pow(Uhlopricka, 2) + Math.Pow(Uhlopricka, 2));
        }
    }
}
