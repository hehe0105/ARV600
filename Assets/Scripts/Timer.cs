using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeleft;
    public Text Countdown_txt;
    private bool isCounting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isCounting = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCounting) {
            timeleft -= Time.deltaTime;
        }
        Countdown_txt.text = "Time Left: "+timeleft.ToString(format:"0");

        if (timeleft <= 0 && isCounting) {
            isCounting = false;
        }

    }
}
