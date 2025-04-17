using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C0 RID: 1728
	public class LabOvenConfigPanel : ConfigPanel
	{
		// Token: 0x06009B6B RID: 39787 RVA: 0x00276DB0 File Offset: 0x00274FB0
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigPanel()
		{
			Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "LabOvenConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr);
			LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, "DestinationUI");
			LabOvenConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, 100682402);
			LabOvenConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr, 100682403);
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x00276E1C File Offset: 0x0027501C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275858, XrefRangeEnd = 275893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LabOvenConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x00276E6C File Offset: 0x0027506C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B6E RID: 39790 RVA: 0x0004C1CB File Offset: 0x0004A3CB
		public LabOvenConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD9 RID: 12249
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x00276EA8 File Offset: 0x002750A8
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x0004C1D4 File Offset: 0x0004A3D4
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006874 RID: 26740
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006875 RID: 26741
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006876 RID: 26742
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
