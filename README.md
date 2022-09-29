# modern-playerprefs
An API that extends Unity's PlayerPrefs to save and load additional data types.

------

### Public Methods

`PlayerPrefsExtended.Save()` - Save all keys.

`PlayerPrefsExtended.DeleteAll()` - Delete all keys from PlayerPrefs.

`PlayerPrefsExtended.DeleteKey(string key)` - Delete the specified key if it exists.

`PlayerPrefsExtended.HasKey(string key)` - (bool) Returns true if the specified key exists.

------

### Saving/Loading Data 

`PlayerPrefsExtended.SetString(string key, string value)` - Save a string to disk.

`PlayerPrefsExtended.SetBool(string key, bool value)` - Save a bool to disk.

`PlayerPrefsExtended.SetVector3(string key, Vector3 value)` - Save a Vector3 to disk.

`PlayerPrefsExtended.GetString(string key, string default)` - (String) Returns the string saved on disk.

`PlayerPrefsExtended.GetBool(string key, bool default)` - (Bool) Returns the bool saved on disk.

`PlayerPrefsExtended.GetVector3(string key, Vector3 default)` - (Vector3) Returns the Vector3 saved on disk.

------

### Supported Data Types

- Bool
- Int
- Float
- String
- Vector2
- Vector3
- Vector4
- Color
- Double
- Decimal
- Char
- Char[]
- Transform

------

### TO-DO

- Save/load List
- Save/load Dictionary
- Save/load Object
- Save/load JSON
- Save/load DateTime
- Save/load TimeSpan
- Save/load Color32
- Save/load Light
- Save/load Ray
- Save/load Ray2D
- Save/load RaycastHit
- Save/load RaycastHit2D
- Save/load Touch
- Save/load Vector2Int
- Save/load Vector3Int
- Save/load Quaternion
- Save/load Mesh
- Save/load Box Collider 2D
- Save/load Capsule Collider 2D
- Save/load Circle Collider 2D
- Save/load Polygon Collider 2D
- Save/load Box Collider
- Save/load Capsule Collider
- Save/load Mesh Collider
- Save/load Sphere Collider
- Save/load Terrain Collider
- Don't allow set/get if key name is empty
- Test backwards compatability
- List active PlayerPrefs in editor
- Search for PlayerPrefs in editor window
- Change PlayerPrefs values in editor at runtime
- Encrypt/decrypt support with AES
- Save arrays of data types
- Put items into groups
- Filter editor list of data types
- Search for items by key names in editor
- Save and load custom data types with System.Serializable
- Save List, Array, Dictionary, Hashset
- Prevent deletion of keys on iOS update
- Force refresh editor window
- Cheat detection (variable changed on the fly)
- Cheat events
- Save entire Unity components and prefabs
- Export/import key files
- JSON support
- Playmaker support
- Bolt support
- Playfab support
- Setup wizard
