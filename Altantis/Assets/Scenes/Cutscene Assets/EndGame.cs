using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        Debug.Log("Starting countdown (21s)");

        //Wait for video duration
        yield return new WaitForSeconds(21);

        SceneManager.LoadScene("Atlantis");
    }

    // Update is called once per frame
    void Update()
    {

    }
}