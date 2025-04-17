using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;
using Il2CppScheduleOne.Storage;

namespace Il2CppScheduleOne.Product.Packaging
{
	// Token: 0x020005B5 RID: 1461
	[Serializable]
	public class PackagingDefinition : StorableItemDefinition
	{
		// Token: 0x06008050 RID: 32848 RVA: 0x00225050 File Offset: 0x00223250
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingDefinition()
		{
			Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Product.Packaging", "PackagingDefinition");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr);
			PackagingDefinition.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Quantity");
			PackagingDefinition.NativeFieldInfoPtr_StealthLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StealthLevel");
			PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "FunctionalPackaging");
			PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "Equippable_Filled");
			PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, "StoredItem_Filled");
			PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr, 100679409);
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x002250F8 File Offset: 0x002232F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 244147, XrefRangeEnd = 244148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingDefinition() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingDefinition>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingDefinition.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008052 RID: 32850 RVA: 0x0003CD73 File Offset: 0x0003AF73
		public PackagingDefinition(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170026C0 RID: 9920
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x00225134 File Offset: 0x00223334
		// (set) Token: 0x06008054 RID: 32852 RVA: 0x0003CD7C File Offset: 0x0003AF7C
		public unsafe int Quantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Quantity)) = value;
			}
		}

		// Token: 0x170026C1 RID: 9921
		// (get) Token: 0x06008055 RID: 32853 RVA: 0x0022515C File Offset: 0x0022335C
		// (set) Token: 0x06008056 RID: 32854 RVA: 0x0003CD97 File Offset: 0x0003AF97
		public unsafe EStealthLevel StealthLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StealthLevel)) = value;
			}
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x06008057 RID: 32855 RVA: 0x00225184 File Offset: 0x00223384
		// (set) Token: 0x06008058 RID: 32856 RVA: 0x0003CDB2 File Offset: 0x0003AFB2
		public unsafe FunctionalPackaging FunctionalPackaging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FunctionalPackaging>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_FunctionalPackaging), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x06008059 RID: 32857 RVA: 0x002251B4 File Offset: 0x002233B4
		// (set) Token: 0x0600805A RID: 32858 RVA: 0x0003CDD1 File Offset: 0x0003AFD1
		public unsafe Equippable Equippable_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_Equippable_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600805B RID: 32859 RVA: 0x002251E4 File Offset: 0x002233E4
		// (set) Token: 0x0600805C RID: 32860 RVA: 0x0003CDF0 File Offset: 0x0003AFF0
		public unsafe StoredItem StoredItem_Filled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StoredItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingDefinition.NativeFieldInfoPtr_StoredItem_Filled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400576D RID: 22381
		private static readonly IntPtr NativeFieldInfoPtr_Quantity;

		// Token: 0x0400576E RID: 22382
		private static readonly IntPtr NativeFieldInfoPtr_StealthLevel;

		// Token: 0x0400576F RID: 22383
		private static readonly IntPtr NativeFieldInfoPtr_FunctionalPackaging;

		// Token: 0x04005770 RID: 22384
		private static readonly IntPtr NativeFieldInfoPtr_Equippable_Filled;

		// Token: 0x04005771 RID: 22385
		private static readonly IntPtr NativeFieldInfoPtr_StoredItem_Filled;

		// Token: 0x04005772 RID: 22386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
