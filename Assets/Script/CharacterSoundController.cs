using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSoundController : MonoBehaviour
{
    public AudioClip jump;
    private AudioSource audioPLayer;

    // Start is called before the first frame update
    private void Start()
    {
        audioPLayer = GetComponent<AudioSource>();
    }

    public void Playjump()
    {
        audioPLayer.PlayOneShot(jump);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
