using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Deck : MonoBehaviour 
{


    [SerializeField]
    private Card cardPrefab;

    private List<Card> _cards;


    private void Awake()
    {
        _cards = new List<Card>();

        foreach(Value value in System.Enum.GetValues(typeof(Value)))
        {
            foreach(Suit suit in System.Enum.GetValues(typeof(Suit)))
            {
                Card card = Instantiate(cardPrefab) as Card;
                card.Initialize(suit, value);

                _cards.Add(card);

                card.transform.parent = this.transform;
                card.gameObject.name = card.Name;
            }
        }

        foreach (Card card in _cards)
            Debug.Log(card.Name);
    }


}
