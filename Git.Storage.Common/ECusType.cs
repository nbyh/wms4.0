using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum ECusType
    {
        /// <summary>
        /// 合作领用
        /// </summary>
        [Description("合作领用")]
        Cooperation = 1,

        /// <summary>
        /// 潜在领用
        /// </summary>
        [Description("潜在领用")]
        Potential = 2,

        /// <summary>
        /// 丢失领用
        /// </summary>
        [Description("丢失领用")]
        Lost = 3,

        /// <summary>
        /// 虚拟领用
        /// </summary>
        [Description("虚拟领用")]
        Invented = 4
    }
}
