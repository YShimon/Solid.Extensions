using System;
using System.ComponentModel.DataAnnotations;

namespace Solid.Extensions
{
    /// <summary>
    /// Enum拡張メソッド
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// EnumDisplay属性のNameプロパティを取得
        /// </summary>
        /// <typeparam name="T">enum型</typeparam>
        /// <param name="value">enum値</param>
        /// <returns>Display属性のNameプロパティ</returns>
        public static string DisplayName<T>(this T value) where T : Enum
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var atributes = fieldInfo.GetCustomAttributes(typeof(DisplayAttribute), false) as DisplayAttribute[];
            if (atributes != null && atributes.Length > 0)
            {
                return atributes[0].Name;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
