using UnityEngine;
using System.Collections;

public class Card : MonoBehaviour 
{


    private Suit _suit;
    public Suit Suit
    {
        get { return _suit; }
        private set { }
    }

    private Value _value;
    public Value Value
    {
        get { return _value; }
        private set { }
    }

    private string _name;
    public string Name
    {
        get { return _name; }
        private set { }
    }


    /// <summary>
    /// Set the cards value and suit
    /// </summary>
    public void Initialize(Suit inSuit, Value inValue)
    {
        _suit = inSuit;
        _value = inValue;
        _name = _value.ToString() + " of " + _suit.ToString() + "s";
    }


}
