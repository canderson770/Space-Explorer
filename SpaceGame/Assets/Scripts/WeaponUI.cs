using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class WeaponUI : MonoBehaviour
{
    private Image thisImage;
    private int index = -1;
    public List<Sprite> weaponSprites;

    void Start()
    {
        thisImage = GetComponent<Image>();
    }

    void Update()
    {
        if (index != (int)StaticVars.CurrentWeapon)
        {
            index = (int)StaticVars.CurrentWeapon;
            thisImage.sprite = weaponSprites[index];
        }
    }
}
