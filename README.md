# はじめに
[NLog](https://nlog-project.org/)の[チュートリアル](https://nlog-project.org/download/)をやってみました。
+ [.NET framework](https://github.com/NLog/NLog/wiki/Tutorial)
+ [ASP.NET Core](https://github.com/NLog/NLog/wiki/Getting-started-with-ASP.NET-Core-6)
+ [.NET Core Console application](https://github.com/NLog/NLog/wiki/Getting-started-with-.NET-Core-2---Console-application)

# 環境
+ Windows 10 64bit
+ Visual Studio Community 2022

# 構成
```text
/
├─ ConsoleAppDotNet
├─ ConsoleAppNetFramework
├─ WebApplication
└─ Logging.sln
```

| チュートリアル | プロジェクトテンプレート | フレームワーク | フォルダ名（プロジェクト名）|
| --- | --- | --- | --- |
| .NET framework | コンソールアプリ（.NET Framework）| .NET Framework 4.8 | ConsoleAppNetFramework |
| ASP.NET Core | ASP.NET Core Web API | .NET 7.0 | WebApplication |
| .NET Core Console application | コンソールアプリ | .NET 7.0 | ConsoleAppDotNet |
