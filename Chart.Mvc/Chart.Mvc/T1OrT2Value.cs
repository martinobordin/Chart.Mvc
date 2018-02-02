namespace Chart.Mvc
{
    public class T1OrT2Value<T1, T2> : IT1OrT2Value<T1, T2>
    {
        public T1OrT2Value(T1 t1Value)
        {
            this.T1Value = t1Value;
        }

        public T1OrT2Value(T2 t2Value)
        {
            this.T2Value = t2Value;
        }

        public T1 T1Value { get; set; }

        public T2 T2Value { get; set; }

        public dynamic Value
        {
            get
            {
                if (!Equals(this.T2Value, default(T2)))
                {
                    return this.T2Value;
                }

                if (!Equals(this.T1Value, default(T1)))
                {
                    return this.T1Value;
                }

                return null;
            }
        }
    }

    public interface IT1OrT2Value<T1, T2> : ISingleOrComplexValue
    {
        T1 T1Value { get; set; }

        T2 T2Value { get; set; }
    }

    public interface ISingleOrComplexValue
    {
        dynamic Value { get; }
    }
}
