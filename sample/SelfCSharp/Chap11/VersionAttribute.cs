namespace SelfCSharp.Chap11
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface |
        AttributeTargets.Struct, Inherited = false)]
    internal class VersionAttribute : Attribute
    {
        public string Number { get; }
        public bool Beta { get; set; } = false;

        public VersionAttribute(string number)
        {
            this.Number = number;
        }
    }

}
