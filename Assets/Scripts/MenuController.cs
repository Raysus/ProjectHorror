using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public GameObject mainMenu;
	public bool inMainMenu = true;
	public GameObject creditsMenu;
	public bool inCreditsMenu = false;

	public void LoadMainMenu()
	{
		inMainMenu = true;
		inCreditsMenu = false;
		mainMenu.SetActive(true);
		creditsMenu.SetActive(false);
	}

	public void LoadCreditsMenu()
	{
		inMainMenu = false;
		inCreditsMenu = true;
		mainMenu.SetActive(false);
		creditsMenu.SetActive(true);
	}

	public void QuitGame()
	{	Debug.Log("Se ha cerrado el Juego");
		Application.Quit();
	}

	public void PlayGame()
	{
		SceneManager.LoadScene(1);
	}
}
