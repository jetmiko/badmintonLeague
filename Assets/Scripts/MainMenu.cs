using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenu : MonoBehaviour
{

    private TextMeshProUGUI textMeshku;
    private int counter;
    private int idxGame;

    void Start()
    {
        textMeshku = GetComponent<TextMeshProUGUI>();
        counter = 0;
        idxGame = 0;
    }

    // void Update() {
    //     counter++;
    //     textMeshku.text = counter.ToString();

    // }

    public void SingleMenu() {

        if (textMeshku.text=="Single") {
            textMeshku.text = "Double";
        } else {
            textMeshku.text = "Single";
        }
        // Debug.Log(textMeshku.text);
    }

    public void TerusanMenu() {
        if (textMeshku.text=="Terusan") {
            textMeshku.text = "0-0 lagi";
        } else {
            textMeshku.text = "Terusan";
        }
    }

    public void JadulMenu() {
        if (textMeshku.text=="Jadul") {
            textMeshku.text = "Rally Point";
        } else {
            textMeshku.text = "Jadul";
        }
    }

    public void LapMenu() {
        counter++;
        if (counter > 7) {
            counter = 1;
        }
        textMeshku.text = "Lap. " + counter.ToString();
    }

    public void gameMenu() {
        int[] arr = { 30, 40, 50, 60 };
        idxGame++;
        if (idxGame >= arr.Length) {
            idxGame = 0;
        }
        textMeshku.text = "Game " + arr[idxGame].ToString();
    }

}
