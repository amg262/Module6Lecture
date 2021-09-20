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

        public void SetArea()
        {
            _area = length * width;
        }

        public double GetArea()
        {
            return _area;
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