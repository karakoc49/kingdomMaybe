using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CutScenes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CutScene());
    }

    private IEnumerator CutScene()
    {
        yield return new WaitForSeconds(11f);
        SceneManager.LoadScene(2);
    }
}
