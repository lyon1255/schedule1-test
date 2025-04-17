using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using UnityEngine;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055B RID: 1371
	public class PlantHarvestable : MonoBehaviour
	{
		// Token: 0x0600789C RID: 30876 RVA: 0x00209574 File Offset: 0x00207774
		// Note: this type is marked as 'beforefieldinit'.
		static PlantHarvestable()
		{
			Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "PlantHarvestable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr);
			PlantHarvestable.NativeFieldInfoPtr_Product = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "Product");
			PlantHarvestable.NativeFieldInfoPtr_ProductQuantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, "ProductQuantity");
			PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678428);
			PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr, 100678429);
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x002095F4 File Offset: 0x002077F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232431, XrefRangeEnd = 232514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Harvest(bool giveProduct = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref giveProduct;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlantHarvestable.NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600789E RID: 30878 RVA: 0x00209640 File Offset: 0x00207840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232514, XrefRangeEnd = 232515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantHarvestable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantHarvestable>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantHarvestable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600789F RID: 30879 RVA: 0x000393BA File Offset: 0x000375BA
		public PlantHarvestable(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002479 RID: 9337
		// (get) Token: 0x060078A0 RID: 30880 RVA: 0x0020967C File Offset: 0x0020787C
		// (set) Token: 0x060078A1 RID: 30881 RVA: 0x000393C3 File Offset: 0x000375C3
		public unsafe StorableItemDefinition Product
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_Product), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700247A RID: 9338
		// (get) Token: 0x060078A2 RID: 30882 RVA: 0x002096AC File Offset: 0x002078AC
		// (set) Token: 0x060078A3 RID: 30883 RVA: 0x000393E2 File Offset: 0x000375E2
		public unsafe int ProductQuantity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantHarvestable.NativeFieldInfoPtr_ProductQuantity)) = value;
			}
		}

		// Token: 0x0400522B RID: 21035
		private static readonly IntPtr NativeFieldInfoPtr_Product;

		// Token: 0x0400522C RID: 21036
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuantity;

		// Token: 0x0400522D RID: 21037
		private static readonly IntPtr NativeMethodInfoPtr_Harvest_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x0400522E RID: 21038
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
