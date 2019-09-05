using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Extensions
{
    /// <summary>
    /// IEnumerable拡張メソッド
    /// </summary>
    public static class IEnumerableExtensions
    {
        /// <summary>
        /// Null or Emptyの判定
        /// </summary>
        /// <typeparam name="T">IEnumerable<typeparamref name="T"/>となる型T</typeparam>
        /// <param name="obj">IEnumerable　インターフェース コレクション</param>
        /// <returns>文字列がNull or Emptyの場合true。それ以外false</returns>
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> obj)
            => obj == null || obj.Count() == 0;

        /// <summary>
        /// ForEach拡張メソッド
        /// </summary>
        /// <typeparam name="T">IEnumerable<typeparamref name="T"/>となる型T</typeparam>
        /// <param name="sequence">IEnumerable インターフェース コレクション</param>
        /// <param name="action">ループで実行されるAction</param>
        public static void ForEach<T>(this IEnumerable<T> sequence, Action<T> action)
        {
            foreach (var item in sequence) { action(item); }
        }
    }
}
