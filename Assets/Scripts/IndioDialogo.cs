using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class IndioDialogo : MonoBehaviour
{
   public string cenaReferencia;
   public string[] dialogo;
   [SerializeField] private TextMeshProUGUI textoDialogo; //texto do painel
   [SerializeField] private GameObject painelTexto;
   private bool jaFalou = false;

    private void OnTriggerEnter2D(Collider2D colidiuIndio) 
    {   //Se colidiu com o player
        if(colidiuIndio.CompareTag("Player"))
        {
            Dialogo();
            jaFalou = true;
            //painelTexto.SetActive(true);
            //Dialogo
            /*
            textoDialogo.text = "Olá Jogador! Eu preciso da sua ajuda. Existem maçãs espalhadas pelas fases, mas cuidado! O caminho é perigoso.";
            textoDialogo.text = "Cada fase possui inimigos e armadilhas que podem acabar te machucando.";
            textoDialogo.text = "Use suas habilidades para derrotar os inimigos, coletar as maças e chegar até o altar que leverá você até a fase seguinte,";
            textoDialogo.text = "Boa Sorte!";
            */
            //Esperar um tempo
            //painelTexto.SetActive(false);
        }
        /*if(colidiuIndio.CompareTag("Player"))
        {
            jaFalou = true;
            painelTexto.SetActive(true);
            //Dialogo
            textoDialogo.text = "Que bom ver você novamente! Você enfrentou os desafios com coragem. Estou muito impressionado!";
            textoDialogo.text = "Foi uma aventura e tanto! Vamos preparar um grande banquete e celebrar sua bravura.";
            //Esperar um tempo
            //painelTexto.SetActive(false);
        }*/
    }
    public void Dialogo() //metodo de dialogo
    {
        if(jaFalou == false) //Se o jogador não tiver falado
        {
            painelTexto.SetActive(true); //Ativa a caixa
            StartCoroutine(Dialogue()); //Chama a rotina 
        }
    }
    IEnumerator Dialogue()
    {
        for(int i = 0; i < dialogo.Length; i++) //Onde vai mudar o dialogo
        {
            textoDialogo.text = dialogo[i]; //vai mudar para o dialogo na posição i
            yield return new WaitForSeconds(4f); //Esperar 5 segundos
        }
        yield return new WaitForSeconds(2f); //Espera +1 segundo antes de acabar
        painelTexto.SetActive(false); //Desativa após acabar o dialogo
    }
}
