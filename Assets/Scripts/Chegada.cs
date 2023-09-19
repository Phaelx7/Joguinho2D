using UnityEngine;
using UnityEngine.SceneManagement;

public class Chegada : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {   //passa de fase
            SceneManager.LoadScene("Venceu");
        }
    }
}