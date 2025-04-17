using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000261 RID: 609
	[Serializable]
	public class GenericSaveData : SaveData
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x00106610 File Offset: 0x00104810
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveData()
		{
			Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GenericSaveData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr);
			GenericSaveData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "GUID");
			GenericSaveData.NativeFieldInfoPtr_boolValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "boolValues");
			GenericSaveData.NativeFieldInfoPtr_floatValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "floatValues");
			GenericSaveData.NativeFieldInfoPtr_intValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "intValues");
			GenericSaveData.NativeFieldInfoPtr_stringValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "stringValues");
			GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668736);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668737);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668738);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668739);
			GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668740);
			GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668741);
			GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668742);
			GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668743);
			GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, 100668744);
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x00106758 File Offset: 0x00104958
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130487, RefRangeEnd = 130489, XrefRangeStart = 130454, XrefRangeEnd = 130487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveData(string guid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x001067A4 File Offset: 0x001049A4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130497, RefRangeEnd = 130499, XrefRangeStart = 130489, XrefRangeEnd = 130497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x001067F4 File Offset: 0x001049F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130499, XrefRangeEnd = 130507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x00106844 File Offset: 0x00104A44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130515, RefRangeEnd = 130517, XrefRangeStart = 130507, XrefRangeEnd = 130515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, int value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00106894 File Offset: 0x00104A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130517, XrefRangeEnd = 130526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(string key, string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_Add_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x001068E8 File Offset: 0x00104AE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130540, RefRangeEnd = 130542, XrefRangeStart = 130526, XrefRangeEnd = 130540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool GetBool(string key, bool defaultValue = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x00106944 File Offset: 0x00104B44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130542, XrefRangeEnd = 130556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetFloat(string key, float defaultValue = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x001069A0 File Offset: 0x00104BA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130570, RefRangeEnd = 130572, XrefRangeStart = 130556, XrefRangeEnd = 130570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetInt(string key, int defaultValue = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref defaultValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x001069FC File Offset: 0x00104BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 130572, XrefRangeEnd = 130586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetString(string key, string defaultValue = "")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(defaultValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.NativeMethodInfoPtr_GetString_Public_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x00018DAF File Offset: 0x00016FAF
		public GenericSaveData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x00106A58 File Offset: 0x00104C58
		// (set) Token: 0x06002F11 RID: 12049 RVA: 0x00018DB8 File Offset: 0x00016FB8
		public unsafe string GUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x00106A80 File Offset: 0x00104C80
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x00018DD7 File Offset: 0x00016FD7
		public unsafe List<GenericSaveData.BoolValue> boolValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.BoolValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_boolValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x00106AB0 File Offset: 0x00104CB0
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x00018DF6 File Offset: 0x00016FF6
		public unsafe List<GenericSaveData.FloatValue> floatValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.FloatValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_floatValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00106AE0 File Offset: 0x00104CE0
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x00018E15 File Offset: 0x00017015
		public unsafe List<GenericSaveData.IntValue> intValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.IntValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_intValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F6B RID: 3947
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x00106B10 File Offset: 0x00104D10
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x00018E34 File Offset: 0x00017034
		public unsafe List<GenericSaveData.StringValue> stringValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GenericSaveData.StringValue>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.NativeFieldInfoPtr_stringValues), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F11 RID: 7953
		private static readonly IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04001F12 RID: 7954
		private static readonly IntPtr NativeFieldInfoPtr_boolValues;

		// Token: 0x04001F13 RID: 7955
		private static readonly IntPtr NativeFieldInfoPtr_floatValues;

		// Token: 0x04001F14 RID: 7956
		private static readonly IntPtr NativeFieldInfoPtr_intValues;

		// Token: 0x04001F15 RID: 7957
		private static readonly IntPtr NativeFieldInfoPtr_stringValues;

		// Token: 0x04001F16 RID: 7958
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F17 RID: 7959
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Boolean_0;

		// Token: 0x04001F18 RID: 7960
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Single_0;

		// Token: 0x04001F19 RID: 7961
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_Int32_0;

		// Token: 0x04001F1A RID: 7962
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_String_String_0;

		// Token: 0x04001F1B RID: 7963
		private static readonly IntPtr NativeMethodInfoPtr_GetBool_Public_Boolean_String_Boolean_0;

		// Token: 0x04001F1C RID: 7964
		private static readonly IntPtr NativeMethodInfoPtr_GetFloat_Public_Single_String_Single_0;

		// Token: 0x04001F1D RID: 7965
		private static readonly IntPtr NativeMethodInfoPtr_GetInt_Public_Int32_String_Int32_0;

		// Token: 0x04001F1E RID: 7966
		private static readonly IntPtr NativeMethodInfoPtr_GetString_Public_String_String_String_0;

		// Token: 0x02000911 RID: 2321
		[Serializable]
		public class BoolValue : Object
		{
			// Token: 0x0600C5ED RID: 50669 RVA: 0x00301B08 File Offset: 0x002FFD08
			// Note: this type is marked as 'beforefieldinit'.
			static BoolValue()
			{
				Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "BoolValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr);
				GenericSaveData.BoolValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "key");
				GenericSaveData.BoolValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, "value");
				GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr, 100668745);
			}

			// Token: 0x0600C5EE RID: 50670 RVA: 0x00301B70 File Offset: 0x002FFD70
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BoolValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.BoolValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.BoolValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5EF RID: 50671 RVA: 0x00060562 File Offset: 0x0005E762
			public BoolValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DB4 RID: 15796
			// (get) Token: 0x0600C5F0 RID: 50672 RVA: 0x00301BAC File Offset: 0x002FFDAC
			// (set) Token: 0x0600C5F1 RID: 50673 RVA: 0x0006056B File Offset: 0x0005E76B
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DB5 RID: 15797
			// (get) Token: 0x0600C5F2 RID: 50674 RVA: 0x00301BD4 File Offset: 0x002FFDD4
			// (set) Token: 0x0600C5F3 RID: 50675 RVA: 0x0006058A File Offset: 0x0005E78A
			public unsafe bool value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.BoolValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400860B RID: 34315
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400860C RID: 34316
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x0400860D RID: 34317
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000912 RID: 2322
		[Serializable]
		public class FloatValue : Object
		{
			// Token: 0x0600C5F4 RID: 50676 RVA: 0x00301BFC File Offset: 0x002FFDFC
			// Note: this type is marked as 'beforefieldinit'.
			static FloatValue()
			{
				Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "FloatValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr);
				GenericSaveData.FloatValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "key");
				GenericSaveData.FloatValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, "value");
				GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr, 100668746);
			}

			// Token: 0x0600C5F5 RID: 50677 RVA: 0x00301C64 File Offset: 0x002FFE64
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe FloatValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.FloatValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.FloatValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5F6 RID: 50678 RVA: 0x000605A5 File Offset: 0x0005E7A5
			public FloatValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DB6 RID: 15798
			// (get) Token: 0x0600C5F7 RID: 50679 RVA: 0x00301CA0 File Offset: 0x002FFEA0
			// (set) Token: 0x0600C5F8 RID: 50680 RVA: 0x000605AE File Offset: 0x0005E7AE
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DB7 RID: 15799
			// (get) Token: 0x0600C5F9 RID: 50681 RVA: 0x00301CC8 File Offset: 0x002FFEC8
			// (set) Token: 0x0600C5FA RID: 50682 RVA: 0x000605CD File Offset: 0x0005E7CD
			public unsafe float value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.FloatValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x0400860E RID: 34318
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400860F RID: 34319
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008610 RID: 34320
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000913 RID: 2323
		[Serializable]
		public class IntValue : Object
		{
			// Token: 0x0600C5FB RID: 50683 RVA: 0x00301CF0 File Offset: 0x002FFEF0
			// Note: this type is marked as 'beforefieldinit'.
			static IntValue()
			{
				Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "IntValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr);
				GenericSaveData.IntValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "key");
				GenericSaveData.IntValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, "value");
				GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr, 100668747);
			}

			// Token: 0x0600C5FC RID: 50684 RVA: 0x00301D58 File Offset: 0x002FFF58
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IntValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.IntValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.IntValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C5FD RID: 50685 RVA: 0x000605E8 File Offset: 0x0005E7E8
			public IntValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DB8 RID: 15800
			// (get) Token: 0x0600C5FE RID: 50686 RVA: 0x00301D94 File Offset: 0x002FFF94
			// (set) Token: 0x0600C5FF RID: 50687 RVA: 0x000605F1 File Offset: 0x0005E7F1
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DB9 RID: 15801
			// (get) Token: 0x0600C600 RID: 50688 RVA: 0x00301DBC File Offset: 0x002FFFBC
			// (set) Token: 0x0600C601 RID: 50689 RVA: 0x00060610 File Offset: 0x0005E810
			public unsafe int value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.IntValue.NativeFieldInfoPtr_value)) = value;
				}
			}

			// Token: 0x04008611 RID: 34321
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008612 RID: 34322
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008613 RID: 34323
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000914 RID: 2324
		[Serializable]
		public class StringValue : Object
		{
			// Token: 0x0600C602 RID: 50690 RVA: 0x00301DE4 File Offset: 0x002FFFE4
			// Note: this type is marked as 'beforefieldinit'.
			static StringValue()
			{
				Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "StringValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr);
				GenericSaveData.StringValue.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "key");
				GenericSaveData.StringValue.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, "value");
				GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr, 100668748);
			}

			// Token: 0x0600C603 RID: 50691 RVA: 0x00301E4C File Offset: 0x0030004C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StringValue() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.StringValue>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.StringValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C604 RID: 50692 RVA: 0x0006062B File Offset: 0x0005E82B
			public StringValue(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBA RID: 15802
			// (get) Token: 0x0600C605 RID: 50693 RVA: 0x00301E88 File Offset: 0x00300088
			// (set) Token: 0x0600C606 RID: 50694 RVA: 0x00060634 File Offset: 0x0005E834
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003DBB RID: 15803
			// (get) Token: 0x0600C607 RID: 50695 RVA: 0x00301EB0 File Offset: 0x003000B0
			// (set) Token: 0x0600C608 RID: 50696 RVA: 0x00060653 File Offset: 0x0005E853
			public unsafe string value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.StringValue.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008614 RID: 34324
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008615 RID: 34325
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04008616 RID: 34326
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000915 RID: 2325
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass14_0")]
		public sealed class __c__DisplayClass14_0 : Object
		{
			// Token: 0x0600C609 RID: 50697 RVA: 0x00301ED8 File Offset: 0x003000D8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass14_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass14_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668749);
				GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr, 100668750);
			}

			// Token: 0x0600C60A RID: 50698 RVA: 0x00301F40 File Offset: 0x00300140
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass14_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass14_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C60B RID: 50699 RVA: 0x00301F7C File Offset: 0x0030017C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetBool_b__0(GenericSaveData.BoolValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass14_0.NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C60C RID: 50700 RVA: 0x00060672 File Offset: 0x0005E872
			public __c__DisplayClass14_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBC RID: 15804
			// (get) Token: 0x0600C60D RID: 50701 RVA: 0x00301FCC File Offset: 0x003001CC
			// (set) Token: 0x0600C60E RID: 50702 RVA: 0x0006067B File Offset: 0x0005E87B
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass14_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008617 RID: 34327
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008618 RID: 34328
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008619 RID: 34329
			private static readonly IntPtr NativeMethodInfoPtr__GetBool_b__0_Internal_Boolean_BoolValue_0;
		}

		// Token: 0x02000916 RID: 2326
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass15_0")]
		public sealed class __c__DisplayClass15_0 : Object
		{
			// Token: 0x0600C60F RID: 50703 RVA: 0x00301FF4 File Offset: 0x003001F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass15_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass15_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668751);
				GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr, 100668752);
			}

			// Token: 0x0600C610 RID: 50704 RVA: 0x0030205C File Offset: 0x0030025C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass15_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass15_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C611 RID: 50705 RVA: 0x00302098 File Offset: 0x00300298
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetFloat_b__0(GenericSaveData.FloatValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass15_0.NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C612 RID: 50706 RVA: 0x0006069A File Offset: 0x0005E89A
			public __c__DisplayClass15_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBD RID: 15805
			// (get) Token: 0x0600C613 RID: 50707 RVA: 0x003020E8 File Offset: 0x003002E8
			// (set) Token: 0x0600C614 RID: 50708 RVA: 0x000606A3 File Offset: 0x0005E8A3
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass15_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400861A RID: 34330
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400861B RID: 34331
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400861C RID: 34332
			private static readonly IntPtr NativeMethodInfoPtr__GetFloat_b__0_Internal_Boolean_FloatValue_0;
		}

		// Token: 0x02000917 RID: 2327
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Object
		{
			// Token: 0x0600C615 RID: 50709 RVA: 0x00302110 File Offset: 0x00300310
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668753);
				GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr, 100668754);
			}

			// Token: 0x0600C616 RID: 50710 RVA: 0x00302178 File Offset: 0x00300378
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass16_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C617 RID: 50711 RVA: 0x003021B4 File Offset: 0x003003B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetInt_b__0(GenericSaveData.IntValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass16_0.NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C618 RID: 50712 RVA: 0x000606C2 File Offset: 0x0005E8C2
			public __c__DisplayClass16_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBE RID: 15806
			// (get) Token: 0x0600C619 RID: 50713 RVA: 0x00302204 File Offset: 0x00300404
			// (set) Token: 0x0600C61A RID: 50714 RVA: 0x000606CB File Offset: 0x0005E8CB
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass16_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400861D RID: 34333
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x0400861E RID: 34334
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400861F RID: 34335
			private static readonly IntPtr NativeMethodInfoPtr__GetInt_b__0_Internal_Boolean_IntValue_0;
		}

		// Token: 0x02000918 RID: 2328
		[ObfuscatedName("ScheduleOne.Persistence.Datas.GenericSaveData+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Object
		{
			// Token: 0x0600C61B RID: 50715 RVA: 0x0030222C File Offset: 0x0030042C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GenericSaveData>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr);
				GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, "key");
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668755);
				GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr, 100668756);
			}

			// Token: 0x0600C61C RID: 50716 RVA: 0x00302294 File Offset: 0x00300494
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveData.__c__DisplayClass17_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C61D RID: 50717 RVA: 0x003022D0 File Offset: 0x003004D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetString_b__0(GenericSaveData.StringValue x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveData.__c__DisplayClass17_0.NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C61E RID: 50718 RVA: 0x000606EA File Offset: 0x0005E8EA
			public __c__DisplayClass17_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DBF RID: 15807
			// (get) Token: 0x0600C61F RID: 50719 RVA: 0x00302320 File Offset: 0x00300520
			// (set) Token: 0x0600C620 RID: 50720 RVA: 0x000606F3 File Offset: 0x0005E8F3
			public unsafe string key
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GenericSaveData.__c__DisplayClass17_0.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008620 RID: 34336
			private static readonly IntPtr NativeFieldInfoPtr_key;

			// Token: 0x04008621 RID: 34337
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008622 RID: 34338
			private static readonly IntPtr NativeMethodInfoPtr__GetString_b__0_Internal_Boolean_StringValue_0;
		}
	}
}
