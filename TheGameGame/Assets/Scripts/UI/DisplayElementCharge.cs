﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayElementCharge : MonoBehaviour {

	private ElementManager elementManager;

	public Image elementChargeImg;

	public GameObject canvasManager;

	private GameObject player;

	public void StartGame()
	{
		player = canvasManager.GetComponent<CanvasManager>().player;

		elementManager = player.GetComponent<ElementManager>();
	}

	public void StartDepleteGauge()
	{
		StartCoroutine(DepleteGauge());
	}

	IEnumerator DepleteGauge()
	{

		while(elementManager.usingElement)
		{
			elementChargeImg.fillAmount = elementManager.currentElemental.GetComponent<Animator>().GetFloat("elementCharge");

			yield return null;
		}
	}
}