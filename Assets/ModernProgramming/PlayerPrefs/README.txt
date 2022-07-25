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