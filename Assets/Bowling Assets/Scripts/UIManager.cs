using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Profiling;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform frameHolder;
    [SerializeField] private GameObject messageUIStrike;
    [SerializeField] private GameObject messageUISpare;
    [SerializeField] private GameObject gameOverUI;
    [SerializeField] private TMP_Text scoreText;
    private FrameUI[] frames;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetFrameUI()
    {
        frames = new FrameUI[frameHolder.childCount];
        for (int i = 0; i < frameHolder.childCount; i++)
        {
            frames[i] = frameHolder.GetChild(i).GetComponent<FrameUI>();
            frames[i].SetFrame(i + 1);
        }
    }


}
