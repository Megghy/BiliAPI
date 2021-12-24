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
Console.WriteLine("用户信息获取测试");
(var success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(userData!, jsonOption));
else
    Console.WriteLine("用户信息获取失败");

Console.WriteLine("动态获取测试");
(success, var dynamicData) = await BiliAPI.BiliDynamic.DynamicAPI.GetDynamics(10021741);
if (success)
{
    foreach (var d in dynamicData!.Cards)
    {
        if (d is null)
            continue;
        Console.WriteLine(d.Type);
        Console.WriteLine($"--- {d.CardContainer?.cardType}");
        Console.WriteLine(Utils.Serialize(d, jsonOption));
    }
}
else
    Console.WriteLine("动态信息获取失败");

Console.WriteLine("用户视频列表获取测试");
(success, var userVideosData) = await BiliAPI.BiliUser.UserAPI.GetUserVideoData(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(userVideosData!, jsonOption));
else
    Console.WriteLine("用户视频列表获取失败");

Console.WriteLine("视频信息获取测试");
(success, var videoData) = await BiliAPI.BiliVideo.VideoAPI.GetVideoData("BV1fy4y1B7yQ");
if (success)
    Console.WriteLine(Utils.Serialize(videoData!, jsonOption));
else
    Console.WriteLine("视频信息获取失败");

