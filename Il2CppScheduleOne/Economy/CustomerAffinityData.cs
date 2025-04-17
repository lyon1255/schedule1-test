using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Product;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x0200040E RID: 1038
	[Serializable]
	public class CustomerAffinityData : Object
	{
		// Token: 0x06005A13 RID: 23059 RVA: 0x001A33F8 File Offset: 0x001A15F8
		// Note: this type is marked as 'beforefieldinit'.
		static CustomerAffinityData()
		{
			Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "CustomerAffinityData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr);
			CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "ProductAffinities");
			CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674774);
			CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674775);
			CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, 100674776);
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x001A3478 File Offset: 0x001A1678
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190340, RefRangeEnd = 190341, XrefRangeStart = 190296, XrefRangeEnd = 190340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CopyTo(CustomerAffinityData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x001A34BC File Offset: 0x001A16BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190357, RefRangeEnd = 190358, XrefRangeStart = 190341, XrefRangeEnd = 190357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetAffinity(EDrugType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref type;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x001A3508 File Offset: 0x001A1708
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 190366, RefRangeEnd = 190367, XrefRangeStart = 190358, XrefRangeEnd = 190366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CustomerAffinityData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A17 RID: 23063 RVA: 0x0002A87C File Offset: 0x00028A7C
		public CustomerAffinityData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x06005A18 RID: 23064 RVA: 0x001A3544 File Offset: 0x001A1744
		// (set) Token: 0x06005A19 RID: 23065 RVA: 0x0002A885 File Offset: 0x00028A85
		public unsafe List<ProductTypeAffinity> ProductAffinities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductTypeAffinity>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.NativeFieldInfoPtr_ProductAffinities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003D84 RID: 15748
		private static readonly IntPtr NativeFieldInfoPtr_ProductAffinities;

		// Token: 0x04003D85 RID: 15749
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Void_CustomerAffinityData_0;

		// Token: 0x04003D86 RID: 15750
		private static readonly IntPtr NativeMethodInfoPtr_GetAffinity_Public_Single_EDrugType_0;

		// Token: 0x04003D87 RID: 15751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009E1 RID: 2529
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass1_0")]
		public sealed class __c__DisplayClass1_0 : Object
		{
			// Token: 0x0600CD39 RID: 52537 RVA: 0x00317028 File Offset: 0x00315228
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass1_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass1_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, "affinity");
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674777);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674778);
				CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr, 100674779);
			}

			// Token: 0x0600CD3A RID: 52538 RVA: 0x003170A4 File Offset: 0x003152A4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass1_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass1_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD3B RID: 52539 RVA: 0x003170E0 File Offset: 0x003152E0
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD3C RID: 52540 RVA: 0x00317130 File Offset: 0x00315330
			[CallerCount(0)]
			public unsafe bool _CopyTo_b__1(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass1_0.NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD3D RID: 52541 RVA: 0x00063D33 File Offset: 0x00061F33
			public __c__DisplayClass1_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE6 RID: 16358
			// (get) Token: 0x0600CD3E RID: 52542 RVA: 0x00317180 File Offset: 0x00315380
			// (set) Token: 0x0600CD3F RID: 52543 RVA: 0x00063D3C File Offset: 0x00061F3C
			public unsafe ProductTypeAffinity affinity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProductTypeAffinity>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass1_0.NativeFieldInfoPtr_affinity), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008AAB RID: 35499
			private static readonly IntPtr NativeFieldInfoPtr_affinity;

			// Token: 0x04008AAC RID: 35500
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AAD RID: 35501
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__0_Internal_Boolean_ProductTypeAffinity_0;

			// Token: 0x04008AAE RID: 35502
			private static readonly IntPtr NativeMethodInfoPtr__CopyTo_b__1_Internal_Boolean_ProductTypeAffinity_0;
		}

		// Token: 0x020009E2 RID: 2530
		[ObfuscatedName("ScheduleOne.Economy.CustomerAffinityData+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CD40 RID: 52544 RVA: 0x003171B0 File Offset: 0x003153B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CustomerAffinityData>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr);
				CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, "type");
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674780);
				CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr, 100674781);
			}

			// Token: 0x0600CD41 RID: 52545 RVA: 0x00317218 File Offset: 0x00315418
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CustomerAffinityData.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CD42 RID: 52546 RVA: 0x00317254 File Offset: 0x00315454
			[CallerCount(0)]
			public unsafe bool _GetAffinity_b__0(ProductTypeAffinity x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CustomerAffinityData.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CD43 RID: 52547 RVA: 0x00063D5B File Offset: 0x00061F5B
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003FE7 RID: 16359
			// (get) Token: 0x0600CD44 RID: 52548 RVA: 0x003172A4 File Offset: 0x003154A4
			// (set) Token: 0x0600CD45 RID: 52549 RVA: 0x00063D64 File Offset: 0x00061F64
			public unsafe EDrugType type
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CustomerAffinityData.__c__DisplayClass2_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008AAF RID: 35503
			private static readonly IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008AB0 RID: 35504
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008AB1 RID: 35505
			private static readonly IntPtr NativeMethodInfoPtr__GetAffinity_b__0_Internal_Boolean_ProductTypeAffinity_0;
		}
	}
}
