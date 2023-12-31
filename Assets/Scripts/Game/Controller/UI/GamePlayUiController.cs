using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GamePlayUiController : MonoBehaviour
{
    public static GamePlayUiController instance;
    public TextMeshProUGUI currentPlayerTurn;
    public Button endTurn;

    private void Awake()
    {
        instance = this;
        SetupButton();
    }

    private void SetupButton()
    {
        endTurn.onClick.AddListener(() =>
        {
            TurnManager.instance.EndTurn();
        });
    }

    public void UpdateCurrentPlayerTurn(int ID)
    {
        currentPlayerTurn.gameObject.SetActive(true);
        currentPlayerTurn.text = $"Player{ID + 1}'s Turn!";

        StartCoroutine(BlinkCurrentPlayerTurn());

    }

    private IEnumerator BlinkCurrentPlayerTurn()
    {
        yield return new WaitForSeconds(0.5f);
        currentPlayerTurn.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        currentPlayerTurn.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        currentPlayerTurn.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        currentPlayerTurn.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        currentPlayerTurn.gameObject.SetActive(false);

    }
}
