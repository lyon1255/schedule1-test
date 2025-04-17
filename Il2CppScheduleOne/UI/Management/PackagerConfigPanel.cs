using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C2 RID: 1730
	public class PackagerConfigPanel : ConfigPanel
	{
		// Token: 0x06009B79 RID: 39801 RVA: 0x00277044 File Offset: 0x00275244
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigPanel()
		{
			Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PackagerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr);
			PackagerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "BedUI");
			PackagerConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "StationsUI");
			PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, "RoutesUI");
			PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682406);
			PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr, 100682407);
		}

		// Token: 0x06009B7A RID: 39802 RVA: 0x002770D8 File Offset: 0x002752D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275938, XrefRangeEnd = 275993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B7B RID: 39803 RVA: 0x00277128 File Offset: 0x00275328
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B7C RID: 39804 RVA: 0x0004C23A File Offset: 0x0004A43A
		public PackagerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDC RID: 12252
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x00277164 File Offset: 0x00275364
		// (set) Token: 0x06009B7E RID: 39806 RVA: 0x0004C243 File Offset: 0x0004A443
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDD RID: 12253
		// (get) Token: 0x06009B7F RID: 39807 RVA: 0x00277194 File Offset: 0x00275394
		// (set) Token: 0x06009B80 RID: 39808 RVA: 0x0004C262 File Offset: 0x0004A462
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDE RID: 12254
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x002771C4 File Offset: 0x002753C4
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x0004C281 File Offset: 0x0004A481
		public unsafe RouteListFieldUI RoutesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigPanel.NativeFieldInfoPtr_RoutesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400687B RID: 26747
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400687C RID: 26748
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x0400687D RID: 26749
		private static readonly IntPtr NativeFieldInfoPtr_RoutesUI;

		// Token: 0x0400687E RID: 26750
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400687F RID: 26751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
