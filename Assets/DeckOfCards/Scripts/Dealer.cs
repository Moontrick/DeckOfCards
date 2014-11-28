using UnityEngine;
using System.Collections;

public class Dealer : MonoBehaviour 
{


	[SerializeField]
	Deck _deckPrefab;


	private void Awake()
	{
		if (_deckPrefab != null)
		{
			Deck deck = Instantiate(_deckPrefab) as Deck;
			deck.transform.parent = this.transform;
		}
	}


}
