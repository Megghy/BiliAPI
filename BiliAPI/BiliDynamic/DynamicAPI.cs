﻿using BiliAPI.BiliDynamic.DynamicModel;
using BiliAPI.BiliInfo;
using BiliAPI.BiliInterface;

namespace BiliAPI.BiliDynamic
{
    public static class DynamicAPI
    {
        public const string? UserDynamicURL = "https://api.vc.bilibili.com/dynamic_svr/v1/dynamic_svr/space_history";
        public const string? DynamicURL = "https://api.vc.bilibili.com/dynamic_svr/v1/dynamic_svr/get_dynamic_detail";
        /// <summary>
        /// 从服务器获取动态数据, 未完成的动态类型将只会提供基本信息
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <param name="index">想要获取动态的位置(最大值11), 最新动态则为0</param>
        /// <param name="pageOffset">动态页offset</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, BiliUserDynamicsInfo? cardsData)> GetDynamics(
            long uid,
            string pageOffset = "0")
        {
            if (string.IsNullOrEmpty(pageOffset) || !int.TryParse(pageOffset, out _))
                throw new NullReferenceException("Invalid pageOffset");
            try
            {
                var response = await Utils.RequestStringAsync($"{UserDynamicURL}?host_uid={uid}&offset_dynamic_id={pageOffset}");

                if (string.IsNullOrEmpty(response))
                    return (false, null);

                var result = new BiliUserDynamicsInfo(response);

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
        public static async Task<(bool success, DynamicType? type, IBiliDynamicCardInfo? cardData)> GetUserDynamic(
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
        }
        /// <summary>
        /// 从服务器获取最新一个动态数据
        /// </summary>
        /// <param name="uid">用户ID</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, DynamicType? type, IBiliDynamicCardInfo? cardData)> GetUserLatestDynamic(long uid)
        {
            (var success, var result) = await GetDynamics(uid);
            if (success)
                return (success, result?.Cards.FirstOrDefault()?.Type, result?.Cards.FirstOrDefault());
            else
                return (false, DynamicType.Error, null);
        }
        /// <summary>
        /// 从服务器获取指定动态数据
        /// </summary>
        /// <param name="dynamicID">动态ID</param>
        /// <returns>
        /// 是否成功及动态信息
        /// </returns>
        public static async Task<(bool success, DynamicType? type, IBiliDynamicCardInfo? cardData)> GetUserDynamic(
            long dynamicID)
        {
            if (dynamicID < 0)
                throw new ArgumentOutOfRangeException(nameof(dynamicID));
            try
            {
                var response = await Utils.RequestStringAsync($"{dynamicID}?dynamic_id={dynamicID}");

                if (string.IsNullOrEmpty(response))
                    return (false, DynamicType.Error, null);

                var root = Utils.Deserialize<BiliRoot<BiliDynamicCardContainer>>(response);
                if (root?.code != 0)
                    return (false, DynamicType.Error, null);

                var result = BiliUserDynamicsInfo.Get(root!.data);
                return (true, result!.Type, result);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] {ex}");
                return (false, DynamicType.Error, null);
            }
        }
    }
}
