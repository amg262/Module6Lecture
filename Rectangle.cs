namespace Module6Lecture
{
    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public void SetLength(double len)
        {
            length = len;
        }
        
        /*
         * Properties
         */
        public double Length
        {
            get => length;
            set => length = value;
        }

        /*
         * Properties
         */
        public double Width
        {
            get => width;
            set => width = value;
        }
    }
}