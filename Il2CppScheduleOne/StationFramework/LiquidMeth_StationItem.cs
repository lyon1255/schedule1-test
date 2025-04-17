using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Product;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000583 RID: 1411
	public class LiquidMeth_StationItem : StationItem
	{
		// Token: 0x06007C46 RID: 31814 RVA: 0x002165B4 File Offset: 0x002147B4
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidMeth_StationItem()
		{
			Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidMeth_StationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr);
			LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, "Visuals");
			LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100678877);
			LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr, 100678878);
		}

		// Token: 0x06007C47 RID: 31815 RVA: 0x00216620 File Offset: 0x00214820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237140, XrefRangeEnd = 237159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LiquidMeth_StationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C48 RID: 31816 RVA: 0x00216670 File Offset: 0x00214870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237159, XrefRangeEnd = 237160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidMeth_StationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidMeth_StationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidMeth_StationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C49 RID: 31817 RVA: 0x0003AF55 File Offset: 0x00039155
		public LiquidMeth_StationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700258F RID: 9615
		// (get) Token: 0x06007C4A RID: 31818 RVA: 0x002166AC File Offset: 0x002148AC
		// (set) Token: 0x06007C4B RID: 31819 RVA: 0x0003AF5E File Offset: 0x0003915E
		public unsafe LiquidMethVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidMethVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidMeth_StationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054A1 RID: 21665
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040054A2 RID: 21666
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040054A3 RID: 21667
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
