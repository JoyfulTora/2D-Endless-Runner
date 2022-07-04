using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    private AudioSource audioPlayer;
    public AudioClip scoreHighlight;

    // Start is called before the first frame update
    private void Start()
    {
        audioPlayer = GetComponent<AudioSource>();
    }

    public void PlayScoreHighlight()
    {
        audioPlayer.PlayOneShot(scoreHighlight);
    }

    public void Playjump()
    {
        audioPlayer.PlayOneShot(jump);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
