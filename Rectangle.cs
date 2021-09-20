namespace Module6Lecture
{
    public class Rectangle
    {
        private double length;
        private double width;
        private double _length;
        private double _width;
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
            _length = len;
        }

        public void SetWidth(double wid)
        {
           _width = wid;
        }

        public double GetWidth()
        {
            return _width;
        }

        public double GetLength()
        {
            return _length;
        }
    }
}