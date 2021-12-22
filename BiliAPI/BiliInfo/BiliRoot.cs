namespace BiliAPI.BiliInfo
{
    public class BiliRoot<T> where T : IBiliData
    {
        /// <summary>
        /// 返回状态码 0: 成功, 412: 速率过快被封禁 ...
        /// </summary>
        public int? code { get; set; }
        /// <summary>
        /// 错误信息, 成功则为空
        /// </summary>
        public string? message { get; set; }
        /// <summary>
        /// 1
        /// </summary>
        public int? ttl { get; set; }
        /// <summary>
        /// 数据
        /// </summary>
        public T? data { get; set; }
    }
}
