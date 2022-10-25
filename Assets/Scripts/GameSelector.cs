using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSelector : MonoBehaviour {

	public Canvas mainMenuCanvas;
	public QwixxController qwixxController;
	public HarvestController harvestController;
	public ToTheTopController toTheTopController;


	private void Start() {
		XorRandom.GenerateSeed();
		GoToMain();
	}

	public void GoToMain() {
		mainMenuCanvas.enabled = true;
	}

	public void StartQwixx() {
		qwixxController.StartGame();
	}

	public void StartHarvestDice() {
		harvestController.StartGame();
	}

	public void StartRollToTheTop() {
		toTheTopController.StartGame();
	}
}
