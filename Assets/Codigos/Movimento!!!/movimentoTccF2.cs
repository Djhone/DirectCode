﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class movimentoTccF2 : MonoBehaviour

{

    public GameObject inputField;
    public GameObject inputField1;
    public GameObject inputField2;
    public GameObject inputField3;
    public GameObject inputField4;
    public GameObject inputField5;





    public int cont2 = 0;
    public string texto;
    public string texto1;
    public string texto2;
    public string texto3;
    public string texto4;
    public string texto5;
    public string texto6;

    public int flag = 0;

    private float tempo = 0.56f;

    public Rigidbody2D rb;


    public void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }


    public void play()
    {
        if (cont2 == 0)
        {
            {
                StartCoroutine(waiter());

            }

        }


    }

    public void getAndSet001()
    {

        texto1 = inputField.GetComponent<Text>().text;
        texto2 = inputField1.GetComponent<Text>().text;
        texto3 = inputField2.GetComponent<Text>().text;
        texto4 = inputField3.GetComponent<Text>().text;
        texto5 = inputField4.GetComponent<Text>().text;
        texto6 = inputField5.GetComponent<Text>().text;

    }



    public IEnumerator waiter()
    {

        texto = texto1 + texto2 + texto3 + texto4 + texto5 + texto6;


        string sentence = texto;


        texto = texto.Replace(" ", "");


        string[] subs = Regex.Split(texto, ";");


        string pattern = @"^(cima|baixo|esquerda|direita)\([1-6]?\)$";



        foreach (string sub in subs)
        {
            Match match2 = Regex.Match(sub, pattern);
            if (match2.Success)

            {

                switch (sub)
                {
                    case "baixo()":
                    case "baixo(1)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, -2f);
                            yield return new WaitForSeconds(tempo);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;
                    
                    case "baixo(2)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, -2f);
                            yield return new WaitForSeconds(tempo * 2);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "baixo(3)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, -2f);
                            yield return new WaitForSeconds(tempo * 3);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "baixo(4)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, -2f);
                            yield return new WaitForSeconds(tempo * 4);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "baixo(5)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, -2f);
                            yield return new WaitForSeconds(tempo * 5);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "esquerda()":
                    case "esquerda(1)":
                        flag++;
                        if (flag == 1)
                        {

                            rb.velocity = new Vector2(-2f, 0f);
                            yield return new WaitForSeconds(tempo);
                            rb.velocity = new Vector2(0f, 0f);

                        }
                        flag--;
                        break;

                    case "esquerda(2)":
                        flag++;
                        if (flag == 1)
                        {

                            rb.velocity = new Vector2(-2f, 0f);
                            yield return new WaitForSeconds(tempo * 2);
                            rb.velocity = new Vector2(0f, 0f);

                        }
                        flag--;
                        break;

                    case "esquerda(3)":
                        flag++;
                        if (flag == 1 )
                        {

                            rb.velocity = new Vector2(-2f, 0f);
                            yield return new WaitForSeconds(tempo * 3);
                            rb.velocity = new Vector2(0f, 0f);

                        }
                        flag--;
                        break;

                    case "esquerda(4)":
                        flag++;
                        if (flag == 1 )
                        {

                            rb.velocity = new Vector2(-2f, 0f);
                            yield return new WaitForSeconds(tempo * 4);
                            rb.velocity = new Vector2(0f, 0f);

                        }
                        flag--;
                        break;

                    case "esquerda(5)":
                        flag++;
                        if (flag == 1 )
                        {

                            rb.velocity = new Vector2(-2f, 0f);
                            yield return new WaitForSeconds(tempo * 5);
                            rb.velocity = new Vector2(0f, 0f);

                        }
                        flag--;
                        break;

                    case "direita()":
                    case "direita(1)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(2f, 0f);
                            yield return new WaitForSeconds(tempo);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "direita(2)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(2f, 0f);
                            yield return new WaitForSeconds(tempo * 2);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "direita(3)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(2f, 0f);
                            yield return new WaitForSeconds(tempo *3);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "direita(4)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(2f, 0f);
                            yield return new WaitForSeconds(tempo * 4);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "direita(5)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(2f, 0f);
                            yield return new WaitForSeconds(tempo * 5);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "cima()":
                    case "cima(1)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, 2f);
                            yield return new WaitForSeconds(tempo);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "cima(2)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, 2f);
                            yield return new WaitForSeconds(tempo * 2);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "cima(3)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, 2f);
                            yield return new WaitForSeconds(tempo * 3);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "cima(4)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, 2f);
                            yield return new WaitForSeconds(tempo * 4);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    case "cima(5)":
                        flag++;
                        if (flag == 1)
                        {
                            rb.velocity = new Vector2(0f, 2f);
                            yield return new WaitForSeconds(tempo * 5);
                            rb.velocity = new Vector2(0f, 0f);
                        }
                        flag--;
                        break;

                    default:



                        break;
                }

               

            }

        }
        cont2++;
    }

}
