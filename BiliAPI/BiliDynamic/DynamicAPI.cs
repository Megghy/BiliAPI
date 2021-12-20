using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliSharedEntity;

namespace BiliAPI.BiliDynamic
{
    public static class DynamicAPI
    {
        public const string API_URL = "https://api.vc.bilibili.com/dynamic_svr/v1/dynamic_svr/space_history";
        /// <summary>
        /// 从服务器获取动态数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, BiliRoot<BiliDynamicData>? cardsData)> GetDynamic(
            long uid,
            string pageOffset = "0")
        {
            if (string.IsNullOrEmpty(pageOffset) || !int.TryParse(pageOffset, out _))
                throw new NullReferenceException("Invalid pageOffset");
            try
            {
                var response = await Utils.RequestStringAsync($"{API_URL}?host_uid={uid}&offset_dynamic_id={pageOffset}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = Utils.Deserialize<BiliRoot<BiliDynamicData>>(response);

                result?.data?.SerializeCard();
                return (true, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, null);
            }
        }
        /// <summary>
        /// 从服务器获取指定位置动态数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, BiliDynamicCardsItem? cardData)> GetLatestDynamic(
            long uid,
            int index = 0,
            string pageOffset = "0")
        {
            if (index is < 0 or > 11)
                throw new ArgumentOutOfRangeException(nameof(index));
            (var success, var result) = await GetDynamic(uid, pageOffset);
            if (success)
                return (success, result?.data?.cards?[index]);
            else
                return (false, null);
        }
    }
}
