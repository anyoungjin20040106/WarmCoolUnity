using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultText : MonoBehaviour
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text=GetComponent<Text>();
        text.text=$" Your Skin Tone: {Session.session.ColorId}";
    }
}
