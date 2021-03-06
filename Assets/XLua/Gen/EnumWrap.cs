#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    
    public class QPFrameworkShowTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(QP.Framework.ShowType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(QP.Framework.ShowType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(QP.Framework.ShowType), L, null, 6, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", QP.Framework.ShowType.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CloseLastOne", QP.Framework.ShowType.CloseLastOne);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "CloseLastAll", QP.Framework.ShowType.CloseLastAll);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DestroyOne", QP.Framework.ShowType.DestroyOne);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "DestroyAll", QP.Framework.ShowType.DestroyAll);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(QP.Framework.ShowType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushQPFrameworkShowType(L, (QP.Framework.ShowType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushQPFrameworkShowType(L, QP.Framework.ShowType.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CloseLastOne"))
                {
                    translator.PushQPFrameworkShowType(L, QP.Framework.ShowType.CloseLastOne);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "CloseLastAll"))
                {
                    translator.PushQPFrameworkShowType(L, QP.Framework.ShowType.CloseLastAll);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DestroyOne"))
                {
                    translator.PushQPFrameworkShowType(L, QP.Framework.ShowType.DestroyOne);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "DestroyAll"))
                {
                    translator.PushQPFrameworkShowType(L, QP.Framework.ShowType.DestroyAll);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for QP.Framework.ShowType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for QP.Framework.ShowType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class QPFrameworkPanelStatusWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(QP.Framework.PanelStatus), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(QP.Framework.PanelStatus), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(QP.Framework.PanelStatus), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "None", QP.Framework.PanelStatus.None);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Show", QP.Framework.PanelStatus.Show);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Close", QP.Framework.PanelStatus.Close);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(QP.Framework.PanelStatus), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushQPFrameworkPanelStatus(L, (QP.Framework.PanelStatus)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "None"))
                {
                    translator.PushQPFrameworkPanelStatus(L, QP.Framework.PanelStatus.None);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Show"))
                {
                    translator.PushQPFrameworkPanelStatus(L, QP.Framework.PanelStatus.Show);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Close"))
                {
                    translator.PushQPFrameworkPanelStatus(L, QP.Framework.PanelStatus.Close);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for QP.Framework.PanelStatus!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for QP.Framework.PanelStatus! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class QPFrameworkCanvasTypeWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(QP.Framework.CanvasType), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(QP.Framework.CanvasType), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(QP.Framework.CanvasType), L, null, 4, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Fixed", QP.Framework.CanvasType.Fixed);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Normal", QP.Framework.CanvasType.Normal);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "Top", QP.Framework.CanvasType.Top);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(QP.Framework.CanvasType), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushQPFrameworkCanvasType(L, (QP.Framework.CanvasType)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "Fixed"))
                {
                    translator.PushQPFrameworkCanvasType(L, QP.Framework.CanvasType.Fixed);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Normal"))
                {
                    translator.PushQPFrameworkCanvasType(L, QP.Framework.CanvasType.Normal);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "Top"))
                {
                    translator.PushQPFrameworkCanvasType(L, QP.Framework.CanvasType.Top);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for QP.Framework.CanvasType!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for QP.Framework.CanvasType! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class XLuaTestMyEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(XLuaTest.MyEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(XLuaTest.MyEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(XLuaTest.MyEnum), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", XLuaTest.MyEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", XLuaTest.MyEnum.E2);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(XLuaTest.MyEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushXLuaTestMyEnum(L, (XLuaTest.MyEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushXLuaTestMyEnum(L, XLuaTest.MyEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushXLuaTestMyEnum(L, XLuaTest.MyEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for XLuaTest.MyEnum!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for XLuaTest.MyEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialTestEnumWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.TestEnum), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.TestEnum), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.TestEnum), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E1", Tutorial.TestEnum.E1);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E2", Tutorial.TestEnum.E2);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.TestEnum), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialTestEnum(L, (Tutorial.TestEnum)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "E1"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E1);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E2"))
                {
                    translator.PushTutorialTestEnum(L, Tutorial.TestEnum.E2);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.TestEnum!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.TestEnum! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
    public class TutorialDrivenClassTestEnumInnerWrap
    {
		public static void __Register(RealStatePtr L)
        {
		    ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
		    Utils.BeginObjectRegister(typeof(Tutorial.DrivenClass.TestEnumInner), L, translator, 0, 0, 0, 0);
			Utils.EndObjectRegister(typeof(Tutorial.DrivenClass.TestEnumInner), L, translator, null, null, null, null, null);
			
			Utils.BeginClassRegister(typeof(Tutorial.DrivenClass.TestEnumInner), L, null, 3, 0, 0);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E3", Tutorial.DrivenClass.TestEnumInner.E3);
            
            Utils.RegisterObject(L, translator, Utils.CLS_IDX, "E4", Tutorial.DrivenClass.TestEnumInner.E4);
            
			Utils.RegisterFunc(L, Utils.CLS_IDX, "__CastFrom", __CastFrom);
            
            Utils.EndClassRegister(typeof(Tutorial.DrivenClass.TestEnumInner), L, translator);
        }
		
		[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CastFrom(RealStatePtr L)
		{
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			LuaTypes lua_type = LuaAPI.lua_type(L, 1);
            if (lua_type == LuaTypes.LUA_TNUMBER)
            {
                translator.PushTutorialDrivenClassTestEnumInner(L, (Tutorial.DrivenClass.TestEnumInner)LuaAPI.xlua_tointeger(L, 1));
            }
			
            else if(lua_type == LuaTypes.LUA_TSTRING)
            {
			    if (LuaAPI.xlua_is_eq_str(L, 1, "E3"))
                {
                    translator.PushTutorialDrivenClassTestEnumInner(L, Tutorial.DrivenClass.TestEnumInner.E3);
                }
				else if (LuaAPI.xlua_is_eq_str(L, 1, "E4"))
                {
                    translator.PushTutorialDrivenClassTestEnumInner(L, Tutorial.DrivenClass.TestEnumInner.E4);
                }
				else
                {
                    return LuaAPI.luaL_error(L, "invalid string for Tutorial.DrivenClass.TestEnumInner!");
                }
            }
			
            else
            {
                return LuaAPI.luaL_error(L, "invalid lua type for Tutorial.DrivenClass.TestEnumInner! Expect number or string, got + " + lua_type);
            }

            return 1;
		}
	}
    
}