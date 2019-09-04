namespace Solid.Extensions
{
    /// <summary>
    /// string型拡張メソッド用クラス
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Null or Emputyの判定
        /// </summary>
        /// <param name="value">文字列</param>
        /// <returns>文字列がNull or Emptyの場合true。それ以外false</returns>
        public static bool IsNullOrEmpty(this string value)
            => string.IsNullOrEmpty(value);
    }
}
