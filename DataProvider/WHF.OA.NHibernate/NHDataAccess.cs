using System.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using System.Linq;

namespace WHF.OA.NHibernate
{
    public class NHDataAccess
    {
        /// <summary>
        /// 构造方法，构造时Session初始化
        /// </summary>
        public NHDataAccess()
        {
            Session = new NHFactory().GetSession();
        }

        /// <summary>
        /// 构造方法，传入Session，初始化话Session
        /// </summary>
        /// <param name="session">Session</param>
        internal NHDataAccess(ISession session)
        {
            Session = session;
        }

        /// <summary>
        /// Session属性
        /// </summary>
        protected ISession Session { get; set; }


        /// <summary>
        /// 插入实体到DB
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">实体</param>
        /// <param name="isFlush">是否需要Flush</param>
        protected virtual void Insert<T>(T t, bool isFlush = true)
        {
            //Session.Clear();
            Session.Save(t);
            if (isFlush)
                Flush();
        }

        /// <summary>
        /// 更新实体到DB
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">实体</param>
        /// <param name="isFlush">是否需求Flush</param>
        protected virtual void Update<T>(T t, bool isFlush = true)
        {
            //Session.Clear();
            Session.Update(t);
            if (isFlush)
                Flush();
        }

        /// <summary>
        /// 删除实体
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">实体</param>
        /// <param name="isFlush">是否需求Flush</param>
        protected virtual void Delete<T>(T t, bool isFlush = true)
        {
            //Session.Clear();
            Session.Delete(t);
            if (isFlush)
                Flush();
        }

        /// <summary>
        /// Flush方法
        /// </summary>
        protected void Flush()
        {
            Session.Flush();
        }

        /// <summary>
        /// 通过主键 获取对象实体
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="id">ID</param>
        /// <returns>获取对象</returns>
        public virtual T GetObject<T>(object id) where T : class, new()
        {
            return Session.Get<T>(id);
        }

        /// <summary>
        /// 查询一组对象 主键不参与筛选
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">对象</param>
        /// <param name="isIgnoreCase">是否忽略大小写</param>
        /// <param name="isEnableLike">是否支持模糊查询</param>
        /// <returns>实体列表</returns>
        public virtual IList<T> Query<T>(T t, bool isIgnoreCase = false, bool isEnableLike = false) where T : class
        {
            Example example = Example.Create(t);
            if (isIgnoreCase)
            {
                example = example.IgnoreCase();
            }
            if (isEnableLike)
            {
                example = example.EnableLike();
            }
            return Session.CreateCriteria(t.GetType()).Add(example).List<T>();
        }

        /// <summary>
        /// 查询一组对象的第一条 主键不参与筛选
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">类型</param>
        /// <returns>满足条件的第一条</returns>
        public virtual T FirstOrDefault<T>(T t) where T : class, new()
        {
            Example example = Example.Create(t);
            ICriteria criteria = Session.CreateCriteria(t.GetType());
            criteria.SetMaxResults(1);
            IList<T> result = criteria.Add(example).List<T>();
            return result == null ? new T() : result.FirstOrDefault();
        }

        /// <summary>
        /// 查询满足条件的实体数量
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="t">实体</param>
        /// <returns>数量</returns>
        public virtual int Count<T>(T t) where T : class, new()
        {
            return Session.CreateCriteria(t.GetType()).Add(Example.Create(t)).List().Count;
        }

        /// <summary>
        /// 是否存在满足筛选条件的实体
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="t">实体</param>
        /// <returns>true：存在实体，false：不存在</returns>
        public virtual bool IsExist<T>(T t) where T : class, new()
        {
            return Session.CreateCriteria(t.GetType()).Add(Example.Create(t)).List<T>().Count > 0;
        }

    }
}