using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] LevelMusic;

	private AudioSource audioSource;

	// Use this for initialization
	void Awake () 
	{
		DontDestroyOnLoad (gameObject);
	}

	void Start()
	{
		audioSource = this.GetComponent<AudioSource>();
	}

	 void OnLevelWasLoaded(int level)
	{
		AudioClip thisLevelMusic = LevelMusic[level];

		if (thisLevelMusic)
		{
			audioSource.clip = thisLevelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}


}
