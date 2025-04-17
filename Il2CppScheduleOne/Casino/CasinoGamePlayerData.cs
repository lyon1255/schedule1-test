using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004A3 RID: 1187
	public class CasinoGamePlayerData : Object
	{
		// Token: 0x06006746 RID: 26438 RVA: 0x001D039C File Offset: 0x001CE59C
		// Note: this type is marked as 'beforefieldinit'.
		static CasinoGamePlayerData()
		{
			Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "CasinoGamePlayerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr);
			CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Parent>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "<Player>k__BackingField");
			CasinoGamePlayerData.NativeFieldInfoPtr_bools = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "bools");
			CasinoGamePlayerData.NativeFieldInfoPtr_floats = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, "floats");
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676388);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676389);
			CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676390);
			CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676391);
			CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676392);
			CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676393);
			CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr, 100676394);
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06006747 RID: 26439 RVA: 0x001D04A8 File Offset: 0x001CE6A8
		// (set) Token: 0x06006748 RID: 26440 RVA: 0x001D04E8 File Offset: 0x001CE6E8
		public unsafe CasinoGamePlayers Parent
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x001D052C File Offset: 0x001CE72C
		// (set) Token: 0x0600674A RID: 26442 RVA: 0x001D056C File Offset: 0x001CE76C
		public unsafe Player Player
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_get_Player_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Player>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x001D05B0 File Offset: 0x001CE7B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 208930, RefRangeEnd = 208935, XrefRangeStart = 208903, XrefRangeEnd = 208930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CasinoGamePlayerData(CasinoGamePlayers parent, Player player) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(player);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x001D0610 File Offset: 0x001CE810
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 208967, RefRangeEnd = 208978, XrefRangeStart = 208935, XrefRangeEnd = 208967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetData<T>(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_GetData_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x001D065C File Offset: 0x001CE85C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 209025, RefRangeEnd = 209031, XrefRangeStart = 208978, XrefRangeEnd = 209025, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetData<T>(string key, T value, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr* ptr2 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T ptr4;
			if (!typeof(T).IsValueType)
			{
				T t = value;
				if (!(t is string))
				{
					ref T ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
					if (ref ptr3 != null)
					{
						ptr4 = ref ptr3;
						if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr3)))
						{
							ptr4 = IL2CPP.il2cpp_object_unbox(ref ptr3);
						}
					}
				}
				else
				{
					ptr4 = IL2CPP.ManagedStringToIl2Cpp(t as string);
				}
			}
			else
			{
				ptr4 = ref value;
			}
			*ptr2 = ref ptr4;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CasinoGamePlayerData.MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00030C8A File Offset: 0x0002EE8A
		public CasinoGamePlayerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x001D070C File Offset: 0x001CE90C
		// (set) Token: 0x06006750 RID: 26448 RVA: 0x00030C93 File Offset: 0x0002EE93
		public unsafe CasinoGamePlayers _Parent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CasinoGamePlayers>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Parent_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x001D073C File Offset: 0x001CE93C
		// (set) Token: 0x06006752 RID: 26450 RVA: 0x00030CB2 File Offset: 0x0002EEB2
		public unsafe Player _Player_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr__Player_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06006753 RID: 26451 RVA: 0x001D076C File Offset: 0x001CE96C
		// (set) Token: 0x06006754 RID: 26452 RVA: 0x00030CD1 File Offset: 0x0002EED1
		public unsafe Dictionary<string, bool> bools
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_bools), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06006755 RID: 26453 RVA: 0x001D079C File Offset: 0x001CE99C
		// (set) Token: 0x06006756 RID: 26454 RVA: 0x00030CF0 File Offset: 0x0002EEF0
		public unsafe Dictionary<string, float> floats
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CasinoGamePlayerData.NativeFieldInfoPtr_floats), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040046B2 RID: 18098
		private static readonly IntPtr NativeFieldInfoPtr__Parent_k__BackingField;

		// Token: 0x040046B3 RID: 18099
		private static readonly IntPtr NativeFieldInfoPtr__Player_k__BackingField;

		// Token: 0x040046B4 RID: 18100
		private static readonly IntPtr NativeFieldInfoPtr_bools;

		// Token: 0x040046B5 RID: 18101
		private static readonly IntPtr NativeFieldInfoPtr_floats;

		// Token: 0x040046B6 RID: 18102
		private static readonly IntPtr NativeMethodInfoPtr_get_Parent_Public_get_CasinoGamePlayers_0;

		// Token: 0x040046B7 RID: 18103
		private static readonly IntPtr NativeMethodInfoPtr_set_Parent_Private_set_Void_CasinoGamePlayers_0;

		// Token: 0x040046B8 RID: 18104
		private static readonly IntPtr NativeMethodInfoPtr_get_Player_Public_get_Player_0;

		// Token: 0x040046B9 RID: 18105
		private static readonly IntPtr NativeMethodInfoPtr_set_Player_Private_set_Void_Player_0;

		// Token: 0x040046BA RID: 18106
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CasinoGamePlayers_Player_0;

		// Token: 0x040046BB RID: 18107
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_T_String_0;

		// Token: 0x040046BC RID: 18108
		private static readonly IntPtr NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0;

		// Token: 0x02000A3F RID: 2623
		private sealed class MethodInfoStoreGeneric_GetData_Public_T_String_0<T>
		{
			// Token: 0x04008C28 RID: 35880
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_GetData_Public_T_String_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000A40 RID: 2624
		private sealed class MethodInfoStoreGeneric_SetData_Public_Void_String_T_Boolean_0<T>
		{
			// Token: 0x04008C29 RID: 35881
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(CasinoGamePlayerData.NativeMethodInfoPtr_SetData_Public_Void_String_T_Boolean_0, Il2CppClassPointerStore<CasinoGamePlayerData>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
