namespace Module6Lecture
{
    public class Rectangle
    {
        private double _area;
        private double _length;
        private double _width;
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        /*
         * Overloaded constructor that can be created and default values
         */
        public Rectangle()
        {
            _length = 1;
            _width = 1;
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


        public double GetArea()
        {
            return _length * _width;
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