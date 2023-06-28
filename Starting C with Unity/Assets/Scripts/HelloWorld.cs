using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelloWorld : MonoBehaviour
{
    // Just a scratchpad for playing with variables
    private int hitpoints = 100;
    private int Healt = 100;
    private int HeAlTh = 100;
    private int myHealth = 100;
    private const int PlayerScore = 100;
    // private const int PLAYER_SCORE = 100;
    private string messageForTheTextView = "this space for rent";
    public string firstName;
    public string lastName;
    private TextMeshProUGUI textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"Hello {firstName} {lastName}!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
