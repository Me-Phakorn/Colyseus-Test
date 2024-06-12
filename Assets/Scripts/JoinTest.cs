using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoinTest : MonoBehaviour
{
    private async void Start()
    {
        NetworkManagerTest.Instance.Initialize("ws://localhost:2567", "blackjack21");
        await NetworkManagerTest.Instance.JoinTableID("P_1001", new Dictionary<string, object>{
                {"token","1770a57b31278e54b1279724e2d77159bbfff474"}
            });
    }
}
