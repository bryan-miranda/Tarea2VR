using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FactsManager : MonoBehaviour
{
    [SerializeField] string fact;
    [SerializeField] string place;
    [SerializeField] AudioSource intro;
    [SerializeField] AudioSource audio1;
    [SerializeField] AudioSource audio2;
    [SerializeField] AudioSource audio3;
    [SerializeField] AudioSource audio4;

    private Renderer _myRenderer;
    private Vector3 _startingPosition;

    void Start()
    {
        intro.Play();
        _myRenderer = GetComponent<Renderer>();
    }


    // Update is called once per frame
    void Update()
    {

    }

    public void OnPointerEnter()
    {

    }

    public void OnPointerClick()
    {
        intro.Stop();
        audio1.Stop();
        audio2.Stop();
        audio3.Stop();
        audio4.Stop();
        if (fact == "1")
        {
            intro.Stop();
            audio1.Play();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();
        }
        else if (fact == "2")
        {
            intro.Stop();
            audio1.Stop();
            audio2.Play();
            audio3.Stop();
            audio4.Stop();
        }
        else if (fact == "3")
        {
            intro.Stop();
            audio1.Stop();
            audio2.Stop();
            audio3.Play();
            audio4.Stop();
        }
        else if (fact == "4")
        {
            intro.Stop();
            audio1.Stop();
            audio2.Stop();
            audio3.Stop();
            audio4.Play();
        }
        else if (fact == "Next")
        {
            intro.Stop();
            audio1.Stop();
            audio2.Stop();
            audio3.Stop();
            audio4.Stop();

            SceneManager.LoadScene(place);
        }
    }

    public void OnPointerExit()
    {

    }
}
