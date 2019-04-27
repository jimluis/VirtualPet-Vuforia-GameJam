using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{

    [SerializeField] Text textComponent;

	public static Game Instance;

	public Text text;

	public AudioSource myAudio;

    State state;
	public State babyBorn;
	public State babySad;
	public State babyHappy;

	void Awake() {
		Instance = this;
	}

    // Start is called before the first frame update
    void Start()
    {
        state = babyBorn;
		PlayState();
    }

    // Update is called once per frame
    void Update()
	{

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			state = babyHappy;
			PlayState();
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			state = babySad;
			PlayState();
		}

    }

	void PlayState()
	{
		myAudio.clip = state.myClip;
		myAudio.Play();
		text.text = state.storyText;

	}
		
}
