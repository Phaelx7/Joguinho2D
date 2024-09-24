using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndioDialogo : MonoBehaviour
{
   public string cenaReferencia;
   [SerializeField] private TextMeshProUGUI textoDialogo;
   [SerializeField] private GameObject painelTexto;

    private void OnTriggerEnter2D(Collider2D colidiuIndio) 
    {   //Se colidiu com o player e está no tutorial
        if(colidiuIndio.CompareTag("Player") && cenaReferencia.Equals("Tutorial"))
        {
            painelTexto.SetActive(true);
            //Dialogo
            textoDialogo.text = "Olá Jogador! Eu preciso da sua ajuda. Existem maçãs espalhadas pelas fases, mas cuidado! O caminho é perigoso.";
            textoDialogo.text = "Cada fase possui inimigos e armadilhas que podem acabar te machucando.";
            textoDialogo.text = "Use suas habilidades para derrotar os inimigos, coletar as maças e chegar até o altar que leverá você até a fase seguinte";
            textoDialogo.text = "Boa Sorte!";
            //Esperar um tempo
            //painelTexto.SetActive(false);
        }
        //Se colidiu com o player e está na fase final
        if(colidiuIndio.CompareTag("Player") && cenaReferencia.Equals("Final"))
        {
            painelTexto.SetActive(true);
            //Dialogo
            textoDialogo.text = "Que bom ver você novamente! Você enfrentou os desafios com coragem. Estou muito impressionado!";
            textoDialogo.text = "Foi uma aventura e tanto! Vamos preparar um grande banquete e celebrar sua bravura.";
            //Esperar um tempo
            //painelTexto.SetActive(false);
        }
    }
}
