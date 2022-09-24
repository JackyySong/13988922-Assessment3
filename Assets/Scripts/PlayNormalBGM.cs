using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNormalBGM : MonoBehaviour
{
    public AudioSource IntroBGM;
    public AudioClip[] NormalBGM;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {

        IntroBGM = GetComponent<AudioSource>();
        IntroBGM.clip = NormalBGM[0];
        IntroBGM.Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (!IntroBGM.isPlaying)
        {
            Next();
        }
    }


    void Next()
    {

        index++;
        index = index % NormalBGM.Length;
        IntroBGM.clip = NormalBGM[index];
        IntroBGM.Play();
    }
}
