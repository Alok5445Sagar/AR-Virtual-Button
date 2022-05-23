using System.Collections;
using System.Collections.Generic;
using Vuforia;
using UnityEngine;
public class VirtualButtonScript : MonoBehaviour
{
     public GameObject spherego, cubego;
    public VirtualButtonBehaviour Vbutton;
    // Start is called before the first frame update
    void Start()
    {
        Vbutton.RegisterOnButtonPressed(OnButtonPressed);
        Vbutton.RegisterOnButtonReleased(OnButtonReleased);
        cubego.SetActive(true);
        spherego.SetActive(false);
     }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
        cubego.SetActive(false);
        spherego.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        cubego.SetActive(true);
        spherego.SetActive(false);
    }
}