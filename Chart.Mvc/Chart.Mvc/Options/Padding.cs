namespace Chart.Mvc.Options
{
        public class Padding
        {
            public Padding(double left = 0, double top = 0, double right = 0, double bottom = 0)
            {
                this.Left = left;
                this.Top = top;
                this.Right = right;
                this.Bottom = bottom;
            }

            public double Bottom { get; set; }

            public double Top { get; set; }

            public double Right { get; set; }

            public double Left { get; set; }
        }
}
