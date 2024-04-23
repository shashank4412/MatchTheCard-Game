using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StatsBoard : MonoBehaviour
{
	private Vault vault;
	public Button resetBtn;
	public Text matchesTxt;
	public Text movesTxt;
	public Text cardsTxt;

	private int matches;
	private int moves;
	private int cardsCount;

	private const string Matches_KEY = "mathes";
	private const string Moves_KEY = "moves";

	private void Start()
	{
		vault = new Vault();
		resetBtn.onClick.AddListener(Reset);
		SetMatchDetails(vault.GetSavedData<int>(Matches_KEY));
		SetMoveDetails(vault.GetSavedData<int>(Moves_KEY));
	}


	public void IncrementMatches(int value = 1)
	{
		SetMatchDetails(matches + value);
	}
	public void IncrementMoves(int value = 1)
	{
		SetMoveDetails(moves + value);
	}
	public void IncrementCardsCount(int value)
	{
		SetCardsCount(cardsCount + value);
	}


	public void SetMatchDetails(int matches)
	{
		this.matches = matches;
		matchesTxt.text = "Matches: " + matches;
		vault.SaveData(matches, Matches_KEY);
	}
	public void SetMoveDetails(int moves)
	{
		this.moves = moves;
		movesTxt.text = "Moves: " + moves;
		vault.SaveData(moves, Moves_KEY);
	}
	public void SetCardsCount(int cardsCount)
	{
		this.cardsCount = cardsCount;
		cardsTxt.text = "Cards: " + cardsCount;
	}


	private void Reset()
	{
		vault.DeleteAllData();
		SceneManager.LoadScene(0);
	}
}