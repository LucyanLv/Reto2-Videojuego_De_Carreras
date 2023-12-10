using UnityEngine;
using UnityEngine.InputSystem;

public class PauseManager : MonoBehaviour
{
    public static bool IsPaused = false;

    private void Update()
    {
        if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            if (!IsPaused)
            {
                Pause();
                Debug.Log("Pausa");
            }
            else
            {
                Resume();
                Debug.Log("Continue");
            }
        }
    }

    public void Pause()
    {
        IsPaused = true;
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);

        Time.timeScale = 0;
    }

    public void Resume()
    {
        IsPaused = false;
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);

        Time.timeScale = 1;
    }
}
