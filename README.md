# Baidu.SDK.Push(百度推送SDK C#版本) #

百度推送C#版本SDK，包括了公开 REST API 的所有功能。
限于开发资源等原因，IOS相关API未作测试。

基本功能，如推送消息，TAG相关已在生产环境部署使用。

## Usage ##

### Configuration ###

在Console或者Winform程序中，添加或者修改您的App.config文件，添加或者修改如下配置节，
在Web项目中，在Web.config文件中，添加或者修改如下配置节：

	<appSettings>
		<add key="ApiKey" value="百度推送中对应应用分配的APIKey"/>
		<add key="SecretKey" value="百度推送中对应应用分配的SecretKey"/>
	</appSettings>

### Promgrame ###

	using System.Configuration;
	using Baidu.SDK.Push;
	using Baidu.SDK.Push.Dto;

	namespace YourNameSpace
	{
		public class YourClass
		{
			// Read APIKey and SecretKey from config file, you can store them by other method
			// 从配置文件中读取APIKey以及SecretKey，也可以根据项目需要使用其他方式存储
			private readonly string _apiKey = ConfigurationManager.AppSettings["ApiKey"];
			private readonly string _secretKey = ConfigurationManager.AppSettings["SecretKey"];

			public void YourMethod()
			{
				var messageList = new List<string>
				{
					Guid.NewGuid().ToString()
				};
				var messageKeyList = new List<string>
				{
					Guid.NewGuid().ToString()
				};
				var request = new MessagePushBroadcastRequest(
                DeviceTypes.Android,
                MessageTypes.Message,
                messageList,
                messageKeyList
                );
				
				var pushService = new Client(_apiKey, _secretKey);
				var response = pushService.PushMessageBroadcast(request);
			}
		}
	}

## Installation ##

### Use Source Code ###

编译Baidu.SDK.Push\Baidu.SDK.Push.csproj文件，在项目中使用生成的文件。

### Use Nuget ### 

先检查是否安装了 NUGET程序包管理器 扩展，如果未安装，请先安装。

项目上右击，点击 项目的管理Nuget程序包(N) 菜单，进入联机，搜索 Baidu.SDK.Push，安装找到的Nuget包。

## Requirements ##

.Net Framework 3.5

## Running the Tests ##

测试使用NUnit 2.6.2，可以根据自己的喜好，使用支持NUnit的 Runner。

NUnit Test Adapter(Visual Studio 2012)

TestDriven.NET

JetBrain ReSharper

nunit-console

nunit runner 等


## Contributing ##

Shi JIyong(SHIJIYONG@HOTMAIL.COM) © Best Logistic

## Credits ##

Json.Net by James Newton-King 

NUnit by NUnit Team

## License ##
[LicenseDetail](https://github.com/JiyongShi/Baidu.SDK.Push/blob/master/LICENSE)

## Donate ##
[DonateDetail](https://github.com/JiyongShi/Baidu.SDK.Push/blob/master/Donations.md)