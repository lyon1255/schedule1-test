using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Packaging;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x02000585 RID: 1413
	public class CocaineStationItem : StationItem
	{
		// Token: 0x06007C85 RID: 31877 RVA: 0x00217110 File Offset: 0x00215310
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineStationItem()
		{
			Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "CocaineStationItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr);
			CocaineStationItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, "Visuals");
			CocaineStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, 100678896);
			CocaineStationItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr, 100678897);
		}

		// Token: 0x06007C86 RID: 31878 RVA: 0x0021717C File Offset: 0x0021537C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 237250, XrefRangeEnd = 237257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Initialize(StorableItemDefinition itemDefinition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemDefinition);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineStationItem.NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x002171CC File Offset: 0x002153CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineStationItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineStationItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineStationItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0003B195 File Offset: 0x00039395
		public CocaineStationItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170025A8 RID: 9640
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x00217208 File Offset: 0x00215408
		// (set) Token: 0x06007C8A RID: 31882 RVA: 0x0003B19E File Offset: 0x0003939E
		public unsafe Il2CppReferenceArray<FilledPackagingVisuals> Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineStationItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CocaineStationItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040054C8 RID: 21704
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040054C9 RID: 21705
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_Void_StorableItemDefinition_0;

		// Token: 0x040054CA RID: 21706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
