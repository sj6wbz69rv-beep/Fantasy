# SMOY — Project Status

## First playable slice source
This repository is the home for the SMOY Unity project.

The current first-slice source package is a Unity project skeleton for the Neo-City to Research Facility quest: **The Missing Signal**.

### Planned source systems
- Third-person movement and mobile input foundations
- Neo-City and Research Facility scene builders
- Quest flow, enemy encounter, combat, respawn, and reward foundations
- Local quest persistence, validation, backup recovery, and reward-claim deduplication
- First-slice scene validator

### Validation status
The source package is not a compiled iOS app. Unity Editor scene generation, Unity compilation, Play Mode testing, and iPhone testing have not yet been completed. Static source checks do not replace those tests.

### Next gates
1. Upload and integrate the consolidated Unity source package.
2. Open it in a compatible Unity Editor environment.
3. Generate both scenes using the editor menu items included in the source.
4. Run the first-slice scene validator.
5. Resolve compile and runtime issues.
6. Configure a remote iOS build and signing when Apple Developer credentials are available.

Never commit passwords, API keys, signing certificates, provisioning profiles, or other secrets to this repository.
