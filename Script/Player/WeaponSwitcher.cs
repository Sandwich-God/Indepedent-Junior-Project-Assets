using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{
    public int selectedWeapon = 0; // Variable is created to allow a change of weapon based on number.h
    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previousSelectedWeapon = selectedWeapon; // Creates a new variable based off the selectedWeapon previous value
        if (Input.GetKeyDown(KeyCode.Alpha1)) // States that if the Input is left click it will fire an arrow.
        {
            selectedWeapon = 0;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2)) // States that if the Input is left click it will fire an arrow.
        {
            selectedWeapon = 1;
        }
        if (previousSelectedWeapon != selectedWeapon) // Calls to SelectWeapon() function.
        {
            SelectWeapon();
        }
    }
    void SelectWeapon() // Selects the weapon based on the selectedWeapon value and either turns on or off the gameobject.
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i == selectedWeapon)
                weapon.gameObject.SetActive(true);
            else
                weapon.gameObject.SetActive(false);
            i++;
        }
    }
}
