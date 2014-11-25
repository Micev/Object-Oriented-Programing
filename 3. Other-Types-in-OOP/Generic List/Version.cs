using System;

    [AttributeUsage(AttributeTargets.Class |
        AttributeTargets.Struct |
        AttributeTargets.Enum |
        AttributeTargets.Interface |
        AttributeTargets.Method)]
    public class Version : System.Attribute
    {

        public int Minor { get; set; }
        public int Major { get; set; }
        public Version(int major, int minor)
        {
            this.Minor = minor;
            this.Major = major;
        }

        public override string ToString()
        {
            return string.Format("{0}.{1}", this.Major, this.Minor);
        }
    }