using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Difficulty
{
    static float secondsToMaxDifficulty = 60f;

    public static float GetDifficultyPercent()
    {
        /*/ for max difficulty testing
            bool maxDifficulty = true;
            if (maxDifficulty == true)
            {
                return 1f;
            } else //*/
        return Mathf.Clamp(Time.time / secondsToMaxDifficulty, 0, 1);
    }
}
