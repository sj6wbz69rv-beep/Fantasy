# SMOY first playable slice — current status

## Source archive audit (static only)
The prepared CloudReady archive contains:
- 105 total files, including 63 C# source files.
- 82 declared C# types, with no duplicate type names found by the static scan.
- No delimiter-balance issues found by the static scan.
- Zero generated Unity scene files (`.unity`).

These are source-structure checks only. They do not establish that Unity can import or compile the project.

## Included in the separate source archive
- Third-person movement and mobile touch controls.
- Neo-City and Research Facility scene-builder scripts.
- The Missing Signal quest encounter, enemy defeat progression, NEXUS core pickup, return dialogue, and reward claim flow.
- Local quest persistence, reward-claim deduplication, and backup recovery.
- Scene validator and integration documentation.

## Repository integration status
This GitHub repository contains the Unity 6.3.28f1 version pin, Unity package manifest, SMOY cloud pre-export hook, and project documentation. The complete gameplay source archive has not yet been committed under `Assets/`.

## Verification truth
- The archive passed a lightweight static count/type/delimiter audit.
- Unity Editor has not been run in this environment.
- Scene builders and scene validator have not been executed.
- Unity compilation, Play Mode, iPhone touch/performance testing, iOS signing, and TestFlight/device distribution have not been performed.
- This is not an IPA, a finished playable game, or a production MMO backend.

## Next required validation
1. Integrate the complete source archive into this repository.
2. Open with Unity Editor 6000.3.28f1 and resolve package/import/compiler errors.
3. Generate Neo-City and Research Facility scenes using the SMOY editor menu items.
4. Run the scene validator and fix every reported error.
5. Test quest progression, reward claim, save recovery, respawn, joystick and camera look in Play Mode.
6. Configure remote iOS signing/build and test on a real iPhone.

## Branding
The player-facing app title and company name are set to SMOY by the cloud pre-export hook. Legacy Fantasy-prefixed C# type names remain for compatibility; editor menu paths use SMOY.
