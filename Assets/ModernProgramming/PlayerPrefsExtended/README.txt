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