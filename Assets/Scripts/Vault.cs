using UnityEngine;
using Newtonsoft.Json;

public class Vault
{
	public void SaveData(object obj, string key)
	{
		PlayerPrefs.SetString(key, JsonConvert.SerializeObject(obj));
	}
	public T GetSavedData<T>(string key, T defaultVal = default(T))
	{
		if (!PlayerPrefs.HasKey(key)) return defaultVal;

		return JsonConvert.DeserializeObject<T>(PlayerPrefs.GetString(key));
	}
	public void DeleteData(string key)
	{
		PlayerPrefs.DeleteKey(key);
	}
	public void DeleteAllData()
	{
		PlayerPrefs.DeleteAll();
	}
}