using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    public List<Player> players = new List<Player>();

    // Biến instance để lưu trữ thể hiện duy nhất của lớp PlayerManager
    // Biến players để lưu trữ danh sách các đối tượng Player

    void Awake()
    {
        // Gán thể hiện của PlayerManager cho biến instance khi đối tượng được khởi tạo
        instance = this;
    }

    private void Start()
    {
        UIManager.instance.UpdateValues(players[0], players[1]);
    }

    // Gán lượt chơi cho người chơi hiện tại dựa trên currentPlayerTurn
    internal void AssignTurn(int currentPlayerTurn)
    {
       // lặp qua danh sách các đối tượng player
        foreach (Player player in players)
        {
            // thiết lập giá trị thuộc tính myturn của player dựa trên currentplayerturn
            player.myTurn = player.ID == currentPlayerTurn;
            if (player.myTurn) player.mana = 5;
        }
        // FindPlayerByID(currentPlayerTurn).myTurn = true;
    }

    public void DamagePlayer( int ID, int damage)
    {
        Player player = FindPlayerByID(ID);
        FindPlayerByID(ID).health -= damage;
        if (player.health <- 0)
        {
            PlayerLost(ID);
        }    
    }    

    private void PlayerLost(int ID)
    {
        UIManager.instance.GameFinished(ID == 0 ? FindPlayerByID(1) : FindPlayerByID(0));
    }    

    // Tìm người chơi dựa trên ID
    public Player FindPlayerByID(int ID)
    {
        Player foundPlayer = null;
        // Lặp qua danh sách các đối tượng Player
        foreach (Player player in players)
        {
            // Kiểm tra nếu ID của Player trùng khớp với ID được tìm kiếm
            
            
                // Gán đối tượng Player được tìm thấy vào biến foundPlayer
                foundPlayer = player;
                // Thoát khỏi vòng lặp khi tìm thấy người chơi
                
            
        }
        // Trả về đối tượng Player được tìm thấy (hoặc giá trị null nếu không tìm thấy)
        return foundPlayer;
    }




}
