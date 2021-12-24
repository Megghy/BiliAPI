using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInfo;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic
{
    public static class DynamicAPI
    {
        public const string? DynamicURL = "https://api.vc.bilibili.com/dynamic_svr/v1/dynamic_svr/space_history";
        /// <summary>
        /// 从服务器获取动态数据, 未完成的动态类型将只会提供基本信息
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, BiliDynamicsInfo? cardsData)> GetDynamics(
            long uid,
            string pageOffset = "0")
        {
            if (string.IsNullOrEmpty(pageOffset) || !int.TryParse(pageOffset, out _))
                throw new NullReferenceException("Invalid pageOffset");
            try
            {
                var response = await Utils.RequestStringAsync($"{DynamicURL}?host_uid={uid}&offset_dynamic_id={pageOffset}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliDynamicsInfo(response);

                return (result.Root?.code == 0, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, null);
            }
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
        public static async Task<(bool success, DynamicType? type, IBiliDynamicCardInfo? cardData)> GetDynamic(
            long uid,
            int index = 0,
            string pageOffset = "0")
        {
            if (index is < 0 or > 11)
                throw new ArgumentOutOfRangeException(nameof(index));
            (var success, var result) = await GetDynamics(uid, pageOffset);
            if (success)
                return (success, result?.Cards[index].Type, result?.Cards[index]);
            else
                return (false, DynamicType.Error, null);
        }/// <summary>
         /// 从服务器获取最新一个动态数据
         /// </summary>
         /// <param name="uid">用户ID</param>
         /// <returns>
         /// 是否成功及动态信息
         /// </returns>
        public static async Task<(bool success, DynamicType? type, IBiliDynamicCardInfo? cardData)> GetLatestDynamic(long uid)
        {
            (var success, var result) = await GetDynamics(uid);
            if (success)
                return (success, result?.Cards.FirstOrDefault()?.Type, result?.Cards.FirstOrDefault());
            else
                return (false, DynamicType.Error, null);
        }
    }
}
