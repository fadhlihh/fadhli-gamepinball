using UnityEngine;

public class Circle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Enter");
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Exit");
    }
}
