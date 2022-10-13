using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;
	private enum Level {Amazon, Boa, Nyon, News, Save, Raft, Dead};
	private Level myLevel;
		
	// Use this for initialization
	void Start () { 	
		myLevel = Level.Amazon;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if 		(myLevel == Level.Amazon)	 	{Amazon ();} 
		else if (myLevel == Level.Boa) 			{Boa();}
		else if (myLevel == Level.Nyon) 		{Nyon();}
		else if (myLevel == Level.News) 		{News();}
		else if (myLevel == Level.Save) 		{Save();}
		else if (myLevel == Level.Raft) 		{Raft();}
		else if (myLevel == Level.Dead) 		{Dead();}
	}

	void Amazon () {
		text.text = "You are in Amazon Lily. You see two people there, one is Boa Hancock and other is Elder Nyon.\n\n" +
					"Press B to talk with Boa Hancock and N to talk with Nyon";

		if 		(Input.GetKeyDown (KeyCode.B)) 	{myLevel = Level.Boa;}
		else if (Input.GetKeyDown (KeyCode.N))	{myLevel = Level.Nyon;}

	}

	void Boa () {
		text.text = "Marry me..\n\n" +
					"Press R to Refuse";

		if (Input.GetKeyDown (KeyCode.R))		{myLevel = Level.Amazon;}
	} 

	void Nyon () {
		text.text = "Yo Young boy, did you hear that Fire Fist Ace is going to be executed? Its recently on the newspaper.\t\n\n" +
					"Press I to Interact";

		if (Input.GetKeyDown (KeyCode.I))		{myLevel = Level.News;}
	} 

	void News () {
		text.text = "What? ARE YOU SERIOUS? He is my brother! I need to save him at any cost..\n\n" +
					"Press C to Continue";

		if (Input.GetKeyDown (KeyCode.C))		{myLevel = Level.Save;}
	} 

	void Save () {
		text.text = "Fire Fist Ace is your brother?! Now I can understand the demon blood line. You are not in safe position to " +
					"go to Impel Down and save your brother on your own\n\n" +
 					"Press R to ask Raft, S to Swin to Impel Down";

		if 		(Input.GetKeyDown (KeyCode.R))		{myLevel = Level.Raft;}
		else if (Input.GetKeyDown (KeyCode.S))		{myLevel = Level.Dead;}
	} 

	void Raft () {
		text.text = "You forecully ask a Raft and you finally get a raft. Raft is not in good condition neither you know how to use it..\n\n" +
					"Press U to Use Raft";

		if (Input.GetKeyDown (KeyCode.U))		{myLevel = Level.Dead;}
	} 


	void Dead () {
		text.text = "I understand you want to save your brother but your reckless act made you drown and as a devil fruit user, you die and so does your brother\n\n" +
					"Press P to Play Again";

		if (Input.GetKeyDown (KeyCode.P))		{myLevel = Level.Amazon;}
	} 

}


