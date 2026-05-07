using System;
using TMPro;
using UnityEngine;

public class GameMNGR : MonoBehaviour
{
    public static GameMNGR instance;

    private bool hasKey = true;

    [SerializeField] private GameObject loseScreen;
    [SerializeField] private GameObject winScreen;

    [SerializeField] private GameObject barricade;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void EnableLoseScreen(string deathMessage)
    {
        loseScreen.SetActive(true);
        loseScreen.transform.Find("tmpDeathMessage").GetComponent<TextMeshProUGUI>().text = deathMessage;
        winScreen.SetActive(false);
    }
    
    public void EnableWinScreen(string winMessage)
    {
        winScreen.SetActive(true);
        winScreen.transform.Find("tmpWinMessage").GetComponent<TextMeshProUGUI>().text = winMessage;
        loseScreen.SetActive(false);
    }

    public void SetHasKey(bool value)
    {
        hasKey = value;

        ///I imagine there must be a better way to do this. Such as sending out a signal that the barricade listens for and then reacts to.
        ///But this is the most straightforward way I can think of to implement this functionality at the moment.
        if (value)
        {
            barricade.SetActive(false);
        }
    }

    public bool GetHasKey()
    {
        return hasKey;
    }
}
