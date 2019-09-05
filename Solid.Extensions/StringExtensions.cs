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

        /// <summary>
        /// string型をint型へ変換する
        /// </summary>
        /// <param name="value">整数形式の文字列</param>
        /// <param name="defaultValue">デフォルト値</param>
        /// <returns>整数</returns>
        public static int ToIntOrDefault(this string value, int defaultValue = 0)
            => int.TryParse(value, out int result) ? result : defaultValue;
    }
}
