# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.1.0/ 'Keep a Changelog, 1.1.0'),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html 'Semantic Versioning, 2.0.0').

## [Unreleased]

- Nothing, yet.

## Version [v1.1.0] (2024-04-23)

### Changed

- Better looking mod icon.
- Updated `FeralCommon` to `v0.1.3`

### Fixed

- Fixed the sun having a preference for where you were looking.
- Fixed the sun blasting your minimap with light.
- Your flashlight no longer shows up on the minimap.
- Fixed your flashlight sometimes shining behind you.

## Version [v1.0.0] (2024-04-19)

### Changed

- Use custom sun object instead of `sunIndirect`.
    - This allows for much better control over the appearance, in my opinion. Seems more reliable, as well.
- Patch `ConnectClientToPlayerObject` instead of Coroutine for detecting player assignment.
- Updated defaults for Sun Intensity config.
- Updated `FeralCommon` to `v0.1.0`
- Updated `LethalConfig` to `v1.4.1`

### Trivial

- Pull `CONTRIBUTING.md` and `thunderstore.toml` into solution view.
- Specify `LethalConfig` and `InputUtils` as dependencies instead of allowing them to be transitive.
- Strip some outdated and unnecessary information from README.md

## Version [v0.0.1] (2024-04-14)

### Added

- Initial release
- Ability to toggle indoor sun visibility
- Ability to toggle a "hands-free" flashlight
- Each feature is very configurable
