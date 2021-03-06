﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class ButtonHoverLoop : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
	public AudioClip sound1;
	public AudioClip sound2;
	public AudioClip sound3;
	public AudioClip sound4;
    public AudioClip sound5;
    AudioSource audioSource;

	private float count;

	void Start()
	{
        // get the audio source and set count to 0
		audioSource = GetComponent<AudioSource>();
		count = 0;
	}

    // plays a sound when mouse is hovered over monster picture in about scene
	public void OnPointerEnter(PointerEventData eventData)
	{
        // checks if count is equal to 0, plays sound and adds 1 to the count
		if (count == 0) {
			audioSource.clip = sound1;
			audioSource.Play();
			count = count + 1;
		}
		else if (count == 1) {
			audioSource.clip = sound2;
			audioSource.Play();
			count = count + 1;
		}
		else if (count == 2) {
			audioSource.clip = sound3;
			audioSource.Play();
			count = count + 1;
		}
		else if (count == 3) {
			audioSource.clip = sound4;
			audioSource.Play();
			count = 0;
		}
		else
		{
			
		}

	}

	public void OnSelect(BaseEventData eventData)
	{
		audioSource.clip = sound5;
		audioSource.Play();
	}
}