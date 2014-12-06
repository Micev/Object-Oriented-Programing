namespace StringDesperser
{
    using System;
    using System.Collections;
    using System.Text;
    public class StringDisperser : ICloneable, IComparable, IEnumerable
    {
        private string[] text;

        public StringDisperser(params string[] text)
        {
            this.Text = text;
        }

        public string[] Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }

        public override bool Equals(object obj)
        {

            return this.ToString() == ((StringDisperser)obj).ToString();
        }

        public override string ToString()
        {
            return string.Join("", this.Text);
        }

        public override int GetHashCode()
        {
            var hasCode = 0;
            foreach (var item in this.Text)
            {
                hasCode ^= item.GetHashCode();
            }
            return hasCode;
        }

        public static bool operator ==(StringDisperser a, StringDisperser b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(StringDisperser a, StringDisperser b)
        {
            return !a.Equals(b);
        }

        public object Clone()
        {
            var clone = new StringDisperser((string[])this.Text.Clone());

            return clone;
        }

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        public IEnumerator GetEnumerator()
        {
            var str = this.ToString();

            for (int i = 0; i <str.Length; i++)
            {
                yield return str[i];
            }
        }
    }
}
