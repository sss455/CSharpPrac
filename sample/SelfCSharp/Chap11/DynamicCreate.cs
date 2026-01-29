using System.Dynamic;

namespace SelfCSharp.Chap11
{
    internal class FreeMember : DynamicObject
    {
        private readonly Dictionary<string, object?> items;

        public FreeMember()
        {
            this.items = new();
        }

        public override bool TrySetMember(SetMemberBinder binder,
                object? value)
        {
            this.items[binder.Name] = value;
            return true;
        }

        public override bool TryGetMember(GetMemberBinder binder,
            out object? result)
        {
            if (!this.items.TryGetValue(binder.Name, out result))
            {
                result = null;
            }
            return true;
        }
    }

    internal class DynamicCreate
    {
        static void Main(string[] args)
        {
            dynamic d = new FreeMember();
            d.Count = 1;
            d.Name = "山田";
            Console.WriteLine(d.Count);
            Console.WriteLine(d.Name);
        }
    }
}
