using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例模式
{
    public class SingleClass
    {
        /// <summary>
        /// 私有化构造函数
        /// </summary>
        private SingleClass()
        {

        }

        private static SingleClass instance;

        static object obj = new object();

        /// <summary>
        /// 提供一个访问的方法
        /// </summary>
        /// <returns></returns>
        public static SingleClass GetInstance()
        {
            if (instance == null)
            {
                lock (obj)//双重判断可以减少锁的使用
                {
                    if (instance == null)
                    {
                        instance = new SingleClass();
                    }
                }
            }
            return instance;
        }


    }
}
