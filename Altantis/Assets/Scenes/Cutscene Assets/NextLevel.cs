using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        Debug.Log("Starting countdown (21)");

        //Wait for video duration
        yield return new WaitForSeconds(21);

        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
