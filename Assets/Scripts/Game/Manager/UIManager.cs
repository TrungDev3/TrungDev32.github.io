using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    
    public static UIManager instance;
    public TextMeshProUGUI player0health, player1health, player0Mana, player1Mana;
    public GameEndUiController gameEndUI;
    private void Awake()
    {
        instance = this;
    }

    public void GameFinished(Player winner)
    {
        gameEndUI.gameObject.SetActive(true);
        gameEndUI.Initialized(winner);
    }    
    public void UpdateValues( Player player0, Player player1)
    {
        UpdateHealthValues(player0.health, player1.health);
        UpdateManaValues(player0.mana, player1.mana);
    } 
    
    public void UpdateHealthValues(int player0Health, int player1Health)
    {
        this.player0health.text = player0Health.ToString();
        this.player1health.text = player1Health.ToString();
    }    

    public void UpdateManaValues( int player0Mana, int player1Mana)
    {
        this.player0Mana.text = player0Mana.ToString();
        this.player1Mana.text = player1Mana.ToString();
    }    

}
