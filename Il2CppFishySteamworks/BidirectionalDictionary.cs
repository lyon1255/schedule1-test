using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;

namespace Il2CppFishySteamworks
{
	// Token: 0x0200078B RID: 1931
	public class BidirectionalDictionary<T1, T2> : Object
	{
		// Token: 0x0600B6E3 RID: 46819 RVA: 0x002D5F7C File Offset: 0x002D417C
		// Note: this type is marked as 'beforefieldinit'.
		static BidirectionalDictionary()
		{
			Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishySteamworks", "BidirectionalDictionary`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr);
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t1ToT2Dict");
			BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, "t2ToT1Dict");
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685759);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685760);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685761);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685762);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685763);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685764);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685765);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685766);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685767);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685768);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685769);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685770);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685771);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685772);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685773);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685774);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685775);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685776);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685777);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685778);
			BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr, 100685779);
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0600B6E4 RID: 46820 RVA: 0x002D61C8 File Offset: 0x002D43C8
		public unsafe IEnumerable<T1> FirstTypes
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311494, RefRangeEnd = 311495, XrefRangeStart = 311490, XrefRangeEnd = 311494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T1>>(intPtr3) : null;
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0600B6E5 RID: 46821 RVA: 0x002D6208 File Offset: 0x002D4408
		public unsafe IEnumerable<T2> SecondTypes
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311495, XrefRangeEnd = 311501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<T2>>(intPtr3) : null;
			}
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x002D6248 File Offset: 0x002D4448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311501, XrefRangeEnd = 311503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x0600B6E7 RID: 46823 RVA: 0x002D6288 File Offset: 0x002D4488
		public unsafe int Count
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311503, XrefRangeEnd = 311505, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Count_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x0600B6E8 RID: 46824 RVA: 0x002D62C4 File Offset: 0x002D44C4
		public unsafe Dictionary<T1, T2> First
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr3) : null;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x0600B6E9 RID: 46825 RVA: 0x002D6304 File Offset: 0x002D4504
		public unsafe Dictionary<T2, T1> Second
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr3) : null;
			}
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x002D6344 File Offset: 0x002D4544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311525, RefRangeEnd = 311526, XrefRangeStart = 311505, XrefRangeEnd = 311525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T1 key, T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T2 ptr7;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = value;
				if (!(t2 is string))
				{
					ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x002D6430 File Offset: 0x002D4630
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311526, XrefRangeEnd = 311534, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(T2 key, T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
			T1 ptr7;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = value;
				if (!(t2 is string))
				{
					ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
					ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
				}
			}
			else
			{
				ptr7 = ref value;
			}
			*ptr5 = ref ptr7;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Add_Public_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x002D651C File Offset: 0x002D471C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311534, XrefRangeEnd = 311536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T2 Get(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x002D65B4 File Offset: 0x002D47B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311536, XrefRangeEnd = 311542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T1 Get(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Get_Public_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x002D664C File Offset: 0x002D484C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311542, XrefRangeEnd = 311548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T1 key, out T2 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T2).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T2>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x002D6734 File Offset: 0x002D4934
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311550, RefRangeEnd = 311552, XrefRangeStart = 311548, XrefRangeEnd = 311550, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValue(T2 key, out T1 value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			ref IntPtr ptr5 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref value;
			}
			ptr5 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(T1).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T1>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x002D681C File Offset: 0x002D4A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311552, XrefRangeEnd = 311554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x002D68B4 File Offset: 0x002D4AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311554, XrefRangeEnd = 311558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Contains(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Contains_Public_Boolean_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x002D694C File Offset: 0x002D4B4C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311562, RefRangeEnd = 311563, XrefRangeStart = 311558, XrefRangeEnd = 311562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T1 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T1 ptr4;
			if (!typeof(T1).IsValueType)
			{
				T1 t = key;
				if (!(t is string))
				{
					ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x002D69DC File Offset: 0x002D4BDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 311567, RefRangeEnd = 311568, XrefRangeStart = 311563, XrefRangeEnd = 311567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Remove(T2 key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			IntPtr* ptr2 = ptr;
			T2 ptr4;
			if (!typeof(T2).IsValueType)
			{
				T2 t = key;
				if (!(t is string))
				{
					ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
				ptr4 = ref key;
			}
			*ptr2 = ref ptr4;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_Remove_Public_Void_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170038C3 RID: 14531
		public unsafe T1 this[T2 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T1>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 311568, XrefRangeEnd = 311584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T2 ptr4;
				if (!typeof(T2).IsValueType)
				{
					T2 t = key;
					if (!(t is string))
					{
						ref T2 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T1 ptr7;
				if (!typeof(T1).IsValueType)
				{
					T1 t2 = value;
					if (!(t2 is string))
					{
						ref T1 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170038C4 RID: 14532
		public unsafe T2 this[T1 key]
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T2>(intPtr, false, true);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 311604, RefRangeEnd = 311605, XrefRangeStart = 311584, XrefRangeEnd = 311604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				IntPtr* ptr2 = ptr;
				T1 ptr4;
				if (!typeof(T1).IsValueType)
				{
					T1 t = key;
					if (!(t is string))
					{
						ref T1 ptr3 = ptr4 = IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase);
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
					ptr4 = ref key;
				}
				*ptr2 = ref ptr4;
				IntPtr* ptr5 = ptr + checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr);
				T2 ptr7;
				if (!typeof(T2).IsValueType)
				{
					T2 t2 = value;
					if (!(t2 is string))
					{
						ref T2 ptr6 = ptr7 = IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase);
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
						ptr7 = IL2CPP.ManagedStringToIl2Cpp(t2 as string);
					}
				}
				else
				{
					ptr7 = ref value;
				}
				*ptr5 = ref ptr7;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600B6F8 RID: 46840 RVA: 0x002D6D74 File Offset: 0x002D4F74
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 311623, RefRangeEnd = 311625, XrefRangeStart = 311605, XrefRangeEnd = 311623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BidirectionalDictionary() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BidirectionalDictionary<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BidirectionalDictionary<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B6F9 RID: 46841 RVA: 0x00059DEF File Offset: 0x00057FEF
		public BidirectionalDictionary(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038BC RID: 14524
		// (get) Token: 0x0600B6FA RID: 46842 RVA: 0x002D6DB0 File Offset: 0x002D4FB0
		// (set) Token: 0x0600B6FB RID: 46843 RVA: 0x00059DF8 File Offset: 0x00057FF8
		public unsafe Dictionary<T1, T2> t1ToT2Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T1, T2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t1ToT2Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038BD RID: 14525
		// (get) Token: 0x0600B6FC RID: 46844 RVA: 0x002D6DE0 File Offset: 0x002D4FE0
		// (set) Token: 0x0600B6FD RID: 46845 RVA: 0x00059E17 File Offset: 0x00058017
		public unsafe Dictionary<T2, T1> t2ToT1Dict
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T2, T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BidirectionalDictionary<T1, T2>.NativeFieldInfoPtr_t2ToT1Dict), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007B28 RID: 31528
		private static readonly IntPtr NativeFieldInfoPtr_t1ToT2Dict;

		// Token: 0x04007B29 RID: 31529
		private static readonly IntPtr NativeFieldInfoPtr_t2ToT1Dict;

		// Token: 0x04007B2A RID: 31530
		private static readonly IntPtr NativeMethodInfoPtr_get_FirstTypes_Public_get_IEnumerable_1_T1_0;

		// Token: 0x04007B2B RID: 31531
		private static readonly IntPtr NativeMethodInfoPtr_get_SecondTypes_Public_get_IEnumerable_1_T2_0;

		// Token: 0x04007B2C RID: 31532
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04007B2D RID: 31533
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_get_Int32_0;

		// Token: 0x04007B2E RID: 31534
		private static readonly IntPtr NativeMethodInfoPtr_get_First_Public_get_Dictionary_2_T1_T2_0;

		// Token: 0x04007B2F RID: 31535
		private static readonly IntPtr NativeMethodInfoPtr_get_Second_Public_get_Dictionary_2_T2_T1_0;

		// Token: 0x04007B30 RID: 31536
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T1_T2_0;

		// Token: 0x04007B31 RID: 31537
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_T2_T1_0;

		// Token: 0x04007B32 RID: 31538
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T2_T1_0;

		// Token: 0x04007B33 RID: 31539
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_T1_T2_0;

		// Token: 0x04007B34 RID: 31540
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T1_byref_T2_0;

		// Token: 0x04007B35 RID: 31541
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValue_Public_Boolean_T2_byref_T1_0;

		// Token: 0x04007B36 RID: 31542
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T1_0;

		// Token: 0x04007B37 RID: 31543
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_T2_0;

		// Token: 0x04007B38 RID: 31544
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T1_0;

		// Token: 0x04007B39 RID: 31545
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Void_T2_0;

		// Token: 0x04007B3A RID: 31546
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T1_T2_0;

		// Token: 0x04007B3B RID: 31547
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T2_T1_0;

		// Token: 0x04007B3C RID: 31548
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_T2_T1_0;

		// Token: 0x04007B3D RID: 31549
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_T1_T2_0;

		// Token: 0x04007B3E RID: 31550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
