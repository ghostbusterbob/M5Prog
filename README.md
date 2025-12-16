# Opdracht 1
<img src = "https://github.com/ghostbusterbob/M5Prog/blob/main/GIF1.gif">
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/Les1/opdracht%201/Scripts/NewBehaviourScript.cs

In deze opdracht heb ik geleerd door een hoeveelheid objects, op random plekken te laten inspawnen en een wilkeurige kleur te geven en te aten vallen met een rigid body.

# Opdracht 2
<img src = "https://github.com/ghostbusterbob/M5Prog/blob/main/GIF2.gif">
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/Les1/opdracht%202/Scripts/TowerSpawner.cs

in deze opdracht heb ik geleerd door te klikken, torens te laten in een random range dat ik zelf heb aangegeven en door te klikken dat ze instantiate


# Opdracht 3
<img src = "https://github.com/ghostbusterbob/M5Prog/blob/main/GIF3.gif">
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/Les1/Opdracht%203/Scripts/EnemySpawner.cs

in deze les heb ik geleerd optimaal lists en arrays te kunnen gebruiken, door iedere keer als je op W klikt er blokken in spawnen en met Q verdwijnen ze

# Opdracht 4
![GIF3](https://github.com/user-attachments/assets/f5fe7900-b082-4765-a972-bb71ce3dd79d)
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/pickup.cs

in deze opdracht heb ik geleerd met events werken, heb hier een pickup script en character controller gemaakt

# Opdracht 5 (Debugging)
https://github.com/ghostbusterbob/TowerDefense2D

hier heb ik geleerd goed en krachtig bugs te reporten, voor eigen overzichtelijkheid en dat ik later verder kan gaan met de bugs oplossen

# Opdracht 6/7
Scripts: https://github.com/ghostbusterbob/Space48/tree/main/Assets/Scripts

Ik heb ik single responsibilty geleerd en don't repeat yourself

# Opdracht 8 
![GIFINHER](https://github.com/user-attachments/assets/f675f5ab-b7aa-4c4b-82d4-d4354b6e9eb7)

Scripts: https://github.com/ghostbusterbob/M5Prog/tree/main/Assets/Lessen/Les5/Scripts

# M6
# Les 1 - Code Conventies
Scripts: 
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/M6/InventoryItem.cs
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/M6/InventorySystem.cs
https://github.com/ghostbusterbob/M5Prog/blob/main/Assets/Lessen/M6/Keycard.cs
https://github.com/BadTimeForU/GD-M5-PROG/blob/main/Assets/Scripts/m6/Weapon.cs

Ik heb hier geprobeerd om goede code structuur te gebruiken en toe te passen


## Class Diagram
This diagram shows the main systems used in the game.

```mermaid
classDiagram
    class CoreHealth {
        -int startingHealth
        -Slider healthUI
        +ApplyDamage(int amount) void
        -VerifyHealth() void
    }

    class HeroHealth {
        -float currentHP
        +ReceiveHit(float dmg) void
    }

    class PlayerDamageHandler {
        -HeroHealth heroHealth
        +TriggerDamage() void
    }

    class EnemyStats {
        -float hp
        -int rewardValue
        -TextMeshProUGUI hpDisplay
        +InitializeHP(float value) void
        +ReduceHP(float value) void
        -EvaluateHP() void
    }

    class PathNavigator {
        -List~Transform~ pathNodes
        -float moveSpeed
        -PathProvider provider
        -int nodeIndex
        -float baseSpeed
        +ApplySlow() IEnumerator
    }

    class PathProvider {
        -List~Transform~ nodes
        +FetchNodes() List~Transform~
    }

    class Turret {
        -GameObject bulletPrefab
        -float fireRate
        -float detectionRadius
        -Transform currentTarget
        +bool placed
        -AcquireTarget() void
        -RotateTowards(Transform t) void
        -Fire() IEnumerator
    }

    class TurretInfo {
        +int price
    }

    class BuildSystem {
        -Camera cam
        -List~GameObject~ turretOptions
        -CurrencySystem currencySystem
        -TurretRemoval remover
        -GameObject previewTurret
        -bool placingTurret
        +int turretCount
        +SelectTurret(int index) void
        -StartPlacement(int index) void
        -FollowMouse() void
        -ConfirmPlacement() void
    }

    class TurretRemoval {
        -Button sellBtn
        -List~Transform~ placedTurrets
        -CurrencySystem currencySys
        -BuildSystem buildSys
        -Sell() void
    }

    class Bullet {
        -Transform target
        -float travelSpeed
        -float maxDistance
        -int dmg
        -bool applySlow
        -Vector3 spawnPoint
        -OnTriggerEnter2D(Collider2D col) void
    }

    class CurrencySystem {
        -TextMeshProUGUI uiText
        +int Balance
        +Gain(int amount) void
        +Spend(int amount) void
    }

    class WaveController {
        -WaveSet[] waveSets
        -float delayBetweenWaves
        -Spawner spawner
        -int index
        -float timer
        +int activeEnemies
    }

    class WaveSet {
        +int quantity
        +float spawnRate
    }

    class Spawner {
        -WaveController controller
        -GameObject enemyPrefab
        +Spawn(int count, float rate) IEnumerator
    }

    class StoreUI {
        -GameObject uiPanel
        -Transform openButton
        -bool sliding
        -Vector3 slideTarget
        -Vector3 startPos
        +Toggle() void
    }

    class StartBtn {
        -Button btn
        -BeginGame() void
    }

    class QuitBtn {
        -Button btn
        -QuitGame() void
    }

    PlayerDamageHandler --> HeroHealth
    EnemyStats --> CurrencySystem
    PathNavigator --> PathProvider
    PathNavigator --> CoreHealth
    Turret --> Bullet
    BuildSystem --> TurretInfo
    BuildSystem --> CurrencySystem
    BuildSystem --> TurretRemoval
    TurretRemoval --> BuildSystem
    TurretRemoval --> CurrencySystem
    Bullet --> EnemyStats
    Bullet --> PathNavigator
    WaveController --> Spawner
    Spawner --> WaveController
    WaveController --> WaveSet



