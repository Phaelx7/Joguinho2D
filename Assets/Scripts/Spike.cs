using UnityEngine;

public class Spike : MonoBehaviour
{
    //verificar se colidiu
    void OnTriggerEnter2D(Collider2D collision)
    {   //colidiu com o player
        if(collision.CompareTag("Player"))
        {
            //Chama o metodo de dano do player
            collision.GetComponent<Player>().Hit();
            collision.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 12f, ForceMode2D.Impulse);
            //Jogar o player para cima
        }
    }
}