using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WelcomeText : MonoBehaviour
{
    public GameObject TextOnce;
    private float timeToAppear = 2f;
    private float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
    
            TextOnce.gameObject.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TextOnce.gameObject && (Time.time >= timeWhenDisappear))
        {
            TextOnce.gameObject.SetActive(false);
        }
    }
}