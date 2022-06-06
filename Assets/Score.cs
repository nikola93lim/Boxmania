using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    TextMeshProUGUI _textMeshPro;
    SpawnManager spawnManager;
    // Start is called before the first frame update
    void Awake()
    {
        _textMeshPro = GetComponent<TextMeshProUGUI>();
        spawnManager = FindObjectOfType<SpawnManager>().GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _textMeshPro.text = "Score: " + spawnManager.numberOfTaps * 10;    
    }
}
