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

        public void SetLength(double len)
        {
            length = len;
        }

        public void SetWidth(double wid)
        {
            this.width = wid;
        }

        public double GetWidth()
        {
            return this.width;
        }

        public double GetLength()
        {
            return this.length;
        }
    }
}