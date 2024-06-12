using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Colyseus;
using UnityEngine;

public class NetworkManagerTest : MonoBehaviour
{
     public static NetworkManagerTest Instance { get; private set; }

        private string hostAddress;
        private string roomName;

        private ColyseusClient client = null;
        public ColyseusClient Client
        {
            get
            {
                if (client == null)
                {
                    if (string.IsNullOrEmpty(hostAddress) || string.IsNullOrEmpty(roomName))
                    {
                        hostAddress = "ws://localhost:2567";
                        roomName = "blackjack21";
                    }

                    // Debug.LogWarning("Client hasn't been initialized yet! Initializing with default values.");
                    Initialize(hostAddress, roomName);
                }

                return client;
            }
        }

        private ColyseusRoom<Table> roomState = null;
        public ColyseusRoom<Table> GameRoom
        {
            get
            {
                if (roomState == null)
                {
                    Debug.LogError("Room hasn't been initialized yet!");
                }

                return roomState;
            }
        }

        public void Awake()
        {
            if (Instance == null)
                Instance = this;
            else
                Destroy(this);
        }

        public void Initialize(string hostAddress, string roomName)
        {
            this.hostAddress = hostAddress;
            this.roomName = roomName;

            client = new ColyseusClient(hostAddress);
        }

        public async Task JoinTableID(string tableID, Dictionary<string, object> option = null)
        {
            roomState = await Client.JoinById<Table>(tableID, option);
        }
}
