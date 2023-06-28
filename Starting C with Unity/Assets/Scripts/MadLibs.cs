using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MadLibs : MonoBehaviour
{
    public bool statement = false;
    public string verb = "kill";
    public string noun = "King";
    public string adjective = "innocent";
    public int number = 7;
    public string pluralNoun = "scounds";
    public float percent = 100;
    private TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
        textMeshPro.text = $"The is statement is {statement}. I did not {verb} the {noun}. I am not guilty. I am a {adjective} person. The act was performed by {number} wandering {pluralNoun}. i am {percent}% sure of this.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

// create variables
// statement = bool
// verb = string
// noun = string
// adjective = string
// number = int
// pluralNoun = string
// percent = float