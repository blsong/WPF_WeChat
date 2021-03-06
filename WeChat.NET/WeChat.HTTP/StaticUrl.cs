﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeChat.Tools.Helpers;

namespace WeChat.HTTP
{
    /// <summary>
    /// 所有的Url
    /// </summary>
    public class StaticUrl
    {
        /// <summary>
        /// 获取会话的UUID
        /// </summary>
        public const string Url_GetUUID = "https://login.wx.qq.com/jslogin?appid=wx782c26e4c19acffb&fun=new&lang=zh_CN&_=";
        /// <summary>
        /// 获取二维码的URL
        /// </summary>
        public const string Url_GetQrCode = "https://login.weixin.qq.com/qrcode/";
        /// <summary>
        /// 等待扫码登陆
        /// </summary>
        public const string Url_WaitLogin = "https://login.weixin.qq.com/cgi-bin/mmwebwx-bin/login?loginicon=true&uuid=";
        /// <summary>
        /// 微信初始化
        /// </summary>
        public const string Url_Init = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxinit?r=";
        /// <summary>
        /// 开启微信状态通知
        /// </summary>
        public const string Url_StatusNotify = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxstatusnotify?lang=zh_CN&pass_ticket=";
        /// <summary>
        /// 获取好友列表
        /// </summary>
        public const string Url_GetContact = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgetcontact";
        /// <summary>
        /// 获取群组列表
        /// </summary>
        public const string Url_GetGroupContact = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxbatchgetcontact?type=ex";
        /// <summary>
        /// 消息检查
        /// </summary>
        public const string Url_SyncCheck = "https://webpush.weixin.qq.com/cgi-bin/mmwebwx-bin/synccheck?";
        /// <summary>
        /// 获取最新消息
        /// </summary>
        public const string Url_Sync = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsync?";
        /// <summary>
        /// 发送消息
        /// </summary>
        public const string Url_SendMsg = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxsendmsg?lang=zh_CN&sid=";
        /// <summary>
        /// 获取好友头像
        /// </summary>
        public const string Url_GetIcon = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgeticon?username=";
        /// <summary>
        /// 获取群组头像
        /// </summary>
        public const string Url_GetHeadImg = "https://wx.qq.com/cgi-bin/mmwebwx-bin/webwxgetheadimg?username=";
        /// <summary>
        /// 获取登录参数--拼接部分
        /// </summary>
        public const string Url_redirect_ext = "&fun=new&version=v2&lang=zh_CN";
        /// <summary>
        /// 同步检查扩展部分
        /// </summary>
        public static string Url_SyncCheck_ext = "sid={0}&uin={1}&synckey={2}&r={3}&skey={4}&deviceid={5}&_=";
        /// <summary>
        /// 同步扩展部分
        /// </summary>
        public static string Url_Sync_ext = "sid={0}&lang=zh_CN&skey={1}&pass_ticket={2}";
    }
}
