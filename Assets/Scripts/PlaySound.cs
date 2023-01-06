using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audio;
    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    void Start()
    {
        _startingPosition = transform.parent.localPosition;
        _myRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter()
    {
        
    }

    public void OnPointerClick(){
        audio.Play();
    }

    public void OnPointerExit()
    {
        audio.Stop();
    }
}
