﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FieldDescriptorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FieldDescriptor), typeof(System.Object));
		L.RegFunction("New", _CreateFieldDescriptor);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("Define", get_Define, null);
		L.RegVar("Type", get_Type, null);
		L.RegVar("Number", get_Number, null);
		L.RegVar("MessageType", get_MessageType, null);
		L.RegVar("IsRepeated", get_IsRepeated, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFieldDescriptor(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				google.protobuf.FieldDescriptorProto arg0 = (google.protobuf.FieldDescriptorProto)ToLua.CheckObject(L, 1, typeof(google.protobuf.FieldDescriptorProto));
				FieldDescriptor obj = new FieldDescriptor(arg0);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FieldDescriptor.New");
			}
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Define(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FieldDescriptor obj = (FieldDescriptor)o;
			google.protobuf.FieldDescriptorProto ret = obj.Define;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Define on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Type(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FieldDescriptor obj = (FieldDescriptor)o;
			int ret = obj.Type;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Type on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Number(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FieldDescriptor obj = (FieldDescriptor)o;
			int ret = obj.Number;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Number on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_MessageType(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FieldDescriptor obj = (FieldDescriptor)o;
			Descriptor ret = obj.MessageType;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index MessageType on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsRepeated(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FieldDescriptor obj = (FieldDescriptor)o;
			bool ret = obj.IsRepeated;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsRepeated on a nil value" : e.Message);
		}
	}
}
