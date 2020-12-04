# PlayersTimeSaver
### RocketMod Unturned Plugin ### 


### How to install ###
1. Download plugin (*[dll](https://github.com/AuD1tek/PlayersTimeSaver/releases/download/1.2/PlayersTimeSaver.dll)* | *[last release](https://github.com/AuD1tek/PlayersTimeSaver/releases/tag/1.2)*)
1. Go to the directory with path: *..\Unturned\Servers\SERVER_ID\Rocket\Plugins*
1. Drop *PlayersTimeSaver.dll* into the directory
1. Start the server and enjoy

### Saving: ###
- TotalPlayingTime        - *total time the player played on the server in seconds*
- LastSessionPlayingTime  - *game time on the server in seconds of the last session*
- DateFirstConnection     - *date of first login to the server*
- DateLastConnection      - *date of last login to the server*

**Path:** *..\Unturned\Servers\SERVER_ID\Players\PLAYER_ID\MAP_NAME\Player\Time.dat*

![img](https://github.com/AuD1tek/PlayersTimeSaver/blob/master/image.png)


### Player time component ###
```csharp
public class PlayerTimeComponent : UnturnedPlayerComponent
```
#### Properties: ####

*>* **Total time the player played on the server in seconds**
```csharp
public float TotalPlayingTime { get; }
```

*>* **Game time on the server in seconds of the last session**
```csharp
public float LastSessionPlayingTime { get; }
```

*>* **Date of first login to the server**
```csharp
public DateTime DateFirstConnection { get; }
```

*>* **Date of last login to the server**
```csharp
public DateTime DateLastConnection { get; }
```

*>* **Time in seconds of the current session**
```csharp
public float CurrentSessionPlayingTime { get; }
```

*>* **Date of connection to the current session**
```csharp
public float DateCurrentSessionConnection { get; }
```
