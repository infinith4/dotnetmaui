using System;
using System.Reflection;

namespace MauiTestProject.Utils
{
    //https://qiita.com/saeki4n/items/1cafac3f4451e517ae06
    /// <summary>
    /// .Net Coreで消えた PrivateObjectの代替クラス。
    /// プライベートメソッドのテストに使用する
    /// </summary>
    public class PrivateObject
    {
        private readonly object _obj;
        public PrivateObject(object obj)
        {
            _obj = obj;
        }

        public object Invoke(string methodName, params object[] args)
        {
            var type = _obj.GetType();
            var bindingFlags = BindingFlags.InvokeMethod | BindingFlags.NonPublic | BindingFlags.Instance;
            try
            {
                return type.InvokeMember(methodName,
                                         bindingFlags,
                                         null,
                                         _obj,
                                         args);
            }
            catch (Exception e)
            {
                throw e.InnerException;
            }
        }
    }

}

