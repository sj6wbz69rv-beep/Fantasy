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
        PlayerSettings.companyName = "SMOY";
        PlayerSettings.bundleVersion = "0.1.0";
        Debug.Log("[SMOY] iOS player branding set: product SMOY, company SMOY, version 0.1.0.");
        Debug.Log("[SMOY Cloud] Generating Neo-City scene...");
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
