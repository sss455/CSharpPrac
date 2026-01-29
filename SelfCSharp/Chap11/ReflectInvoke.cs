using System;
using System.Reflection;

namespace SelfCSharp.Chap11
{
    internal class ReflectInvoke
    {
        static void Main(string[] args)
        {
            // FileInfoクラスをインスタンス化
            var fi = typeof(FileInfo);
            ConstructorInfo? cf = fi.GetConstructor(new Type[] { typeof(string) });
            Object? obj = cf?.Invoke( new[] { @"C:\data\result.txt" } );

            // メソッドを取得し、実行（result.txtをcopy.txtにコピー
            MethodInfo? copyTo = fi.GetMethod("CopyTo", new Type[] { typeof(string) } );
            copyTo?.Invoke(obj, new[] { @"C:\data\copy.txt" } );
        }
    }
}
