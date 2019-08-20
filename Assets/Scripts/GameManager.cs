using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int GlobalMoney;
    public TMP_Text MoneyText;
    // Update is called once per frame
    void Update()
    {
        MoneyText.text = GlobalMoney.ToString();
    }

    public void RemoveMoney(int removeMoney)
    {
        GlobalMoney -= removeMoney;
    }
}
