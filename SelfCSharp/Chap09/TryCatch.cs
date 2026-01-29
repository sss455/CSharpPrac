using System;

namespace SelfCSharp.Chap09
{
    internal class TryCatch
    {
        static void Main(string[] args)
        {
            try
            {

                using (var sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("== ex.Data =================================================================================");
                Console.WriteLine("==   ※ 例外に関するユーザー定義の情報（キー／値のペア）=====================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.Data);
                Console.WriteLine();

                Console.WriteLine("== ex.HelpLink =============================================================================");
                Console.WriteLine("==   ※ 例外に関連付いたヘルプファイルへのリンク ============================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.HelpLink);
                Console.WriteLine();

                Console.WriteLine("== ex.InnerException =======================================================================");
                Console.WriteLine("==   ※ 現在の例外の原因となる例外 ==========================================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.InnerException);
                Console.WriteLine();

                Console.WriteLine("== ex.Message ==============================================================================");
                Console.WriteLine("==   ※ 例外メッセージ ======================================================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine();

                Console.WriteLine("== ex.Source ===============================================================================");
                Console.WriteLine("==   ※ エラーの原因となったアプリ／オブジェクトの名前 ======================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.Source);
                Console.WriteLine();

                Console.WriteLine("== ex.TargetSite ===========================================================================");
                Console.WriteLine("==   ※ 現在の例外がスローされたメソッド ====================================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine();

                Console.WriteLine("== ex.StackTrace ===========================================================================");
                Console.WriteLine("==   ※ スタックトレース（呼び出し履歴）=====================================================");
                Console.WriteLine("============================================================================================");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();

            }
            
        }
    }
}
