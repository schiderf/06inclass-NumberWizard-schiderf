using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameScript : MonoBehaviour
{
    int max;
    int min;
    int guess;
    public Text textGuess;
    public Button btnHigher;
    public Button btnLower;
    public Button btnCorrect;

    // Start is called before the first frame update
    void Start()
    {
        max = 100;
        min = 1;
        guess = 50;

        btnHigher.onClick.AddListener(Higher);
        btnLower.onClick.AddListener(Lower);
        btnCorrect.onClick.AddListener(Correct);
    }
    void Higher()
        {
            min = guess;
            guessNext();
            Debug.Log("Higher");
        }

    void Lower()
        {
            max = guess;
            guessNext();
            Debug.Log("Lower");
        }

    void Correct()
        {
            Debug.Log("correct Guess");
            SceneManager.LoadScene("FinishedScene", LoadSceneMode.Single);
        }



    void guessNext()
    {
        guess = (min + max) / 2;
        textGuess.text = guess.ToString();
    }
}
