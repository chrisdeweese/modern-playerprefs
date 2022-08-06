# modern-playerprefs
An API that extends Unity's PlayerPrefs to save and load additional data types.

------

### Public Methods

`PlayerPrefsExtended.Save()` - Save all keys.

`PlayerPrefsExtended.DeleteAll()` - Delete all keys from PlayerPrefs.

`PlayerPrefsExtended.DeleteKey(string key)` - Delete the specified key if it exists.

`PlayerPrefsExtended.HasKey(string key)` - (bool) Returns true if the specified key exists.

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
- Write script documentation
- Test backwards compatability
- List active PlayerPrefs in editor
- Search for PlayerPrefs in editor window
- Change PlayerPrefs values in editor at runtime
- Encrypt/decrypt support
- Setup wizard
- Save method
- Demo scenes
