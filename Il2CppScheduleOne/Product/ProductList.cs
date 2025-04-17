using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Product
{
	// Token: 0x020005A8 RID: 1448
	[Serializable]
	public class ProductList : Object
	{
		// Token: 0x06007E9C RID: 32412 RVA: 0x0021DCC8 File Offset: 0x0021BEC8
		// Note: this type is marked as 'beforefieldinit'.
		static ProductList()
		{
			Il2CppClassPointerStore<ProductList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product", "ProductList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList>.NativeClassPtr);
			ProductList.NativeFieldInfoPtr_entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "entries");
			ProductList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679145);
			ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679146);
			ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679147);
			ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679148);
			ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList>.NativeClassPtr, 100679149);
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x0021DD70 File Offset: 0x0021BF70
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 239556, RefRangeEnd = 239562, XrefRangeStart = 239548, XrefRangeEnd = 239556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductList() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0021DDAC File Offset: 0x0021BFAC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 239591, RefRangeEnd = 239596, XrefRangeStart = 239562, XrefRangeEnd = 239591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetCommaSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0021DDE4 File Offset: 0x0021BFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 239596, XrefRangeEnd = 239624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetLineSeperatedString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x0021DE1C File Offset: 0x0021C01C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 239650, RefRangeEnd = 239653, XrefRangeStart = 239624, XrefRangeEnd = 239650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetQualityString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetQualityString_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x0021DE54 File Offset: 0x0021C054
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 239667, RefRangeEnd = 239671, XrefRangeStart = 239653, XrefRangeEnd = 239667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalQuantity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x0003C24C File Offset: 0x0003A44C
		public ProductList(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002651 RID: 9809
		// (get) Token: 0x06007EA3 RID: 32419 RVA: 0x0021DE90 File Offset: 0x0021C090
		// (set) Token: 0x06007EA4 RID: 32420 RVA: 0x0003C255 File Offset: 0x0003A455
		public unsafe List<ProductList.Entry> entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ProductList.Entry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.NativeFieldInfoPtr_entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400562D RID: 22061
		private static readonly IntPtr NativeFieldInfoPtr_entries;

		// Token: 0x0400562E RID: 22062
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400562F RID: 22063
		private static readonly IntPtr NativeMethodInfoPtr_GetCommaSeperatedString_Public_String_0;

		// Token: 0x04005630 RID: 22064
		private static readonly IntPtr NativeMethodInfoPtr_GetLineSeperatedString_Public_String_0;

		// Token: 0x04005631 RID: 22065
		private static readonly IntPtr NativeMethodInfoPtr_GetQualityString_Public_String_0;

		// Token: 0x04005632 RID: 22066
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalQuantity_Public_Int32_0;

		// Token: 0x02000ACC RID: 2764
		[Serializable]
		public class Entry : Object
		{
			// Token: 0x0600D45D RID: 54365 RVA: 0x0032AD3C File Offset: 0x00328F3C
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProductList>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr);
				ProductList.Entry.NativeFieldInfoPtr_ProductID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "ProductID");
				ProductList.Entry.NativeFieldInfoPtr_Quality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quality");
				ProductList.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, "Quantity");
				ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr, 100679150);
			}

			// Token: 0x0600D45E RID: 54366 RVA: 0x0032ADB8 File Offset: 0x00328FB8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductList.Entry>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductList.Entry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D45F RID: 54367 RVA: 0x0006759D File Offset: 0x0006579D
			public Entry(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041D4 RID: 16852
			// (get) Token: 0x0600D460 RID: 54368 RVA: 0x0032ADF4 File Offset: 0x00328FF4
			// (set) Token: 0x0600D461 RID: 54369 RVA: 0x000675A6 File Offset: 0x000657A6
			public unsafe string ProductID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_ProductID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041D5 RID: 16853
			// (get) Token: 0x0600D462 RID: 54370 RVA: 0x0032AE1C File Offset: 0x0032901C
			// (set) Token: 0x0600D463 RID: 54371 RVA: 0x000675C5 File Offset: 0x000657C5
			public unsafe EQuality Quality
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quality)) = value;
				}
			}

			// Token: 0x170041D6 RID: 16854
			// (get) Token: 0x0600D464 RID: 54372 RVA: 0x0032AE44 File Offset: 0x00329044
			// (set) Token: 0x0600D465 RID: 54373 RVA: 0x000675E0 File Offset: 0x000657E0
			public unsafe int Quantity
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ProductList.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x04008EF6 RID: 36598
			private static readonly IntPtr NativeFieldInfoPtr_ProductID;

			// Token: 0x04008EF7 RID: 36599
			private static readonly IntPtr NativeFieldInfoPtr_Quality;

			// Token: 0x04008EF8 RID: 36600
			private static readonly IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x04008EF9 RID: 36601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
