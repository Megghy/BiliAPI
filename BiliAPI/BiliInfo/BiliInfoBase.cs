using BiliAPI.BiliInterface;

namespace BiliAPI.BiliInfo
{
    /// <summary>
    /// 封装数据基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BiliInfoBase<T> where T : IBiliData, new()
    {
        public BiliInfoBase(string originJson)
        {
            if (string.IsNullOrEmpty(originJson))
                return;
            OriginJson = originJson;
            Root = DeserializeData(originJson);
        }
        /// <summary>
        /// 接收的原始字符串响应
        /// </summary>
        public string? OriginJson { get; set; }
        /// <summary>
        /// 反序列化后的原始响应
        /// </summary>
        public BiliRoot<T>? Root { get; set; }
        /// <summary>
        /// 反序列化后的数据体
        /// </summary>
        public T Data => Root!.data ?? new();
        /// <summary>
        /// 将给定的json反序列化为结构体
        /// </summary>
        /// <param name="json">指定json</param>
        /// <returns>反序列化后的数据</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public virtual BiliRoot<T>? DeserializeData(string json)
        {
            return Utils.Deserialize<BiliRoot<T>>(json);
        }
    }
}
