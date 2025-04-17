using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x02000558 RID: 1368
	public class CocaPlant : Plant
	{
		// Token: 0x06007858 RID: 30808 RVA: 0x002087EC File Offset: 0x002069EC
		// Note: this type is marked as 'beforefieldinit'.
		static CocaPlant()
		{
			Il2CppClassPointerStore<CocaPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "CocaPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr);
			CocaPlant.NativeFieldInfoPtr_Harvestable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, "Harvestable");
			CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678406);
			CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr, 100678407);
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x00208858 File Offset: 0x00206A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232254, XrefRangeEnd = 232260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x002088B0 File Offset: 0x00206AB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232260, XrefRangeEnd = 232261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x0003914B File Offset: 0x0003734B
		public CocaPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x0600785C RID: 30812 RVA: 0x002088EC File Offset: 0x00206AEC
		// (set) Token: 0x0600785D RID: 30813 RVA: 0x00039154 File Offset: 0x00037354
		public unsafe PlantHarvestable Harvestable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaPlant.NativeFieldInfoPtr_Harvestable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005201 RID: 20993
		private static readonly IntPtr NativeFieldInfoPtr_Harvestable;

		// Token: 0x04005202 RID: 20994
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005203 RID: 20995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
