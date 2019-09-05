using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Solid.Extensions.Test.Utility
{
    public enum TestEnum
    {
        /// <summary>
        /// 壱
        /// </summary>
        [Display(Name = "壱")]
        One = 1,

        /// <summary>
        /// 弐
        /// </summary>
        [Display(Name = "弐")]
        Two,

        /// <summary>
        /// 参
        /// </summary>
        [Display(Name = "参")]
        Three,

        /// <summary>
        /// 四
        /// </summary>
        Four,
    }
}
