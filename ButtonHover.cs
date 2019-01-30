using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class ButtonHover : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
    // This script gives the game more flavour by adding in audio sounds when mouse hovers over buttons and presses buttons

	public AudioClip buttonhover;
	public AudioClip buttonPress;
	AudioSource audioSource;

	void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	public void OnPointerEnter(PointerEventData eventData)
	{
        // When mouse hovers over button play sound
		audioSource.clip = buttonhover;
		audioSource.Play();

	}

	public void OnSelect(BaseEventData eventData)
	{
        // On mouse click on button play sound
		audioSource.clip = buttonPress;
		audioSource.Play();
	}
}