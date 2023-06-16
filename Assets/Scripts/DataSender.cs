using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DataSender : MonoBehaviour
{
    //private ThirdWebConnector thirdWebConnector;
    //public DataSender instance;

    //public void Awake()
    //{
    //    instance = this;
    //    thirdWebConnector = GetComponent<ThirdWebConnector>();
    //}

    //public void SendDataToThirdWeb(string data)
    //{
    //    thirdWebConnector.SendDataToThirdWeb(data);
    //}    

    private string apiUrl = "https://thirdweb.com/"; // Đường dẫn API của ThirdWeb

    public void SendDataToThirdWeb(string data)
    {
        StartCoroutine(SendData(data));
    }

    IEnumerator SendData(string data)
    {
        if (string.IsNullOrEmpty(data))
        {
            Debug.LogError("Data is empty!");
            yield break;
        }

        WWWForm form = new WWWForm();
        form.AddField("data", data);

        using (UnityWebRequest request = UnityWebRequest.Post(apiUrl, form))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)      
            {
                Debug.Log("Data sent to ThirdWeb successfully!"); 
            }             
            else
            {
                Debug.LogError("Error sending data to ThirdWeb: " + request.error);
            }
        }
    }
}
      