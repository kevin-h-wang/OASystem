using NHibernate;
using NHibernate.Cfg;

namespace WHF.OA.NHibernate
{
    public class NHFactory
    {   
        /// <summary>
        /// 会话Factory字段
        /// </summary>
        private readonly ISessionFactory _sessionFactory;

        /// <summary>
        /// 构造函数
        /// </summary>
        public NHFactory()
        {
            _sessionFactory = GetSessionFactory();
        }

        /// <summary>
        /// 获取会话Factory
        /// </summary>
        /// <returns>会话Factory</returns>
        private ISessionFactory GetSessionFactory()
        {
            return (new Configuration()).Configure().BuildSessionFactory();
        }

        /// <summary>
        /// 获取会话
        /// </summary>
        /// <returns>会话</returns>
        public ISession GetSession()
        {
            return _sessionFactory.OpenSession();
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        /// <returns>字符串</returns>
        public string GetConnectionString()
        {
            return GetSession().Connection.ConnectionString;
        }
    }
}