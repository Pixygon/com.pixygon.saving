# Pixygon — Saving

Persistence for Pixygon games: save slots, the data-access layer, and the shared
**save-data classes**. Several of these classes are the seeds the platform's
avatar / anima / profile systems build on.

## Overview

Save data implements `ISaveData` and is managed through a `DataContext` /
`Repository` / `UnitOfWork` pattern, with slot UI and an autosave timer. Each game
holds its own save file, but the *shapes* of key data (avatar, creature, account)
are shared so they can travel across games.

## Key types

| Type | What it is |
|---|---|
| **`SaveManager`** | Central save/load entry (e.g. `SaveManager.SettingsSave`). |
| **`SaveFile` / `SaveSlot` / `SaveSlotUI` / `SaveTimer`** | Save slots + UI + autosave. |
| **`DataContext` / `Repository` / `UnitOfWork`** | Data-access layer. |
| **`ISaveData`** | Marker interface every save-data class implements. |
| **`AvatarData`** | ⭐ A **complete Mii-like avatar spec** — body/skin/eyes/hair + all clothing slots + accessories + tools + body-height + cyberware, as int-IDs, with array↔JSON converters + random gen. **The seed for `com.pixygon.avatar`** (kept here so it stays tied to each game's save). |
| **`CreatureSaveData`** | Currently an **empty stub** — the seed for `com.pixygon.anima` (captured/owned creatures). |
| **`SettingsSaveData`** + **`AccountData`** | Settings + a snapshot of the logged-in account (gameXp/streamerXp/wallets/…). **The seed for a cross-game `profile` package.** |
| **`InventorySaveData` / `ItemSaveSlots`** | Inventory persistence. |
| **`AffinitySaveDatas` / `QuestsSaveData` / `PhotoSaveDatas` / `IntroSaveData` / `CustomMarkerSaveDatas`** | Per-feature save blobs. |

## Dependencies

`com.pixygon.pagedcontent`.

## Usage

```csharp
var avatar = AvatarDataHelper.RandomAvatarData();   // or NewAvatarData
SaveManager.SettingsSave._user = account;           // AccountData snapshot
```

## Status

`0.5.0`. **Platform note:** `AvatarData` / `CreatureSaveData` / `AccountData` are the
data seeds for the planned `avatar` / `anima` / `profile` packages — those packages
will depend on `saving` for the types (keeps the dependency graph acyclic). See
`ACTORS_AVATAR_ANIMA.md`. Avatars stay tied to each game's save (curated / local /
profile-global modes per game).
