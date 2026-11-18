#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

/// <summary>
/// Unity Build Automation pre-export hook.
/// Generates both first-slice scenes on the cloud Unity Editor before export.
/// Configure this method as the build target's Pre-export method:
/// FantasyCloudFirstSliceBuild.PreExport
/// </summary>
public static class FantasyCloudFirstSliceBuild
{
    public static void PreExport()
    {
        // Set the player-facing app title for cloud iOS builds.
        PlayerSettings.productName = "SMOY";
        Debug.Log("[SMOY] Player product name set to SMOY.");
        Debug.Log("[FANTASY Cloud] Generating Neo-City scene...");
        FantasyNeoCitySceneBuilder.Build();

        Debug.Log("[FANTASY Cloud] Generating Research Facility scene...");
        FantasyQuestEncounterBuilder.BuildFacility();

        Debug.Log("[FANTASY Cloud] Running first-slice scene validation...");
        FantasyFirstSliceSceneValidator.Validate();

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();

        Debug.Log("[FANTASY Cloud] Scene generation and validation hook completed. Review validation logs; this hook does not replace Play Mode or iPhone testing.");
    }
}
#endif
