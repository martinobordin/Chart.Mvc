using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex dataset.
    /// </summary>
    public class ComplexDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexDataset"/> class.
        /// </summary>
        public ComplexDataset()
        {
            this.Data = new List<double>();
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fill value.
        /// </summary>
        public bool Fill
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the fill color.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stroke color.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the point color.
        /// </summary>
        public string PointBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the point stroke color.
        /// </summary>
        public string PointBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public List<double> Data
        {
            get; 
            set;
        }
    }
}