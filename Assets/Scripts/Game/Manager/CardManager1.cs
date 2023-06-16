using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager1 : MonoBehaviour
{
    public static CardManager1 instance;
    public List<Card> cards = new List<Card>();
    public Transform player1Hand, player2Hand;
    public CardController cardControllerPrefabs;

    // Biến instance để lưu trữ thể hiện duy nhất của lớp CardManager1
    // Biến cards để lưu trữ danh sách các đối tượng Card
    // Biến player1Hand và player2Hand để lưu trữ các vị trí tay của người chơi
    // Biến cardControllerPrefabs để lưu trữ Prefab của CardController

    private void Awake()
    {
        // Gán thể hiện của CardManager1 cho biến instance khi đối tượng được khởi tạo
        instance = this;
    }

    private void Start()
    {
        // Gọi phương thức GenerateCards để tạo các lá bài
        this.GenerateCards();
    }

    private void GenerateCards()
    {
        // Lặp qua danh sách các đối tượng Card
        foreach (Card card in cards)
        {
            // Tạo một thể hiện mới của CardController từ Prefab cardControllerPrefabs
            CardController newCard = Instantiate(cardControllerPrefabs, player1Hand);
            // Đặt vị trí ban đầu của thẻ bài tại vị trí gốc (Vector3.zero)
            newCard.transform.localPosition = Vector3.zero;
            // Khởi tạo thông tin cho thẻ bài mới
            newCard.Initialized(card, 0);
        }

        // Lặp qua danh sách các đối tượng Card
        foreach (Card card in cards)
        {
            // Tạo một thể hiện mới của CardController từ Prefab cardControllerPrefabs
            CardController newCard = Instantiate(cardControllerPrefabs, player2Hand);
            // Đặt vị trí ban đầu của thẻ bài tại vị trí gốc (Vector3.zero)
            newCard.transform.localPosition = Vector3.zero;
            // Khởi tạo thông tin cho thẻ bài mới
            newCard.Initialized(card, 1);
        }
    }
}
