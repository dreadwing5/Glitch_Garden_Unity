using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] float startScreenLoadTime = 4f;
    int currentSceneIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (currentSceneIndex == 0)
        {
            LoadStartScene();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadStartScene()
    {
        StartCoroutine(WaitAndLoad());
    }
    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(startScreenLoadTime);
        SceneManager.LoadScene("Start Scene");
    }

}
