namespace _08_10_Matrix
{
    using System;

    [AttributeUsage(AttributeTargets.Struct |  AttributeTargets.Class | AttributeTargets.Interface 
        |AttributeTargets.Enum | AttributeTargets.Method , AllowMultiple = false)]
  
    public class VersionAtribute : Attribute
    {
        public VersionAtribute(int major, int minor)
        {
            this.Major = major;
            this.Minor = minor;
        }

        public int Major { get; private set; }
        public int Minor { get; private set; }

        public override string ToString()
        {
            return  string.Format("Version: {0}.{1}",this.Major,this.Minor);
        }
    }
    
    
}
