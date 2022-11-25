using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public AudioSource audio; 
    public AudioSource musicAudio;
    public AudioClip idleEngine; 
    public AudioClip forwardEngine; 
    public AudioClip musicTrack; 
    private int speed;

    private int isPlaying; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CalcSpeed());
        audio.loop = true;
        audio.clip = idleEngine;
        audio.playOnAwake = true; 
        audio.Play();

        musicAudio.clip = musicTrack;
        musicAudio.loop = true;
        musicAudio.playOnAwake = true;
        musicAudio.Play();
        musicAudio.volume = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        if((OVRInput.Get(OVRInput.Button.Two) || OVRInput.Get(OVRInput.Button.One)) && isPlaying != 1){
            audio.clip = forwardEngine;
            audio.Play();
            isPlaying = 1;
            audio.volume = 0.8f;
        }else if(speed == 0 && isPlaying != 2){
            audio.clip = idleEngine;
            audio.Play();
            isPlaying = 2;
            audio.volume = 0.8f;
        }
    }

    IEnumerator CalcSpeed()
    {
        bool isPlaying = true;

        while (isPlaying)
        {
            Vector3 prevPos = transform.position;

            yield return new WaitForFixedUpdate();

            speed = Mathf.RoundToInt(Vector3.Distance(transform.position, prevPos) / Time.fixedDeltaTime) * 2;
        }
    }
}
