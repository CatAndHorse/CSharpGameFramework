﻿using System;

using SLua;
using System.Collections.Generic;
public class Lua_UnityEngine_AnimatorClipInfo : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int constructor(IntPtr l) {
		try {
			UnityEngine.AnimatorClipInfo o;
			o=new UnityEngine.AnimatorClipInfo();
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_clip(IntPtr l) {
		try {
			UnityEngine.AnimatorClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.clip);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static public int get_weight(IntPtr l) {
		try {
			UnityEngine.AnimatorClipInfo self;
			checkValueType(l,1,out self);
			pushValue(l,true);
			pushValue(l,self.weight);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	static public void reg(IntPtr l) {
		getTypeTable(l,"UnityEngine.AnimatorClipInfo");
		addMember(l,"clip",get_clip,null,true);
		addMember(l,"weight",get_weight,null,true);
		createTypeMetatable(l,constructor, typeof(UnityEngine.AnimatorClipInfo),typeof(System.ValueType));
	}
}
