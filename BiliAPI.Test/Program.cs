JsonSerializerOptions jsonOption = new()
{
    PropertyNameCaseInsensitive = true,
    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
    WriteIndented = true,
};

Settings.Cookie = "";

Console.WriteLine("动态V2获取测试");
(var success, var dynamicV2Data) = await BiliAPI.BiliDynamicV2.DynamicV2API.GetDynamics(10021741);
if (success)
{
    foreach (var d in dynamicV2Data!.Data.items)
    {
        if (d is null)
            continue;
        Console.WriteLine(d.type);
        Console.WriteLine($"--- {d.modules.module_dynamic.major?.type}");
        Console.WriteLine(Utils.Serialize(d, jsonOption));
    }
}
else
    Console.WriteLine("动态信息获取失败");

Console.WriteLine("视频信息获取测试");
(success, var message, var videoData) = await BiliAPI.BiliVideo.VideoAPI.GetVideoData("BV1fy4y1B7yQ");
if (success)
    Console.WriteLine(Utils.Serialize(videoData!, jsonOption));
else
    Console.WriteLine("视频信息获取失败");

Console.WriteLine("动态V2Single获取测试");
(success, var type, var dynamicV2SingleData) = await BiliAPI.BiliDynamicV2.DynamicV2API.GetSingleDynamic(849234378697474054);

Console.WriteLine(type);
if (success)
{
    Console.WriteLine($"--- {dynamicV2SingleData.item?.modules.module_dynamic.major?.type}");
    Console.WriteLine(Utils.Serialize(dynamicV2SingleData, jsonOption));
}
else
    Console.WriteLine("动态信息获取失败");
Console.WriteLine("用户信息获取测试");
(success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(1351379);
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

