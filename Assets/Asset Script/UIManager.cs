using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform MenuAtas, MenuBawah, MenuKiri, Button, Informasi, Petunjuk;

    
    // Start is called before the first frame update
    void Start()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonKembali()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuBawah.DOAnchorPos(new Vector2(0, 0), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(-2000, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonInformasi()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void ButtonGuide()
    {
        MenuAtas.DOAnchorPos(new Vector2(0, 2500), 1.0f);
        MenuBawah.DOAnchorPos(new Vector2(0, -2500), 1.0f);
        MenuKiri.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Informasi.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Petunjuk.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
    
}