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
BiliAPI.Settings.Cookie = "buvid3=3498F762-B175-6C76-3978-0229142EC06E14237infoc; i-wanna-go-back=-1; _uuid=347E10A10D-D510C-7B28-B236-FCD3D712567815183infoc; buvid4=F96CF089-98EC-C5D0-636A-76288595A3CB16098-022033109-Y1y8jaXyNHIvA49lqDdBsw%3D%3D; CURRENT_BLACKGAP=0; buvid_fp_plain=undefined; LIVE_BUVID=AUTO7516486904960846; blackside_state=0; rpdid=|(J~J|~u|)|m0J'uYR)YmukJl; b_ut=5; hit-dyn-v2=1; nostalgia_conf=-1; is-2022-channel=1; dy_spec_agreed=1; fingerprint3=16e00b8724d6a2afe3184847845504d1; DedeUserID=10021741; DedeUserID__ckMd5=943be2cef501cf2a; Hm_lvt_8a6e55dbd2870f0f5bc9194cddf32a02=1651486963; fingerprint=56adb50c75d6d4be318aa94f1c6c9ed6; buvid_fp=56adb50c75d6d4be318aa94f1c6c9ed6; CURRENT_QUALITY=120; b_nut=100; SESSDATA=bd9bfb02%2C1679225688%2Cdddef%2A91; bili_jct=5f21f6a05c1b65c733c9c0d493371826; sid=5q22eai3; theme_style=light; innersign=1; CURRENT_FNVAL=4048; b_lsid=3E2C175F_183607D73FD; bp_t_offset_10021741=708381914233307143; PVID=5";
Console.WriteLine("用户信息获取测试");
(var success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(10021741);
if (success)
    Console.WriteLine(Utils.Serialize(userData!, jsonOption));
else
    Console.WriteLine("用户信息获取失败");

Console.WriteLine("动态获取测试");
(success, var dynamicData) = await BiliAPI.BiliDynamic.DynamicAPI.GetDynamics(15987952);
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
(success, var dynamicType, var singleDynamicData) = await BiliAPI.BiliDynamic.DynamicAPI.GetSingleDynamic(619601671568361450);
if (success)
{
    Console.WriteLine(dynamicType);
    Console.WriteLine(Utils.Serialize(singleDynamicData!, jsonOption));
}
else
    Console.WriteLine("单条动态信息获取失败");

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

