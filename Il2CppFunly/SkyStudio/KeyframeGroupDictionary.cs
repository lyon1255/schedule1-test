using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000120 RID: 288
	[Serializable]
	public class KeyframeGroupDictionary : Object
	{
		// Token: 0x0600187D RID: 6269 RVA: 0x000BCB2C File Offset: 0x000BAD2C
		// Note: this type is marked as 'beforefieldinit'.
		static KeyframeGroupDictionary()
		{
			Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "KeyframeGroupDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr);
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_Groups");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_ColorGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_NumberGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_TextureGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_SpherePointGroup");
			KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, "m_BoolGroup");
			KeyframeGroupDictionary.NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665900);
			KeyframeGroupDictionary.NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665901);
			KeyframeGroupDictionary.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665902);
			KeyframeGroupDictionary.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665903);
			KeyframeGroupDictionary.NativeMethodInfoPtr_GetGroup_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665904);
			KeyframeGroupDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665905);
			KeyframeGroupDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665906);
			KeyframeGroupDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665907);
			KeyframeGroupDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665908);
			KeyframeGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr, 100665909);
		}

		// Token: 0x170008C8 RID: 2248
		public unsafe IKeyframeGroup this[string aKey]
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 95302, RefRangeEnd = 95310, XrefRangeStart = 95298, XrefRangeEnd = 95302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IKeyframeGroup>(intPtr3) : null;
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 95314, RefRangeEnd = 95319, XrefRangeStart = 95310, XrefRangeEnd = 95314, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(aKey);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001880 RID: 6272 RVA: 0x000BCD40 File Offset: 0x000BAF40
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95323, RefRangeEnd = 95329, XrefRangeStart = 95319, XrefRangeEnd = 95323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ContainsKey(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001881 RID: 6273 RVA: 0x000BCD90 File Offset: 0x000BAF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95329, XrefRangeEnd = 95333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x000BCDC4 File Offset: 0x000BAFC4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95371, RefRangeEnd = 95372, XrefRangeStart = 95333, XrefRangeEnd = 95371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetGroup<T>(string propertyName) where T : class
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x000BCE10 File Offset: 0x000BB010
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95372, XrefRangeEnd = 95440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001884 RID: 6276 RVA: 0x000BCE44 File Offset: 0x000BB044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95440, XrefRangeEnd = 95554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001885 RID: 6277 RVA: 0x000BCE78 File Offset: 0x000BB078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95563, RefRangeEnd = 95564, XrefRangeStart = 95554, XrefRangeEnd = 95563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator<string> GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator<string>>(intPtr3) : null;
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000BCEB8 File Offset: 0x000BB0B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95563, RefRangeEnd = 95564, XrefRangeStart = 95563, XrefRangeEnd = 95564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000BCEF8 File Offset: 0x000BB0F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 95597, RefRangeEnd = 95598, XrefRangeStart = 95564, XrefRangeEnd = 95597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyframeGroupDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyframeGroupDictionary.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x0000E13F File Offset: 0x0000C33F
		public KeyframeGroupDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06001889 RID: 6281 RVA: 0x000BCF34 File Offset: 0x000BB134
		// (set) Token: 0x0600188A RID: 6282 RVA: 0x0000E148 File Offset: 0x0000C348
		public unsafe Dictionary<string, IKeyframeGroup> m_Groups
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, IKeyframeGroup>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_Groups), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x000BCF64 File Offset: 0x000BB164
		// (set) Token: 0x0600188C RID: 6284 RVA: 0x0000E167 File Offset: 0x0000C367
		public unsafe ColorGroupDictionary m_ColorGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_ColorGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x0600188D RID: 6285 RVA: 0x000BCF94 File Offset: 0x000BB194
		// (set) Token: 0x0600188E RID: 6286 RVA: 0x0000E186 File Offset: 0x0000C386
		public unsafe NumberGroupDictionary m_NumberGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_NumberGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x0600188F RID: 6287 RVA: 0x000BCFC4 File Offset: 0x000BB1C4
		// (set) Token: 0x06001890 RID: 6288 RVA: 0x0000E1A5 File Offset: 0x0000C3A5
		public unsafe TextureGroupDictionary m_TextureGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextureGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_TextureGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x000BCFF4 File Offset: 0x000BB1F4
		// (set) Token: 0x06001892 RID: 6290 RVA: 0x0000E1C4 File Offset: 0x0000C3C4
		public unsafe SpherePointGroupDictionary m_SpherePointGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePointGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_SpherePointGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x06001893 RID: 6291 RVA: 0x000BD024 File Offset: 0x000BB224
		// (set) Token: 0x06001894 RID: 6292 RVA: 0x0000E1E3 File Offset: 0x0000C3E3
		public unsafe BoolGroupDictionary m_BoolGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoolGroupDictionary>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyframeGroupDictionary.NativeFieldInfoPtr_m_BoolGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001013 RID: 4115
		private static readonly IntPtr NativeFieldInfoPtr_m_Groups;

		// Token: 0x04001014 RID: 4116
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGroup;

		// Token: 0x04001015 RID: 4117
		private static readonly IntPtr NativeFieldInfoPtr_m_NumberGroup;

		// Token: 0x04001016 RID: 4118
		private static readonly IntPtr NativeFieldInfoPtr_m_TextureGroup;

		// Token: 0x04001017 RID: 4119
		private static readonly IntPtr NativeFieldInfoPtr_m_SpherePointGroup;

		// Token: 0x04001018 RID: 4120
		private static readonly IntPtr NativeFieldInfoPtr_m_BoolGroup;

		// Token: 0x04001019 RID: 4121
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_IKeyframeGroup_String_0;

		// Token: 0x0400101A RID: 4122
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_String_IKeyframeGroup_0;

		// Token: 0x0400101B RID: 4123
		private static readonly IntPtr NativeMethodInfoPtr_ContainsKey_Public_Boolean_String_0;

		// Token: 0x0400101C RID: 4124
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400101D RID: 4125
		private static readonly IntPtr NativeMethodInfoPtr_GetGroup_Public_T_String_0;

		// Token: 0x0400101E RID: 4126
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400101F RID: 4127
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_1_String_0;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerable_GetEnumerator_Private_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000856 RID: 2134
		private sealed class MethodInfoStoreGeneric_GetGroup_Public_T_String_0<T>
		{
			// Token: 0x04008254 RID: 33364
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(KeyframeGroupDictionary.NativeMethodInfoPtr_GetGroup_Public_T_String_0, Il2CppClassPointerStore<KeyframeGroupDictionary>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
			}))));
		}
	}
}
