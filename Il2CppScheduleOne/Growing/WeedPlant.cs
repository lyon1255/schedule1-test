using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;

namespace Il2CppScheduleOne.Growing
{
	// Token: 0x0200055F RID: 1375
	public class WeedPlant : Plant
	{
		// Token: 0x060078CF RID: 30927 RVA: 0x00209E20 File Offset: 0x00208020
		// Note: this type is marked as 'beforefieldinit'.
		static WeedPlant()
		{
			Il2CppClassPointerStore<WeedPlant>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Growing", "WeedPlant");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr);
			WeedPlant.NativeFieldInfoPtr_BranchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, "BranchPrefab");
			WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678447);
			WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr, 100678448);
		}

		// Token: 0x060078D0 RID: 30928 RVA: 0x00209E8C File Offset: 0x0020808C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232572, XrefRangeEnd = 232578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetHarvestedProduct(int quantity = 1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedPlant.NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x060078D1 RID: 30929 RVA: 0x00209EE4 File Offset: 0x002080E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedPlant() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedPlant>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedPlant.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078D2 RID: 30930 RVA: 0x0003957E File Offset: 0x0003777E
		public WeedPlant(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002489 RID: 9353
		// (get) Token: 0x060078D3 RID: 30931 RVA: 0x00209F20 File Offset: 0x00208120
		// (set) Token: 0x060078D4 RID: 30932 RVA: 0x00039587 File Offset: 0x00037787
		public unsafe PlantHarvestable BranchPrefab
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantHarvestable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedPlant.NativeFieldInfoPtr_BranchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005247 RID: 21063
		private static readonly IntPtr NativeFieldInfoPtr_BranchPrefab;

		// Token: 0x04005248 RID: 21064
		private static readonly IntPtr NativeMethodInfoPtr_GetHarvestedProduct_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04005249 RID: 21065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
