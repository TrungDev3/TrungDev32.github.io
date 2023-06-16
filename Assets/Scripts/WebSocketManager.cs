//using System.Collections;
//using System.Collections.Generic;
//using System.Net.WebSockets;
//using UnityEngine;
//using WebSocketSharp.Net;

//public class WebSocketManager : MonoBehaviour
//{
//    private WebSocket socket;

//    private void Start()
//    {
//        // Kh?i t?o k?t n?i WebSocket
//        socket = new WebSocket("http://nftcards.ddns.net:3000/");

//        // X? l� s? ki?n khi k?t n?i ???c thi?t l?p
//        socket.OnOpen += OnWebSocketOpen;

//        // X? l� s? ki?n khi nh?n d? li?u t? trang web
//        socket.OnMessage += OnWebSocketMessage;

//        // K?t n?i WebSocket
//        socket.Connect();
//    }

//    private void OnWebSocketOpen(object sender, System.EventArgs e)
//    {
//        Debug.Log("K?t n?i WebSocket ?� ???c thi?t l?p.");
//    }

//    private void OnWebSocketMessage(object sender, MessageEventArgs e)
//    {
//        string message = e.Data;
//        // X? l� d? li?u nh?n ???c t? trang web
//        // ...
//    }

//    // H�m g?i d? li?u t? Unity ??n trang web
//    private void SendDataToWeb(string data)
//    {
//        socket.Send(data);
//    }

//    private void OnDestroy()
//    {
//        // ?�ng k?t n?i WebSocket khi ??i t??ng b? h?y
//        if (socket != null && socket.IsAlive)
//        {
//            socket.Close();
//        }
//    }

//}
