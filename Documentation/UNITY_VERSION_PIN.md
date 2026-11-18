# SMOY Unity editor baseline

## Pinned editor

- Unity Editor: **6000.3.28f1 (Unity 6.3 LTS)**
- Project version file: `ProjectSettings/ProjectVersion.txt`
- Selected because Unity's official release notes list this exact patch as released on 3 November 2026, and Unity identifies 6.3 as its current LTS line.

Official references:
- https://unity.com/releases/editor/whats-new/6000.3.28f1
- https://unity.com/releases/unity-6/support

## Why this is pinned

A reproducible editor version is needed before a cloud build can import and compile the project. Do not let cloud build silently select a different editor version.

## Remaining validation

This version pin does **not** mean the project has been opened or compiled. The canonical source ZIP still needs to be integrated into the repository. Then Unity Build Automation must import the project, run the configured pre-export scene-generation method, and produce logs. Any compile/import errors must be fixed before a device build is attempted.

## Mobile-only constraint

The project owner uses an iPhone and has no local desktop Unity Editor. The intended path is a managed/cloud Unity Editor build environment. If that service cannot run the project import and pre-export method, a trusted computer with Unity Editor or a third-party managed Unity development service will still be required.
