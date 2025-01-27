﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace FrameWork.SDKManager
{
    public class SDKInterfaceDefine
    {
        public const string ModuleName   = "ModuleName";
        public const string FunctionName = "FunctionName";
        public const string ListenerName = "ListenerName";

        public const string SDKName  = "SDKName";
        public const string SDKIndex = "SDKIndex";
        public const string Tag = "Tag";

        public const string ParameterName_IsSuccess = "IsSuccess";
        public const string ParameterName_Error     = "Error";
        public const string ParameterName_Content   = "Content";

        public const string ModuleName_Init     = "Init";
        public const string ModuleName_Dispose  = "Dispose";
        public const string ModuleName_Debug    = "Debug";

        public const string ModuleName_Login    = "Login";
        public const string ModuleName_Pay      = "Pay";
        public const string ModuleName_AD       = "AD";
        public const string ModuleName_Log      = "Log";
        public const string ModuleName_Other    = "Other";
        public const string ModuleName_LifeCycle = "LifeCycle";

        //回调方法
        public const string FunctionName_OnError = "OnError";
        public const string FunctionName_OnLog   = "OnLog";

        public const string FunctionName_OnInit = "OnInit";
        public const string FunctionName_OnLogin = "OnLogin";
        public const string FunctionName_OnLogout = "OnLogout";
        public const string FunctionName_OnPay = "OnPay";
        public const string FunctionName_OnOther = "OnOther";

        //LifeCycle 相关参数
        public const string LifeCycle_FunctionName_OnApplicationQuit = "OnApplicationQuit";

        //Login相关参数
        public const string FunctionName_Logout = "Logout";

        public const string Login_ParameterName_Device = "Device";
        public const string Login_ParameterName_AccountId = "AccountId";
        public const string Login_ParameterName_loginPlatform = "loginPlatform";

        //Pay相关参数
        public const string Pay_ParameterName_GoodsID     = "GoodsID";
        public const string Pay_ParameterName_GoodsType   = "GoodsType";
        public const string Pay_ParameterName_Count       = "Count";
        public const string Pay_ParameterName_GoodsName   = "GoodsName";
        public const string Pay_ParameterName_CallBackUrl = "CallBackUrl";
        public const string Pay_ParameterName_CpOrderID   = "CpOrderID";//第三方支付ID
        public const string Pay_ParameterName_OrderID     = "OrderID";  //我们自己的支付ID
        public const string Pay_ParameterName_Price       = "Price";  //价格
        public const string Pay_ParameterName_Currency    = "Currency";  //货币
        public const string Pay_ParameterName_Payment     = "Payment";   //支付途径
        public const string Pay_ParameterName_Receipt     = "Receipt";   //支付回执

        public const string Pay_GoodsTypeEnum_ONCE_ONLY = "ONCE_ONLY";
        public const string Pay_GoodsTypeEnum_NORMAL    = "NORMAL";
        public const string Pay_GoodsTypeEnum_RIGHTS    = "RIGHTS";

        //AD相关参数

        //Log相关参数
        public const string Log_FunctionName_Login    = "LogLogin";
        public const string Log_FunctionName_LoginOut = "LogLoginOut";
        public const string Log_FunctionName_Event    = "LogEvent";
        public const string Log_FunctionName_LogPay   = "LogPay";
        public const string Log_FunctionName_LogPaySuccess = "LogPaySuccess";
        public const string Log_FunctionName_RewardVirtualCurrency = "LogRewardVirtualCurrency"; //奖励虚拟币
        public const string Log_FunctionName_PurchaseVirtualCurrency = "LogPurchaseVirtualCurrency";//消费虚拟币
        public const string Log_FunctionName_UseItem = "LogUseItem";//使用虚拟物品（通过虚拟币购买的）

        //Log Login相关
        public const string Log_ParameterName_AccountId = "AccountId";

        //Log VirtualCurrency相关
        public const string Log_ParameterName_RewardReason = "RewardReason";

        //Log Event相关
        public const string Log_ParameterName_EventID    = "EventID";
        public const string Log_ParameterName_EventLabel = "EventLabel";
        public const string Log_ParameterName_EventMap   = "EventMap";

        //Other相关参数
        public const string Other_FunctionName_Exit = "Exit";

        //Other -> 剪贴板
        public const string Other_FunctionName_CopyToClipboard = "CopyToClipboard";
        public const string Other_FunctionName_CopyFromClipboard = "CopyFromClipboard";
        public const string Other_ParameterName_Content = "Content";

        //Other -> 热更新安装包
        public const string Other_FunctionName_DownloadAPK = "DownloadAPK";
        public const string Other_FunctionName_GetAPKSize = "GetAPKSize";
        public const string Other_ParameterName_DownloadURL = "DownloadURL";
        public const string Other_ParameterName_Progress = "Progress";
        public const string Other_ParameterName_TotalProgress = "TotalProgress";
        public const string Other_ParameterName_Size = "Size";

        //Properties
        public const string FileName_ChannelProperties = "Channel";

        public const string PropertiesKey_IsLog = "IsLog";                           //是否输出日志
        public const string PropertiesKey_UpdateDownLoadPath = "UpdateDownLoadPath"; //热更新下载地址(最后没有斜线)
        public const string PropertiesKey_ChannelName = "ChannelName";               //渠道名称
        public const string PropertiesKey_StoreName   = "StoreName";                 //商店名称
        public const string PropertiesKey_LoginPlatform = "LoginPlatform";           //登录平台
        public const string PropertiesKey_NetworkID = "NetworkID";                   //服务器选择
    }
}
