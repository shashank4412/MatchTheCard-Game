[System.Serializable]
public class CardConfig
{
    public string cardCode;
    public string cardBackPath;
    public string cardFrontPath;

    public CardConfig(string cardCode)
    {
        this.cardCode = cardCode;
        this.cardBackPath = "Cards/card_back";
        this.cardFrontPath = "Cards/Front/" + cardCode;
    }

    public static bool IsMatching(CardConfig cardProp1, CardConfig cardProp2)
    {
        return cardProp1.cardCode == cardProp2.cardCode;
    }
}

[System.Serializable]
public class cardJSON
{
    public System.Collections.Generic.List<string> cards;
}