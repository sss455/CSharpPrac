using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp.Chap10
{
    // 書籍情報
    internal class Book
    {
        /// <summary>ISBNコード</summary>
        public string Isbn { get; set; } = string.Empty;

        /// <summary>書名</summary>
        public string Title { get; set; } = string.Empty;

        /// <summary>価格</summary>
        public int Price { get; set; } = 0;

        /// <summary>出版社</summary>
        public string Publisher { get; set; } = string.Empty;

        /// <summary>刊行日</summary>
        public DateTime Published { get; set; } = DateTime.Today;

        public override string ToString()
        {
            return $"{Title} ({Publisher}) {Price}円　{Published:d}刊行";
        }
    }

    // レビュー情報
    internal class Review
    {
        /// <summary></summary>
        public string Isbn { get; set; } = string.Empty;

        /// <summary>レビュアー名</summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>レビュー本文</summary>
        public string Body { get; set; } = string.Empty;
    }

    internal static class AppTables
    {
        // すべての書籍／レビュー情報を取得するBooks／Reviewsプロパティ
        public static IEnumerable<Book> Books { get; private set; }
        public static IEnumerable<Review> Reviews { get; private set; }

        // 静的コンストラクター（Books／Reviewsプロパティを初期化）
        static AppTables()
        {
            Books = new List<Book>()
            {
                // 1冊目
                new Book {
                    Isbn = "978-4-7981-6849-4",
                    Title = "独習PHP",
                    Price = 3740,
                    Publisher = "翔泳社",
                    Published = new DateTime(2021,6,14)
                },
                // 2冊目
                new Book {
                    Isbn = "978-4-7981-6884-5",
                    Title = "独習Ruby",
                    Price = 3520,
                    Publisher = "翔泳社",
                    Published = new DateTime(2021,9,13)
                },
                // 3冊目
                new Book {
                    Isbn = "978-4-2960-8009-0",
                    Title = "Androidアプリ超入門",
                    Price = 2200,
                    Publisher = "日経BP",
                    Published = new DateTime(2021,11,11)
                },
                // 4冊目
                new Book {
                    Isbn = "978-4-2960-8014-4",
                    Title = "基礎からしっかり学ぶC#の教科書",
                    Price = 3190,
                    Publisher = "日経BP",
                    Published = new DateTime(2022,3,3)
                },
                // 5冊目
                new Book {
                    Isbn = "978-4-7980-6510-6",
                    Title = "はじめてのAndroidアプリ開発",
                    Price = 3520,
                    Publisher = "秀和システム",
                    Published = new DateTime(2021,11,30)
                }
            };


            Reviews = new List<Review>()
            {
                // 1件目
                new Review {
                    Isbn = "978-4-7981-6849-4",
                    Name = "山田太郎",
                    Body = "PHP開発に役立っています。"
                },
                // 2件目
                new Review {
                    Isbn = "978-4-7981-6849-4",
                    Name = "鈴木花子",
                    Body = "急に仕事で扱うことになり、慌てて読み始めたら、分かりやすくて良かったです。"
                },
                // 3件目
                new Review {
                    Isbn = "978-4-7981-6884-5",
                    Name = "山田太郎",
                    Body = "あやふやだったデータの操作が、この本でスッキリ分かるようになった。"
                },
                // 4件目
                new Review {
                    Isbn = "978-4-7981-6884-5",
                    Name = "佐藤久美",
                    Body = "サンプルが作りたいものとマッチしていて、とても参考になりました。"
                },
                // 5件目
                new Review {
                    Isbn = "978-4-7981-6884-5",
                    Name = "加藤次郎",
                    Body = "コンパクトにきちんと情報がまとまっていて、とても読みやすいと思う。"
                }
            };
        }
    }
}
