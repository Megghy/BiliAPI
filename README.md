> 封装了一些不包含账户操作的基础api

主要是自用, 所以写的比较简单而且用不上的大概不会写

有时间大概会稍微写一下注释

部分信息参考于 [哔哩哔哩-API收集整理](https://github.com/SocialSisterYi/bilibili-API-collect)

## 简单示例

```csharp
    (var success, var userData) = await BiliAPI.BiliUser.UserAPI.GetUserData(10021741);
    var name = userData?.Name; //-Megghy
```

<details>
    <summary>目前支持的API</summary>

    动态(转发动态, 视频动态, H5动态
    
    用户发布的视频
    
    用户基本信息
</details>
