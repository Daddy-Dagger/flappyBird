using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject Pipes;
    private float timer = 0f;
    private float number = 1f;
    private float pipeGap = 0.8f;
    private void Update()
    {
        timer += number * Time.deltaTime;
        
        if(timer >= pipeGap)
        {
            GameObject.Instantiate(Pipes);
            timer = 0f;
        }
    }
}
