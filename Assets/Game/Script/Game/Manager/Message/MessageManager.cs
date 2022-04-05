using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Script.Tools;
using Game.Manager.Message;
using Tools.Util;
using UnityEngine;

/// <summary>
/// 文字管理
/// </summary>
public class MessageManager : SingleMaoGuo<MessageManager>
{
    private MessageData MessageData { get; set; }

    /// <summary>
    /// 没有管理器物体时创建出来
    /// </summary>
    private void OnIsNullInstance()
    {
        DontDestroyOnLoad(this);
    }

    protected override void OnAwake()
    {
        OnIsNullInstance();
    }
    public void SetMessageData(MessageData _message)
    {
        MessageData = _message;
    }

    public string GetMessage(Message _message)
    {
        if (MessageData.messageLength > (int) _message) return MessageData.GetMessageIndex((int) _message);
        Debug.LogError("[Stop Message] 下标超出范围");
        return string.Empty;
    }

    public string GetMessage(Message _message, params object[] _os)
    {
        if (MessageData.messageLength > (int) _message)
        {
            return string.Format(MessageData.GetMessageIndex((int) _message), _os);
        }
        Debug.LogError("[Stop Message] 下标超出范围");
        return string.Empty;
    }
}