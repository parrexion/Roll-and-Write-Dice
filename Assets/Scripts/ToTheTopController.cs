using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTheTopController : MonoBehaviour {

	public GameSelector gameSelector;
	public Canvas gameCanvas;

	public Dice[] dice;


	private void Start() {
		gameCanvas.enabled = false;
		for (int i = 0; i < dice.Length; i++) {
			dice[i].onDieClick += dice[i].ToggleLock;
		}
	}

	public void StartGame() {
		for (int i = 0; i < dice.Length; i++) {
			dice[i].Setup();
		}
		gameCanvas.enabled = true;
	}

	public void QuitGame() {
		gameSelector.GoToMain();
		gameCanvas.enabled = false;
	}

	public void ClickRollAll() {
		AudioController.instance.PlayRollSound();
		for (int i = 0; i < dice.Length; i++) {
			dice[i].Roll(true);
		}
	}
	
}
