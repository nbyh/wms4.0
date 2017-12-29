/*******************************************************************************
 * Copyright (C) Git Corporation. All rights reserved.
 *
 * Author: 情缘
 * Create Date: 2014-08-11 18:52:24
 *
 * Description: Git.Framework
 * http://www.cnblogs.com/qingyuan/
 * Revision History:
 * Date         Author               Description
 * 2014-08-11 18:52:24       情缘
*********************************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Git.Storage.Common
{
    public enum ESupType
    {
        /// <summary>
        /// 虚拟供应商
        /// </summary>

        [Description("雷达设备供应商")]
        RadarSupplier = 1,

        [Description("自动站设备供应商")]
        AwsSupplier = 2,

        [Description("计算机网络设备供应商")]
        ComputerSupplier = 3,

        [Description("虚拟供应商")]
        Invented = 4,

        [Description("合作供应商")]
        Cooperation = 5


    }
}
