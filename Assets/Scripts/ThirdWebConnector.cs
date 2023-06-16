using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class ThirdWebConnector : MonoBehaviour
{

    private string apiUrl = "http://42.116.145.238:3000/myPacks";

    public void SendDataToThirdWeb(string data)
    {
        StartCoroutine(PostData(data));
    }

    IEnumerator PostData(string data)
    {
        using (UnityWebRequest request = UnityWebRequest.PostWwwForm(apiUrl, data))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                Debug.Log("Data sent successfully");
            }
            else
            {
                Debug.LogError("Error sending data: " + request.error);
            }
        }
    }
}
