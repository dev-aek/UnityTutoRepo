using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Carpısma : MonoBehaviour
{
    int skor;
    public TextMeshProUGUI goldText;
    public Material mat;

    void Start()
    {
        mat.color = Color.white;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            skor += 10;
            Debug.Log(skor.ToString());
            goldText.text = "Gold: " + skor.ToString();
            mat.color = Random.ColorHSV();

            float rastx = Random.Range(-25f, 25f);
            float rasty = Random.Range(-25f, 25f);

            gameObject.transform.position = new Vector3(rastx, 2, rasty);
        }
    }

}
