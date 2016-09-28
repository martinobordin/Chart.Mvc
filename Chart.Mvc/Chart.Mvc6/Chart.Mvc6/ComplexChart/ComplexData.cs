using System.Collections.Generic;

namespace Chart.Mvc.Charts
{
    /// <summary>
    /// The complex data.
    /// </summary>
    public class ComplexData
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexData"/> class.
        /// </summary>
        public ComplexData()
        {
            this.Labels = new List<string>();
            this.Datasets = new List<ComplexDataset>();
        }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        public List<string> Labels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        public List<ComplexDataset> Datasets
        {
            get;
            set;
        }
    }
}