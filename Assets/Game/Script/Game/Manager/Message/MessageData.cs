using UnityEngine;

namespace Game.Manager.Message
{
    public class MessageData : ScriptableObject
    {
        [SerializeField] private string[] messageDataStrings;
        public int messageLength
        {
            get { return messageDataStrings.Length; }
        }
#if UNITY_EDITOR
        public string[] MessageDataStrings
        {
            get => messageDataStrings;
            set => messageDataStrings = value;
        }
#endif
        public string GetMessageIndex(int index)
        {
            return messageDataStrings[index];
        }
    }
}