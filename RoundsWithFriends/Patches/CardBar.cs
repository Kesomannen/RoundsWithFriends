using HarmonyLib;
using UnityEngine;

namespace RWF.Patches
{
    [HarmonyPatch(typeof(CardBar), "Start")]
    class CardBar_Patch_Start
    {
        static void Postfix(CardBar __instance)
        {
            // expand the bar to make room for more card buttons
            var rect = __instance.GetComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 1);
        }
    }
}