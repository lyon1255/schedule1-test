using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x0200058E RID: 1422
	public class MethStationItem : StationItem
	{
		// Token: 0x06007D17 RID: 32023 RVA: 0x00218BC8 File Offset: 0x00216DC8
		// Note: this type is marked as 'beforefieldinit'.
		static MethStationItem()
		{
			Il2CppClassPointerStore<MethStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "MethStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr);
			MethStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, "Visuals");
			MethStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, 100678959);
			MethStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr, 100678960);
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x00218C34 File Offset: 0x00216E34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237598, XrefRangeEnd = 237605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MethStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x00218C84 File Offset: 0x00216E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MethStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MethStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MethStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x0003B684 File Offset: 0x00039884
		public MethStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025D7 RID: 9687
		// (get) Token: 0x06007D1B RID: 32027 RVA: 0x00218CC0 File Offset: 0x00216EC0
		// (set) Token: 0x06007D1C RID: 32028 RVA: 0x0003B68D File Offset: 0x0003988D
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MethStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400551F RID: 21791
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04005520 RID: 21792
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x04005521 RID: 21793
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
