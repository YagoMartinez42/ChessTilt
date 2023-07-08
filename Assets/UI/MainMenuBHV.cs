using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class MainMenuBHV : MonoBehaviour
{
	private void OnEnable()
	{
		VisualElement root = GetComponent<UIDocument>().rootVisualElement;
		Button buttonNewGame = root.Q<Button>("newGame");
		Button buttonQuit = root.Q<Button>("quit");
		buttonNewGame.clicked += () => SceneManager.LoadScene(1);
		buttonQuit.clicked += () => Application.Quit();
	}
}
