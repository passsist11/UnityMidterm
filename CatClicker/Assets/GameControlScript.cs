using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControlScript : MonoBehaviour {

	
	public Button catnipButton, fishButton, laserButton;
	public GameObject catnipSoldText, fishSoldText, laserSoldText;
	public Text catnipPriceText, fishPriceText, laserPriceText;


	public GameObject catnip, fish, laser;
	public Text strokeText;
	public int strokesAmount;

	
	private bool isCatnipSold, isFishSold, isLaserSold;
	public int catnipPrice = 10, fishPrice = 20, laserPrice = 30;

	
	void Start () {
		
        catnip.gameObject.SetActive (false);
        fish.gameObject.SetActive (false);
        laser.gameObject.SetActive (false);

		
        catnipButton.interactable = false;
		fishButton.interactable = false;
		laserButton.interactable = false;

	
		catnipSoldText.gameObject.SetActive (false);
		fishSoldText.gameObject.SetActive (false);
		laserSoldText.gameObject.SetActive (false);

	
		catnipPriceText.text = catnipPrice.ToString() + " Strokes";
		fishPriceText.text = fishPrice.ToString() + " Strokes";
		laserPriceText.text = laserPrice.ToString() + " Strokes";
	}
	
	
	void Update () {
		
		
		strokeText.text = strokesAmount + " Strokes";

		
		DoYouHaveEnoughStrokesToBuySmth();
					
	}

	
	public void IncreaseStrokesAmount()
	{
		strokesAmount += 1;
	}

	
	public void SellCatnip()
	{
		
        catnip.gameObject.SetActive (true);
		
        strokesAmount -= catnipPrice;
		
        isCatnipSold = true;
	
		catnipSoldText.gameObject.SetActive (true);
		
		catnipPriceText.gameObject.SetActive (false);
	}


	public void SellFish()
	{
		
        fish.gameObject.SetActive (true);
	
		strokesAmount -= fishPrice;
	
        isFishSold = true;
		
		fishSoldText.gameObject.SetActive (true);
		
		fishPriceText.gameObject.SetActive (false);
	}


	public void SellLaser()
	{
	
		laser.gameObject.SetActive (true);
		
		strokesAmount -= laserPrice;
		
		isLaserSold = true;
		laserSoldText.gameObject.SetActive (true);
		laserPriceText.gameObject.SetActive (false);
	}

	
	void DoYouHaveEnoughStrokesToBuySmth()
	{
		
		
		if (strokesAmount < catnipPrice)
			catnipButton.interactable = false;

	
		if (strokesAmount < fishPrice)
			fishButton.interactable = false;

	
		if (strokesAmount < laserPrice)
			laserButton.interactable = false;

		
	
        if (!isCatnipSold && strokesAmount >= catnipPrice)
		{
			catnipButton.interactable = true;
		}

		if (!isFishSold && strokesAmount >= fishPrice)
		{
			fishButton.interactable = true;
		}

		if (!isLaserSold && strokesAmount >= laserPrice)
		{
			laserButton.interactable = true;
		}
	}

}
