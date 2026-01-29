using SelfCSharp.Chap08.Prop;

namespace SelfCSharp.Chap08
{
    internal class BusinessPerson : Person
    {
        public string Work()
        {
            return $"{this.LastName}{this.FirstName}は、働きます。";
        }

        //メソッドの隠蔽
        //public new string Show()
        //{
        //    return $"会社員の{this.LastName}{this.FirstName}です。";
        //}

        //メソッドの削除
        //public new string Show()
        //{
        //    throw new NotSupportedException();
        //}

    }

    internal class InheritBasic
    {
        static void Main(string[] args)
        {
            var bp = new BusinessPerson
            {
                FirstName = "太郎",
                LastName = "山田"
            };
            Console.WriteLine(bp.Work());
            Console.WriteLine(bp.Show());
        }
    }
}
