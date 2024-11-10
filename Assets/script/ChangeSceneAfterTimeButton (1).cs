using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Create a UI button w/canvas
// Attach this script to the Button
// In the script component, enter the "Scene Name To Load"
// Enter the length of the "Delay Before Loading"
// Drag the Button component into the "Button" field
// Add an On-Click event
// Drag the Button in to the "None(Object)" field
// Select the "ChangeSceneAfterTimeButton" function
// Renter the scene name you want to load into the field

public class ChangeSceneAfterTimeButton : MonoBehaviour
{
    public string SceneNameToLoad;
    public float delayBeforeLoading = 5f;
    public Button button;

    private void Start()
    {
        button.onClick.AddListener(LoadSceneOnClick);
    }

    private void LoadSceneOnClick()
    {
        StartCoroutine(LoadSceneAfterDelay());
        Debug.Log("Coroutine Started");
    }

    private IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(delayBeforeLoading);
        Debug.Log("Coroutine Finished");
        SceneManager.LoadScene(SceneNameToLoad);
    }
}