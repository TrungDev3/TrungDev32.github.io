//using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;
using System;

public class CardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public Card card;
    public Image image;
    public TextMeshProUGUI health, manaCost, damage;
    private  Transform originalParent;

    private void Awake()
    {
        // Khởi tạo image từ Component Image trên đối tượng hiện tại
        this.image = GetComponent<Image>();

    }

    private void Start()
    {
        // Không có mã code trong phương thức Start
    }

    // Khởi tạo thông tin cho CardController từ Card được truyền vào
    public void Initialized(Card card, int ownerID)
    {
        this.card = new Card(card)
        {
            ownerID = ownerID
    };
        // Hiển thị thông tin của card trên UI
        manaCost.text = card.manaCost.ToString();
        damage.text = card.damage.ToString();
        health.text = card.health.ToString();
        originalParent = transform.parent;
        if (card.health == 0) health.text = "";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Không có mã code trong phương thức OnPointerEnter
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Không có mã code trong phương thức OnPointerExit
    }

    public void OnPointerDown(PointerEventData eventData)
    {
         if( originalParent.name == $"Player{card.ownerID + 1}PlayArea"  || TurnManager.instance.currentPlayerTurn != card.ownerID)
        {
            
        }
        else
        {
            transform.SetParent(transform.root);
            image.raycastTarget = false;
        }

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerEnter);
        // Đặt lại đối tượng cha (parent) của CardController về giá trị ban đầu

        if (originalParent.name == $"Player{card.ownerID}PlayAreA" || TurnManager.instance.currentPlayerTurn != card.ownerID)
        {

        }
        else
        {
            // Kích hoạt tính năng raycast trên image để nhận sự kiện chạm (touch)
            image.raycastTarget = true;
            // Phân tích sự kiện PointerUp
            AnalyzePointerUp(eventData);
        }
    }

   

    void AnalyzePointerUp(PointerEventData eventData)
    {

        if (eventData.pointerEnter != null && eventData.pointerEnter.name == $"Player{card.ownerID}PlayArea")
        {
           // Debug.Log("kshbdcjs");
            if (PlayerManager.instance.FindPlayerByID(card.ownerID).mana >= card.manaCost)
            {
                playCard(eventData.pointerEnter.transform);
               
               // transform.SetParent(originalParent);
                Debug.Log(" =ok");
            }
            else
            {
                returnToHand();
            }

        }
        else
        {
            returnToHand();
        }
    }    


    

    private void playCard(Transform playArea)
    {
        // Đặt đối tượng CardController làm con (child) của playArea
        transform.SetParent(playArea);
        // Đặt vị trí cục bộ (localPosition) của CardController về vị trí gốc (Vector3.zero)
        transform.localPosition = Vector3.zero;
        // Cập nhật đối tượng cha (parent) của CardController thành playArea
        originalParent = playArea;
    }

    private void returnToHand()
    {
        // Đặt lại đối tượng CardController làm con (child) của đối tượng cha (parent) ban đầu
        transform.SetParent(originalParent);
        // Đặt vị trí cục bộ (localPosition) của CardController về vị trí gốc (Vector3.zero)
        transform.localPosition = Vector3.zero;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Kiểm tra nếu đối tượng cha (parent) của CardController là đối tượng cha ban đầu
        if (transform.parent == originalParent)
            return;

        // Đặt vị trí của CardController theo vị trí của con trỏ (pointer)
        transform.position = eventData.position;
    }
}
