using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C3 RID: 1731
	public class PackagingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009B83 RID: 39811 RVA: 0x002771F4 File Offset: 0x002753F4
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfigPanel()
		{
			Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr);
			PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			PackagingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, 100682408);
			PackagingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr, 100682409);
		}

		// Token: 0x06009B84 RID: 39812 RVA: 0x00277260 File Offset: 0x00275460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275993, XrefRangeEnd = 276028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x002772B0 File Offset: 0x002754B0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x0004C2A0 File Offset: 0x0004A4A0
		public PackagingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDF RID: 12255
		// (get) Token: 0x06009B87 RID: 39815 RVA: 0x002772EC File Offset: 0x002754EC
		// (set) Token: 0x06009B88 RID: 39816 RVA: 0x0004C2A9 File Offset: 0x0004A4A9
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006880 RID: 26752
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006881 RID: 26753
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006882 RID: 26754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
