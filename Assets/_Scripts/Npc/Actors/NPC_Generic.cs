﻿using UnityEngine;
using System.Collections;

public class NPC_Generic : Actor
{

	protected override void Awake ()
	{
		base.Awake ();
	}

	void Update ()
	{
		if (actorActions.Count != 0)
			DoAction (actorActions [onCurrentAction]);
	}

	void OnMouseDown ()
	{
		if (atributes.hasDialouge)
		{
			if (dialouge.dialogueText.Count != 0)
			{
				dialouge.goToNextWindow = false;
				dialouge.initialise = true;
				dialouge.active = true;
			}
		
			
			if (dialouge.active)
				dialouge.goToNextWindow = true;
			


		}
	}
}
