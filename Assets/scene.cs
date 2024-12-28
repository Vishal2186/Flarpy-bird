using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class scene : MonoBehaviour
{
    public Animator Fade;
    public float Fadetime = 1;
    public AudioSource music;
    public void SCENE(string name)
    {
       StartCoroutine(loadlevel(name));
    }
    public void Exit()
    {
        Application.Quit();
    }
    IEnumerator loadlevel(string name)
    {
        Fade.SetTrigger("start");
        yield return new WaitForSeconds(Fadetime);
        SceneManager.LoadScene(name);

    }
}
