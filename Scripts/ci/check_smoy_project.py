#!/usr/bin/env python3
"""Static repository gate for SMOY. This is not a Unity compiler or test runner."""
import json
from pathlib import Path
import sys

root = Path(__file__).resolve().parents[2]
errors = []
required = [
    "ProjectSettings/ProjectVersion.txt",
    "Packages/manifest.json",
    "Assets/Editor/FantasyCloudFirstSliceBuild.cs",
    "Assets/Editor/FantasyNeoCitySceneBuilder.cs",
    "Assets/Editor/FantasyQuestEncounterBuilder.cs",
    "Assets/Editor/FantasyFirstSliceSceneValidator.cs",
]
for rel in required:
    if not (root / rel).is_file():
        errors.append(f"Missing required project file: {rel}")

manifest = root / "Packages/manifest.json"
if manifest.is_file():
    try:
        data = json.loads(manifest.read_text(encoding="utf-8"))
        if not isinstance(data.get("dependencies"), dict):
            errors.append("Packages/manifest.json must contain a dependencies object")
    except Exception as exc:
        errors.append(f"Invalid Packages/manifest.json: {exc}")

version = root / "ProjectSettings/ProjectVersion.txt"
if version.is_file():
    value = version.read_text(encoding="utf-8")
    if "m_EditorVersion: 6000.3.28f1" not in value:
        errors.append("ProjectVersion.txt does not pin Unity 6000.3.28f1")

scene_files = list((root / "Assets").rglob("*.unity")) if (root / "Assets").exists() else []
print(f"Unity scene assets found: {len(scene_files)}")
print("NOTE: This gate checks repository completeness only; it does not compile C# or execute Unity.")
if errors:
    print("SMOY repository integrity: BLOCKED")
    for item in errors:
        print(f" - {item}")
    sys.exit(1)
print("SMOY repository integrity: PASS (static completeness only)")
