using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int score = 0;
    private void Start()
    {
        FlappyBird.Instance.onpipetrigger += FlappyBird_onpipetrigger;
        
    }

  

    private void FlappyBird_onpipetrigger(object sender, System.EventArgs e)
    {
        score++;
        Debug.Log(score);
    }

    
}
