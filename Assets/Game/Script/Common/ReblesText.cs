using System;
using System.Collections;
using System.Collections.Generic;
using Game.Manager.Message;
using UnityEngine;
using UnityEngine.UI;

public class ReblesText : MonoBehaviour
{
    public Text Text;
    public Message _Message;

    public void Awake()
    {
        if (Text == null)
        {
            Text = this.GetComponent<Text>();
            if (Text == null)
            {
                this.gameObject.AddComponent<Text>();
                Text = this.GetComponent<Text>();
            }
        }

        if (Text != null)
        {
            Text.text = MessageManager.I.GetMessage(_Message);
        }
    }

    public void SetMessageType(Message set_message)
    {
        _Message = set_message;
        Reset();
    }

    public void Reset()
    {
        if (Text != null)
        {
            Text.text = MessageManager.I.GetMessage(_Message);
        }
    }
}