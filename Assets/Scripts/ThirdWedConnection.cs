//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Thirdweb;

//public class ThirdWedConnection : MonoBehaviour
//{

//    private ThirdwedClient client; // đối tượng client từ sdk
//    private void Start()
//    {
//        // Tạo đối tượng client
//        client = new ThirdwebClient();

//        // Thiết lập thông tin xác thực
//        string apiKey = "a941220cb9f8128a9b68b8ab1aed5e93ff58f93c2e97807c6f18349dc2d47ae64e2d8cd28ace24074d86d8604cef7ad6589da60c620d017cf045ae89612ae57c";
//        string accessToken = ThirdwebManager.Instance.SDK.GetAccessToken();
//        client.SetAuthentication(apiKey, accessToken);

//        // Kết nối tới Thirdweb
//        client.Connect();

//        // Kiểm tra kết nối thành công hay không
//        if (client.IsConnected)
//        {
//            Debug.Log("Kết nối thành công với Thirdweb");
//        }
//        else
//        {
//            Debug.Log("Kết nối thất bại với Thirdweb");
//        }
//    }
//}

