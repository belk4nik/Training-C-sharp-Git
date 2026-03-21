using UnityEngine;

public class Character
{
    public string name;
    public int exp = 0;


    public Character()
    {
        name = "Not alighn";
    }
    public Character(string name)
    {
        this.name = name;
    }
    public void PrintStatsInfo()
    {
        Debug.LogFormat("Hero: {0}  {1} EXP", name, exp);
    }

    private void Reset()
    {
        this.name = "Not nothing";
        this.exp = 0;
    }
}

public struct Weapon
{
    public string name;
    public int damage;

    public Weapon(string name, int damage)
    {
        this.name = name;
        this.damage = damage;
    }

    public void PrintWeaponInfo()
    {
        Debug.LogFormat("Weapon: {0}  {1} DMB", name, damage);
    }

}

public class Paladin : Character
{
    public Paladin(string name) : base(name)
    {

    }
}