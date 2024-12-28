using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioSource blip;
    public void playSound()
    {
        blip.Play();
    }
}
