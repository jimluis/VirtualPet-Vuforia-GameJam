using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    public string storyText;
	public AudioClip myClip;

    //[SerializeField] State[] nextStates;


	public string GetStateStory()
	{
		return storyText;
	}




}