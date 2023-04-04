using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliDynamicV2.DyncmicV2Model;
using BiliAPI.BiliInfo;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamicV2
{
    public static class DynamicV2API
    {
        public const string? UserDynamicURL = "https://api.bilibili.com/x/polymer/web-dynamic/v1/feed/space";
        public const string? DynamicURL = "https://api.bilibili.com/x/polymer/web-dynamic/v1/detail";
        /// <summary>
        /// 从服务器获取动态数据, 未完成的动态类型将只会提供基本信息
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliUserDynamicsV2Info? data)> GetDynamics(
            long uid,
            string pageOffset = "0")
        {
            if (string.IsNullOrEmpty(pageOffset) || !int.TryParse(pageOffset, out _))
                throw new NullReferenceException("Invalid pageOffset");
            var response = await Utils.RequestStringAsync($"{UserDynamicURL}?host_mid={uid}&offset_dynamic_id={pageOffset}");

            if (string.IsNullOrEmpty(response))
                return (false, null);

            var result = new BiliUserDynamicsV2Info(response);

            return (result.Root?.code == 0, result);
        }
        /// <summary>
        /// 从服务器获取指定位置动态数据, 默认为最新动态
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliDynamicV2Types? type, BiliDynamicV2Item? cardData)> GetUserDynamic(
            long uid,
            int index = 0,
            string pageOffset = "0")
        {
            if (index is < 0 or > 11)
                throw new ArgumentOutOfRangeException(nameof(index));
            (var success, var result) = await GetDynamics(uid, pageOffset);
            if (success)
                return (success, result?.Data.items[index].type, result?.Data.items[index]);
            else
                return (false, BiliDynamicV2Types.DYNAMIC_TYPE_NONE, null);
        }
        /// <summary>
        /// 从服务器获取最新一个动态数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliDynamicV2Types? type, BiliDynamicV2Item? cardData)> GetUserLatestDynamic(long uid)
        {
            (var success, var result) = await GetDynamics(uid);
            if (success)
                return (success, result?.Data?.items.FirstOrDefault()?.type, result?.Data.items.FirstOrDefault());
            else
                return (false, BiliDynamicV2Types.DYNAMIC_TYPE_NONE, null);
        }
        /// <summary>
        /// 获取指定动态数据
        /// </summary>
        /// <param name="dynamicID">动态ID</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="NotSupportedException"></exception>
        /// <exception cref="JsonException"></exception>
        public static async Task<(bool success, BiliDynamicV2Types? type, BiliDynamicV2Item? data)> GetSingleDynamic(
            long dynamicID)
        {
            if (dynamicID < 0)
                throw new ArgumentOutOfRangeException(nameof(dynamicID));
            var response = await Utils.RequestStringAsync($"{DynamicURL}?id={dynamicID}");

            if (string.IsNullOrEmpty(response))
                return (false, BiliDynamicV2Types.DYNAMIC_TYPE_NONE, null);

            var root = Utils.Deserialize<BiliRoot<BiliDynamicV2Item>>(response);
            if (root?.code != 0)
                return (false, BiliDynamicV2Types.DYNAMIC_TYPE_NONE, null);

            var result = root!.data;
            return (true, result!.type, result);
        }
    }
}
