// See https://aka.ms/new-console-template for more information
using BiliAPI;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

JsonSerializerOptions jsonOption = new()
{
    PropertyNameCaseInsensitive = true,
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
    WriteIndented = true,
};
Console.WriteLine("用户信息测试");
(var success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(userData!, jsonOption));
else
    Console.WriteLine("用户信息获取失败");

Console.WriteLine("动态测试");
(success, var dynamicData) = await BiliAPI.BiliDynamic.DynamicAPI.GetDynamic(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(dynamicData!, jsonOption));
else
    Console.WriteLine("动态信息获取失败");

Console.WriteLine("视频列表测试");
(success, var videosData) = await BiliAPI.BiliVideo.VideoAPI.GetUserVideoData(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(videosData!, jsonOption));
else
    Console.WriteLine("视频信息获取失败");

