# FeralBright

[![Build](https://img.shields.io/github/actions/workflow/status/FeralCompany/FeralBright/build.yml?branch=main&style=for-the-badge&logo=github)](https://github.com/FeralCompany/FeralBright/actions/workflows/build.yml)
[![Latest Version](https://img.shields.io/thunderstore/v/FeralCompany/FeralBright?style=for-the-badge&logo=thunderstore)](https://thunderstore.io/c/lethal-company/p/FeralCompany/FeralBright)
[![Total Downloads](https://img.shields.io/thunderstore/dt/FeralCompany/FeralBright?style=for-the-badge&logo=thunderstore)](https://thunderstore.io/c/lethal-company/p/FeralCompany/FeralBright)

A simple plugin with various methods of lighting up the facility.

Made as an alternative to, and inspired by, the [FullBright][1] plugin.

When configuring the color of the light, you can use any color picker you like. I personally use [this one][2].

Configuration is thoroughly explained in the configuration file itself.

## Brief Feature Overview

- Toggleable "hands-off" flashlight. Basically, a flashlight that is invisible and doesn't require you to hold it.
- Toggleable "inside sunlight". This feature allows you to toggle whether the sun's light penetrates the facility.
    - Typically, this creates a kind of "Flat" lighting effect. The "hands-off" flashlight is still useful in this mode, but it's not as necessary.
- Extremely configurable. You can change the color, intensity, and range of the light source, as well as its position relative to you. You can also
  change the pitch and yaw of the light source.
    - This can be used to create various effects such as "headlamp" or "flashlight"-style lighting.

## Integration

| Integration       | Description                                   | Required |
|-------------------|-----------------------------------------------|----------|
| [FeralCommon][3]  | A common library for all of my mods.          | Yes      |
| [LethalConfig][4] | Allows you to edit the configuration in-game. | No       |
| [InputUtils][5]   | Allows you to rebind keys in-game.            | No       |

[1]: <https://thunderstore.io/c/lethal-company/p/OndysWorks/FullBright> "FullBright by OndysWorks"

[2]: https://www.google.com/search?q=color+picker "Google Search: Color Picker"

[3]: <https://thunderstore.io/c/lethal-company/p/FeralCompany/FeralCommon> "FeralCommon by Ferus"

[4]: https://thunderstore.io/c/lethal-company/p/AinaVT/LethalConfig/ "LethalConfig by AinaVT"

[5]: https://thunderstore.io/c/lethal-company/p/Rune580/LethalCompany_InputUtils/ "InputUtils by Rune580"
