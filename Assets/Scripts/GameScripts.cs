using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScripts : MonoBehaviour
{
    public GameDataSender gameDataSender; // Tham chiếu đến script GameDataSender

    private void Start()
    {
        // Gửi dữ liệu từ game tới ThirdWeb
        string gameData = "Sample game data";
        gameDataSender.SendGameData(gameData);
    }

}
