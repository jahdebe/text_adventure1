using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour 
{

	public Text	text;
	private enum States {beginning, tavern};
	private States currentState;
	
	// Use this for initialization
	void Start () 
	{
		currentState = States.beginning;
	}
	
	// Update is called once per frame
	void Update () 
	{
		print(currentState);
		switch(currentState)
		{
		case States.beginning:
			state_beginning();
			break;
		case States.tavern:
			state_tavern();
			break;
		}	
	}
		
	void state_beginning()
	{
		text.text = "Dusk falls and your day of travel has brought you to the Green Dragon Inn " +
				"for food warmth and a place to rest. Several villagers are here eating, drinking and talking " +
				"about thier days. One day is much the same as another in the small village of Davenville, " +
				"but looking at you something tells these villagers today will be different \n\n" +
				"Press 'Enter' to enter the Green Dragon Inn";
		if(Input.GetKeyDown(KeyCode.Return))
		{
			currentState = States.tavern;
		}
	}
	
	void state_tavern()
	{
		text.text = "Looking around the tavern, you see the Innkeeper with her family  " +
				"...";
	}
}

