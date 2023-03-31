using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Login : MonoBehaviour {

	// Use this for initialization
	void Start () {
        LuaManager.Instance.LuaClient.luaState.DoFile("Login.lua");
        LuaManager.Instance.LuaClient.CallFunc("Login.Awake", this.gameObject);
	}
	
}
