# SMOY repository integrity gate

GitHub Actions runs `Scripts/ci/check_smoy_project.py` on pushes and pull requests to `main`.

It checks for the Unity version pin, package manifest, cloud build hook, both scene builders, and scene validator. It also parses the package manifest and counts generated Unity scene files.

A passing result means only that the expected project files are present and basic metadata is consistent. It does **not** mean C# compiled, Unity imported the project, scenes were generated, Play Mode passed, or an iPhone build was tested.

The check is intentionally expected to fail until the consolidated source archive is integrated into `Assets/`. That visible failure is preferable to a misleading green build.
