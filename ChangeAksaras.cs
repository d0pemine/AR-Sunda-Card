using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ChangeAksaras : MonoBehaviour
{
    public Button[] btnChange;
    public GameObject[] aksaras, teks;
    public int index;
    public AudioClip[] audios;
    public AudioSource sc;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonLeftRight(){
        if(EventSystem.current.currentSelectedGameObject. name == "Button Prev")
        {
            Debug.Log("prev");

            aksaras[index].SetActive(false);
            teks[index].SetActive(false);

            index -= 1;
            
            if(index < 0)
            {
                index = aksaras.Length - 1;
                index = teks.Length - 1;

            }

            aksaras[index].SetActive(true);
            teks[index].SetActive(true);

            sc.clip = audios[index];
            sc.Play();
            
        } 
        
        else
        {
           Debug.Log("next");

            aksaras[index].SetActive(false);
            teks[index].SetActive(false);


            index += 1;
            
            if(index > aksaras.Length - 1)
            {
                index = 0;
            }
            
            aksaras[index].SetActive(true);
            teks[index].SetActive(true);

            sc.clip = audios[index];
            sc.Play();
        
        }
    }

    public void onTargetFound()
    {
        for (int i = 0; i < btnChange.Length; i++)
        {
            btnChange[i].interactable = true;
        }

        aksaras[0].SetActive(true);
        teks[0].SetActive(true);

        sc.clip = audios[0];
        sc.Play();
    }

    public void onTargetLoss()
    {
        for (int i = 0; i < btnChange.Length; i++)
        {
            btnChange[i].interactable = false;
        }
    }
}
