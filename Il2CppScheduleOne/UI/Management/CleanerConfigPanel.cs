using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BE RID: 1726
	public class CleanerConfigPanel : ConfigPanel
	{
		// Token: 0x06009B5B RID: 39771 RVA: 0x00276AD8 File Offset: 0x00274CD8
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigPanel()
		{
			Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CleanerConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr);
			CleanerConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BedUI");
			CleanerConfigPanel.NativeFieldInfoPtr_BinsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, "BinsUI");
			CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682398);
			CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr, 100682399);
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x00276B58 File Offset: 0x00274D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275768, XrefRangeEnd = 275813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x00276BA8 File Offset: 0x00274DA8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x0004C13D File Offset: 0x0004A33D
		public CleanerConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD5 RID: 12245
		// (get) Token: 0x06009B5F RID: 39775 RVA: 0x00276BE4 File Offset: 0x00274DE4
		// (set) Token: 0x06009B60 RID: 39776 RVA: 0x0004C146 File Offset: 0x0004A346
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD6 RID: 12246
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x00276C14 File Offset: 0x00274E14
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x0004C165 File Offset: 0x0004A365
		public unsafe ObjectListFieldUI BinsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigPanel.NativeFieldInfoPtr_BinsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400686C RID: 26732
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400686D RID: 26733
		private static readonly IntPtr NativeFieldInfoPtr_BinsUI;

		// Token: 0x0400686E RID: 26734
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400686F RID: 26735
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
