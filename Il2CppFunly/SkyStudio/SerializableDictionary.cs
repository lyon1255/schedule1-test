using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000121 RID: 289
	[Serializable]
	public class SerializableDictionary<K, V> : Object
	{
		// Token: 0x06001895 RID: 6293 RVA: 0x000BD054 File Offset: 0x000BB254
		// Note: this type is marked as 'beforefieldinit'.
		static SerializableDictionary()
		{
			Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SerializableDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr);
			SerializableDictionary<K, V>.NativeFieldInfoPtr_dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, "dict");
			SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Keys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, "m_Keys");
			SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, "m_Values");
			SerializableDictionary<K, V>.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665910);
			SerializableDictionary<K, V>.NativeMethodInfoPtr_get_Item_Public_get_V_K_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665911);
			SerializableDictionary<K, V>.NativeMethodInfoPtr_set_Item_Public_set_Void_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665912);
			SerializableDictionary<K, V>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665913);
			SerializableDictionary<K, V>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665914);
			SerializableDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr, 100665915);
		}

		// Token: 0x06001896 RID: 6294 RVA: 0x000BD188 File Offset: 0x000BB388
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 95611, RefRangeEnd = 95616, XrefRangeStart = 95598, XrefRangeEnd = 95611, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170008CC RID: 2252
		public unsafe V this[K aKey]
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 95624, RefRangeEnd = 95626, XrefRangeStart = 95616, XrefRangeEnd = 95624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				K ptr4;
				if (!typeof(K).IsValueType)
				{
					K k = aKey;
					if (!(k is string))
					{
						ref K ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(k as string);
					}
				}
				else
				{
					ptr4 = ref aKey;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr_get_Item_Public_get_V_K_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<V>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 95630, RefRangeEnd = 95631, XrefRangeStart = 95626, XrefRangeEnd = 95630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				K ptr4;
				if (!typeof(K).IsValueType)
				{
					K k = aKey;
					if (!(k is string))
					{
						ref K ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(k as Il2CppObjectBase);
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
						ptr4 = IL2CPP.ManagedStringToIl2Cpp(k as string);
					}
				}
				else
				{
					ptr4 = ref aKey;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				V ptr7;
				if (!typeof(V).IsValueType)
				{
					V v = value;
					if (!(v is string))
					{
						ref V ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(v as Il2CppObjectBase);
						if (ref ptr6 != null)
						{
							ptr7 = ref ptr6;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(ref ptr6)))
							{
								ptr7 = IL2CPP.il2cpp_object_unbox(ref ptr6);
							}
						}
					}
					else
					{
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(v as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr_set_Item_Public_set_Void_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001899 RID: 6297 RVA: 0x000BD340 File Offset: 0x000BB540
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95631, XrefRangeEnd = 95645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189A RID: 6298 RVA: 0x000BD374 File Offset: 0x000BB574
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 95645, XrefRangeEnd = 95656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189B RID: 6299 RVA: 0x000BD3A8 File Offset: 0x000BB5A8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 95673, RefRangeEnd = 95680, XrefRangeStart = 95656, XrefRangeEnd = 95673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializableDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializableDictionary<K, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializableDictionary<K, V>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600189C RID: 6300 RVA: 0x0000E202 File Offset: 0x0000C402
		public SerializableDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x0600189D RID: 6301 RVA: 0x000BD3E4 File Offset: 0x000BB5E4
		// (set) Token: 0x0600189E RID: 6302 RVA: 0x0000E20B File Offset: 0x0000C40B
		public unsafe Dictionary<K, V> dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<K, V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x0600189F RID: 6303 RVA: 0x000BD414 File Offset: 0x000BB614
		// (set) Token: 0x060018A0 RID: 6304 RVA: 0x0000E22A File Offset: 0x0000C42A
		public unsafe List<K> m_Keys
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Keys);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<K>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Keys), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060018A1 RID: 6305 RVA: 0x000BD444 File Offset: 0x000BB644
		// (set) Token: 0x060018A2 RID: 6306 RVA: 0x0000E249 File Offset: 0x0000C449
		public unsafe List<V> m_Values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializableDictionary<K, V>.NativeFieldInfoPtr_m_Values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_dict;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_m_Keys;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeFieldInfoPtr_m_Values;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_V_K_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_K_V_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
