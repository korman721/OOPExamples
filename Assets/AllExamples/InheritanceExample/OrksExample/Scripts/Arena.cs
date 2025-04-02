using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    private void Start()
    { 
        OrkPaladin orkPaladin = new OrkPaladin("Ork Paladin", 75, 5, 25, 10);
        OrkMage orkMage = new OrkMage("Ork Mage", 25, 15, 2);

        //ShowInfoAbout(orkPaladin);
        //ShowInfoAbout(orkMage);

        List<Ork> orks = new List<Ork>();
        orks.Add(orkPaladin);
        orks.Add(orkMage);

        foreach (Ork ork in orks)
            ork.IssueCry();

        //ProcessBattel(orkMage, orkPaladin);

        //DetermineWinner(orkMage, orkPaladin);
    }

    private void ShowInfoAbout(Ork ork)
    {
        Debug.Log($"Name: {ork.Name}, hp: {ork.Health}");

        ork.IssueCry();

        ork.TakeDamage(10);

        Debug.Log($"Name: {ork.Name}, hp: {ork.Health}");
    }

    private void ProcessBattel(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        while (orkPaladin.Health > 0 && orkMage.Health > 0)
        {
            orkMage.CastSpell();
            orkPaladin.TakeDamage(orkMage.Damage);

            orkPaladin.Heal();
            orkMage.TakeDamage(orkPaladin.Damage);

            Debug.Log($"{orkPaladin.Name} - {orkPaladin.Health}");
            Debug.Log($"{orkMage.Name} - {orkMage.Health}");
        }
    }

    private void DetermineWinner(OrkMage orkMage, OrkPaladin orkPaladin)
    {
        if (orkMage.Health <= 0 && orkPaladin.Health <= 0)
            Debug.Log("Ничья");
        else if (orkMage.Health > 0)
            Debug.Log($"Победил {orkMage.Name}");
        else
            Debug.Log($"Победил {orkPaladin.Name}");
    }
}
