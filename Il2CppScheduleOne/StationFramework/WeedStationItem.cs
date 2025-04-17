using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000593 RID: 1427
	public class WeedStationItem : StationItem
	{
		// Token: 0x06007D9F RID: 32159 RVA: 0x0021A48C File Offset: 0x0021868C
		// Note: this type is marked as 'beforefieldinit'.
		static WeedStationItem()
		{
			Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "WeedStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr);
			WeedStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, "Visuals");
			WeedStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, 100679010);
			WeedStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr, 100679011);
		}

		// Token: 0x06007DA0 RID: 32160 RVA: 0x0021A4F8 File Offset: 0x002186F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 238041, XrefRangeEnd = 238049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WeedStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DA1 RID: 32161 RVA: 0x0021A548 File Offset: 0x00218748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WeedStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WeedStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WeedStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007DA2 RID: 32162 RVA: 0x0003BB86 File Offset: 0x00039D86
		public WeedStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700260A RID: 9738
		// (get) Token: 0x06007DA3 RID: 32163 RVA: 0x0021A584 File Offset: 0x00218784
		// (set) Token: 0x06007DA4 RID: 32164 RVA: 0x0003BB8F File Offset: 0x00039D8F
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WeedStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005572 RID: 21874
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005573 RID: 21875
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x04005574 RID: 21876
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
