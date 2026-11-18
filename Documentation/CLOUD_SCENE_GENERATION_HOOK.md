# FANTASY — Cloud scene-generation hook

## What this adds
The Unity Build Automation pre-export hook at `Assets/Editor/FantasyCloudFirstSliceBuild.cs` runs the existing scene builders in the cloud Unity Editor:

1. `FantasyNeoCitySceneBuilder.Build()`
2. `FantasyQuestEncounterBuilder.BuildFacility()`
3. `FantasyFirstSliceSceneValidator.Validate()`

This removes the need to open the Unity Editor locally just to execute those two menu commands, **once the complete Unity source project is committed and configured in Unity Build Automation**.

## Required Build Automation configuration
- Source repository: this private FANTASY repository.
- Unity Editor version: must match the version used by the project.
- Pre-export method: `FantasyCloudFirstSliceBuild.PreExport`.
- Build target: iOS.
- Configure Apple signing only in Unity's secure signing settings; never commit certificates or profiles.

## Important limits
- This hook cannot help until the full Unity source package (including the two scene-builder classes and validator) is present in the repository.
- The current repository still needs the consolidated Unity project source and a valid Unity project version/settings.
- A successful pre-export hook is not proof of successful compilation, Play Mode behavior, or iPhone installation.
- Inspect the validator output in the build log. The current validator reports errors to the log; it is not yet a formal automated test gate.
- iOS distribution/signing has separate Apple account and provisioning requirements.

## Official Unity references
- [Build Automation](https://docs.unity.com/en-us/build-automation)
- [Run custom scripts during the build process](https://docs.unity.com/en-us/build-automation/advanced-build-configuration/run-custom-scripts-during-the-build-process)
- [Set up an iOS build configuration](https://docs.unity.com/en-us/build-automation/basic-build-configuration/set-up-an-ios-build-configuration)
