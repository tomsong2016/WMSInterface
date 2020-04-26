# WMSInterface
WMS与SAP接口，技术比较菜，想写个小工具能检查接口数据报错原因是否有自动处理模式

|         序号        | 主要模块                  |
| ------------------- | --------------------------|
|    1                | Mlily.WMSInterfacer.Core  |
|    2                | Mlily.WMSInterface.Test   |
|    3                | Mlily.Framework.Utils     |

## 目前主要问题
|         序号  | 主要问题                               | 解决方法                 |
| ------------- | ---------------------------------------|--------------------------|
|    1          | 如何不使用构造函数注入方法调用接口     |还没想好                  |
|    2          | Mapper                                 |还没想好                  |
|    3          | ORM(打算使用EF)                        |还没想好                  |
|    4          | XML大小写问题                          |还没想好                  |
|    5          | XML特殊字符                            |还没想好                  |
|    6          | Json序列化                             |还没想好                  |
|    7          | Jwt                                    |还没想好                  |
|    8          | 验证/日志                              |还没想好                  |

## 构思

* 通过SAP推送过来XML格式Request->字符实体->处理实体->返回Response实体->转化XML字符串

* 通过Json推送过来Json格式Request->字符实体->处理实体->返回Response实体->转化Json字符串


## 运行环境
* .NET Framework ( [.NET Standard 2.0](https://docs.microsoft.com/en-us/dotnet/standard/net-standard) or higher ) 
  -  .NET Core 2.0 or higher



## 字段对照表

|         序号  | SAP字段                                | Model字段                 |描述                      |
| ------------- | ---------------------------------------|---------------------------|--------------------------|
|    1          | MATNR                                  |MaterielCoding             |物料编码                  |
|    2          | MATKL                                  |MaterielType               |物料类型                  |
|    2          | MATKL                                  |MaterielType               |物料类型                  |
|    3          | MAKTX                                  |MaterielName               |物料名称                  
|    4          | XML大小写问题                          |还没想好                   |
|    5          | XML特殊字符                            |还没想好                   |
|    6          | Json序列化                             |还没想好                   |
|    7          | Jwt                                    |还没想好                   |
|    8          | 验证/日志                              |还没想好                   |