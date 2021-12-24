![Nuget](https://img.shields.io/nuget/v/BiliAPI?style=flat-square)  ![GitHub Workflow Status](https://img.shields.io/github/workflow/status/Megghy/BiliAPI/.NET?style=flat-square)
> 封装了一些不包含账户操作的基础api.
> 封装未全部完成, API实体类已完成

主要是自用, 所以写的比较简单而且用不上的大概不会写

部分信息参考于 [哔哩哔哩-API收集整理](https://github.com/SocialSisterYi/bilibili-API-collect)

## 简单示例

```csharp
    (var success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(10021741);
    var name = userData?.Name; //-Megghy
    //userData(IBiliDataInfo)提供了部分封装好的信息, 所有原始字段都保存在userData.Data里, 响应信息为userData.Root
```

<details>
    <summary>目前支持的API</summary>

    动态(转发动态, 视频动态, H5动态, 文字动态, 专栏动态, 图片动态, 音频动态
    
    用户发布的视频
    
    用户基本信息(勋章, 大会员, 直播间等
    
    查看视频信息
</details>
