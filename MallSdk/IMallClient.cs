using MallSdk.Request;

namespace MallSdk
{
    /// <summary>
    /// Mall客户端。
    /// </summary>
    public interface IMallClient
    {
        /// <summary>
        /// 执行Mall公开API请求。
        /// </summary>
        /// <typeparam name="T">领域对象</typeparam>
        /// <param name="request">具体的Mall API请求</param>
        /// <returns>领域对象</returns>
        T Execute<T>(IMallRequest<T> request) where T : MallResponse;
    }
}
