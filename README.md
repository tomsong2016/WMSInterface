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
|    1          | 如何不使用构造函数注入方法调用接口     |ServiceLocator            |
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
|    3          | MAKTX                                  |MaterielName               |物料名称                  |
|    4          | SPRAS                                  |Language                   |语言编码                  |             
|    5          | MEINS                                  |UnitMeasurement            |计量单位                  |
|    6          | GEWEI                                  |WeightUnit                 |重量单位                  |
|    7          | WGBEZ                                  |MaterielTypeName           |物料类型名称              |
|    8          | WERKS                                  |FactoryCoding              |工厂编码                  |
|    9          | LGORT                                  |StockLocationCoding        |库存地点编码              |
|    10         | LGOBE                                  |StockLocationName          |库存地点名称              |
|    11         | BUKRS                                  |CompanyCoding              |公司代码                  |
|    12         | KOSTL                                  |CostCenter                 |成本中心                  |
|    13         | LTEXT                                  |CostCenterName             |成本中心名称              |
|    14         | VBELN                                  |DeliveryOrderCoding        |交货单                    |
|    15         | POSNR                                  |DeliveryOrderRow           |行号                      |
|    16         | LFIMG                                  |Quantity                   |交货量                    |
|    17         | VSTEL                                  |ShippingOrReceivingPoint   |装运点/接收点             |
|    18         | VTWEG                                  |DistributionChannel        |分销渠道                  |
|    19         | VKORG                                  |SalesOrganization          |销售组织                  |
|    20         | KUNNR                                  |SupplierCoding             |客户编号                  |
|    21         | SPART                                  |ProductGroup               |产品组                    |
|    22         | EBELN                                  |POCoding                   |采购凭证编号              |
|    23         | EBELP                                  |PORow                      |采购凭证的项目编号        |
|    24         | BSTYP                                  |POCategory                 |采购凭证类别              |
|    25         | BSART                                  |POType                     |采购凭证类型              |
|    26         | AEDAT                                  |CreteTimeValue             |记录建立日期              |
|    27         | ERNAM                                  |CreateUser                 |创建对象的人员名称        |
|    28         | WAERS                                  |CurrencyCoding             |货币码                    |
|    29         | LIFNR                                  |SupplierCoding             |供应商编号                |
|    30         | NAME1                                  |Supplier                   |供应商名称                |
|    31         | EKORG                                  |POOrganization             |采购组织                  |
|    32         | EKGRP                                  |POGroup                    |采购组                    |
|    33         | PSTYP                                  |PORowType                  |采购凭证中的项目类别      |
|    34         | VBELN                                  |SaleCoding                 |销售和分销凭证号          |
|    35         | VBELP                                  |SaleRow                    |销售单据项目              |








## SAP表
* MAKT	物料描述
  -	MATNR	MATNR	CHAR	18	0	物料号
  -	SPRAS	SPRAS	LANG	1	0	语言代码
  -	MAKTX	MAKTX	CHAR	40	0	物料描述（短文本）

* MKPF	抬头：物料凭证
  -	MBLNR	MBLNR	CHAR	10	0	物料凭证编号
  -	MJAHR	MJAHR	NUMC	4	0	物料凭证年度
  -	USNAM	USNAM	CHAR	12	0	用户名

* T001	公司代码
  -	BUKRS	BUKRS	CHAR	4	0	公司代码
  -	BUTXT	BUTXT	CHAR	25	0	公司代码或公司的名称
  -	SPRAS	SPRAS	LANG	1	0	语言代码

* RKPF	凭证头：预订
  -	RSNUM	RSNUM	NUMC	10	0	预留/相关需求的编号
  -	KOSTL	KOSTL	CHAR	10	0	成本中心
  -	PARBU	PARBU	CHAR	4	0	结算公司代码

* RESB	预定/相关需求
  -	RSNUM	RSNUM	NUMC	10	0	预留/相关需求的编号
  -	RSPOS	RSPOS	NUMC	4	0	预留/相关需求的项目编号
  -	RSART	RSART	CHAR	1	0	记录类型
  -	MATNR	MATNR	CHAR	18	0	物料号
  -	WERKS	WERKS_D	CHAR	4	0	工厂
  -	LGORT	LGORT_D	CHAR	4	0	库存地点
  -	BDMNG	BDMNG	QUAN	13	3	需求量
  -	MEINS	MEINS	UNIT	3	0	基本计量单位
  -	BWART	BWART	CHAR	3	0	移动类型（库存管理）

* MARD	物料的仓储位置数据
  -	MATNR	MATNR	CHAR	18	0	物料号
  -	WERKS	WERKS_D	CHAR	4	0	工厂
  -	LGORT	LGORT_D	CHAR	4	0	库存地点
  -	LABST	LABST	QUAN	13	3	非限制使用的估价的库存

* EBAN	采购申请
  -	BANFN	BANFN	CHAR	10	0	采购申请编号
  -	BNFPO	BNFPO	NUMC	5	0	采购申请的项目编号
  -	AFNAM	AFNAM	CHAR	12	0	需求者/请求者姓名
  -	MATNR	MATNR	CHAR	18	0	物料号
  -	WERKS	EWERK	CHAR	4	0	工厂
  -	LGORT	LGORT_D	CHAR	4	0	库存地点
  -	MATKL	MATKL	CHAR	9	0	物料组
  -	MENGE	BAMNG	QUAN	13	3	采购申请数量
  -	MEINS	BAMEI	UNIT	3	0	采购申请计量单位
	SPRAS	SPRAS	LANG	1	0	语言代码

* T001K	评估范围
  -	BWKEY	BWKEY	CHAR	4	0	评估范围
  -	BUKRS	BUKRS	CHAR	4	0	公司代码

* EKPO	采购凭证项目
  -	EBELN	EBELN	CHAR	10	0	采购凭证号
  -	EBELP	EBELP	NUMC	5	0	采购凭证的项目编号
  -	MATNR	MATNR	CHAR	18	0	物料号
  -	BUKRS	BUKRS	CHAR	4	0	公司代码
  -	WERKS	EWERK	CHAR	4	0	工厂
  -	LGORT	LGORT_D	CHAR	4	0	库存地点
  -	MATKL	MATKL	CHAR	9	0	物料组
  -	MENGE	BSTMG	QUAN	13	3	采购订单数量
  -	MEINS	BSTME	UNIT	3	0	采购订单的计量单位
  -	PSTYP	PSTYP	CHAR	1	0	采购凭证中的项目类别
  -	KOLIF	KOLIF	CHAR	10	0	原始供应商
  -	AFNAM	AFNAM	CHAR	12	0	需求者/请求者姓名

* T163Y	项目类型文本
  -	SPRAS	SPRAS	LANG	1	0	语言代码
  -	PSTYP	PSTYP	CHAR	1	0	采购凭证中的项目类别
  -	EPSTP	EPSTP	CHAR	1	0	采购凭证中的项目类别

* LFA1	供应商主数据 (一般地区)
  -	LIFNR	LIFNR	CHAR	10	0	供应商或债权人的帐号
  -	NAME1	NAME1_GPCHAR	35	0	名称 1
	NAME2	NAME2_GPCHAR	35	0	名称 2

* USR21	分配用户名称地址码
  -	BNAME		XUBNAME		CHAR	12	0	用户主记录中的用户名称
  -	PERSNUMBER	AD_PERSNUM	CHAR	10	0	人员编号

* ADRP	个人（办公地址管理）
  -	PERSNUMBER	AD_PERSNUM	CHAR	10	0	人员编号
  -	DATE_FROM	AD_DATE_FR	DATS	8	0	有效起始日期 - 当前版本中仅00010101可用
  -	NAME_FIRST	AD_NAMEFIR	CHAR	40	0	名
  -	NAME_LAST	AD_NAMELAS	CHAR	40	0	姓
  -	NAME_TEXT	AD_NAMTEXT	CHAR	80	0	完整的人员名称