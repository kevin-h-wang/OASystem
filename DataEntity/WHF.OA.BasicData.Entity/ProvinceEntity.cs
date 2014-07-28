/*----------------------------------------------------------------
// Copyright (C) 2014方正国际软件有限公司
// 版权所有。
// 文   件   名：ProvinceEntity.cs
// 文件功能描述：
//
//
// 创 建 人：王洪福
// 创建日期：2014年7月28日 11:19:19
//
// 修 改 人：
// 修改描述：
//
// 修改标识：
//----------------------------------------------------------------*/
using System;

namespace WHF.OA.BasicData.Entity
{
    /// <summary>
    /// 省份表
    /// </summary>
    [Serializable]  
    public class ProvinceEntity
    {
        #region 属性
        public int ID { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public  string Name{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  int? Status{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  decimal? OrderNo{ get; set; }

        #endregion
    }
}
