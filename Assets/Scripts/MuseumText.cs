using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumText : MonoBehaviour
{
    public GameObject TextUi;
    private float timeToAppear = 5f;
    private float timeWhenDisappear;

    // Start is called before the first frame update
    void Start()
    {
        TextUi.gameObject.SetActive(false);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            TextUi.gameObject.SetActive(true);
            timeWhenDisappear = Time.time + timeToAppear;
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (TextUi.gameObject && (Time.time >= timeWhenDisappear))
        {
            TextUi.gameObject.SetActive(false);
        }
    }
}

