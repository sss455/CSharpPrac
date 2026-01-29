using System.Dynamic;

namespace SelfCSharp.Chap11.DynamicProcess
{
    internal class FreeMember : DynamicObject
    {

        private readonly Dictionary<string, object?> items;

        public FreeMember()
        {
            items = new();
        }


        public override bool TryInvokeMember(InvokeMemberBinder binder,
            object?[]? args, out object? result)
        {
            result = null;

            if (args == null || args.Length == 0)
            {
                items.TryGetValue(binder.Name, out result);
            }
            else
            {
                items[binder.Name] = args[0];
            }
            return true;
        }
    }


    internal class DynamicMethod
    {
        static void Main(string[] args)
        {
            dynamic d = new FreeMember();
            d.Count(1);
            d.Name("山田");
            Console.WriteLine(d.Count());
            Console.WriteLine(d.Name());
        }
    }
}
