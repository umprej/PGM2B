    public class Die {
        private int sides = 6;
        public int currentValue = 5;
        public int Sides {
            get => sides;
            set { sides = value; }
        }

    public int Roll() {
        var rand = new Random();
        return  rand.Next(0, sides) + 1;
    }
    public override string ToString()
    {
        return "D" + sides;
    }



}