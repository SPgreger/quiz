using UnityEngine;
using UnityEngine.SceneManagement;


public class sencewitching : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void NextScene(int index)
    {
        SceneManager.LoadScene(index);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
