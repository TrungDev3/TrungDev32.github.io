using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataSender : MonoBehaviour
{
    public DataSender dataSender; // Tham chiếu đến script DataSender

    public void SendGameData(string gameData)
    {
        if (string.IsNullOrEmpty(gameData))
        {
            Debug.LogError("GameData is empty!");
            return;
        }

        dataSender.SendDataToThirdWeb(gameData); // Gửi dữ liệu tới DataSender
    }
}
