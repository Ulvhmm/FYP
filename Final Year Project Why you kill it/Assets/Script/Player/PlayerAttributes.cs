using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public int Attack = 1;
    public int Defence = 1;
    public int Mana = 0;

    public int Gold = 0;

    public int Buytime = 0;

    public int Level = 0;
    public int RequireXP = 10;
    public int Experience = 0;

    public void AddExperience(int amount)
    {
        Experience += amount;
        
        while (Experience >= RequireXP)
        {
            LevelUp();
        } 
    }

    public void LevelUp()
    {
        Level++;
        Experience -= RequireXP;
        RequireXP += 10;
        Attack += 1 * Level;
        Defence += 1 * Level;
        Player.instance.GetComponent<TPSShooter>().Range += 0.05f;
        
        Debug.Log("Level up! You are now level " + Level);
    }
}
