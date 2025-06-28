using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collect : MonoBehaviour
{
    public TMP_Text ui;
    public int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Coin")) {
            score++;
            ui.text = "Coins Collected: "+score+"/10";
            Destroy(other.gameObject);
            if (score==10) {
                ui.text = "Congratulations! You win!";
            }
        }
    }
}
