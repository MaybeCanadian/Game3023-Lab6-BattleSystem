using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICombatent : Combatent
{
    public override void OnTurnStart(Combatent input)
    {

    }
    public override void OnTurnEnd(Combatent input)
    {

    }
    public override void OnAllFightersAdded()
    {
        ChooseAbilityRandom();
    }
    public override void OnRoundEnd() 
    {
        //when the round ends the AI chooses a new move to use
        //Debug.Log("test");
        ChooseAbilityRandom();
    }

    private void ChooseAbilityRandom()
    { 
        //just randomly chooses one of the abilities
        if (activeAbilities.Count > 0)
        {
            chosenAbility = activeAbilities[Random.Range(0, activeAbilities.Count - 1)].ability;
            ChooseAbility(chosenAbility);
        }
    }
}
