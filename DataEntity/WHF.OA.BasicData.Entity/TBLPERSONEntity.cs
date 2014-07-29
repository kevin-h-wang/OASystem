/*----------------------------------------------------------------
// Copyright (C) 2014方正国际软件有限公司
// 版权所有。
// 文   件   名：TBLPERSONEntity.cs
// 文件功能描述：
//
//
// 创 建 人：Administrator
// 创建日期：2014年7月29日 21:55:21
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
    /// 
    /// </summary>
    [Serializable]  
    public class TBLPERSONEntity
    {
        #region 属性
        public virtual string oid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personcode{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personaccount{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personpassword{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personname{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int personsex{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int personstatus{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual int persontype{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personofficephone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personmobilephone{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personemail{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personmemo{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string cuser{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime cdate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string muser{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime mdate{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DateTime mpwdtime{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personpasswordquestion{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string personpasswordanswer{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string addition1{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual string addition2{ get; set; }

        #endregion
    }
}
