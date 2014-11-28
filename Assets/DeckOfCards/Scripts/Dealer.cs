using UnityEngine;
using System.Collections;

public class Dealer : MonoBehaviour 
{


	[SerializeField]
	Deck _deckPrefab;

	private Deck deck;


	private void Awake()
	{
		if (_deckPrefab != null)
		{
			deck = Instantiate(_deckPrefab) as Deck;
			deck.transform.parent = this.transform;
		}
	}


	private void Update()
	{
		if (Input.GetKeyUp (KeyCode.Space))
			DealCard ();
	}


	public void DealCard()
	{
		Card dealtCard = deck.TopCard;
		dealtCard.gameObject.transform.parent = null;
		Debug.Log ("Dealt card: " + dealtCard.Name);
	}


}
