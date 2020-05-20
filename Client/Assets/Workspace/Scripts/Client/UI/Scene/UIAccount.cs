using ENet;
using System;
using UnityEngine;
using UnityEngine.UI;

namespace Valk.Networking {
    public class UIAccount : MonoBehaviour {
        public GameObject goChatInput;
        private InputField chatInput;

        private void Start() {
            chatInput = goChatInput.GetComponent<InputField>();
        }

        public void SendChat(){
            if (string.IsNullOrEmpty(chatInput.text)) return;
            ENetNetwork.Send(PacketType.ClientSendChatMessage, PacketFlags.Reliable, ENetClient.myName, chatInput.text);
            chatInput.text = "";
        }
    }
}