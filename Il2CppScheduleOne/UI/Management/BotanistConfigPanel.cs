using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006B9 RID: 1721
	public class BotanistConfigPanel : ConfigPanel
	{
		// Token: 0x06009B35 RID: 39733 RVA: 0x00276400 File Offset: 0x00274600
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfigPanel()
		{
			Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BotanistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr);
			BotanistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "BedUI");
			BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "SuppliesUI");
			BotanistConfigPanel.NativeFieldInfoPtr_PotsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, "PotsUI");
			BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682388);
			BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr, 100682389);
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x00276494 File Offset: 0x00274694
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275556, XrefRangeEnd = 275608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x002764E4 File Offset: 0x002746E4
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x0004BFF9 File Offset: 0x0004A1F9
		public BotanistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FCC RID: 12236
		// (get) Token: 0x06009B39 RID: 39737 RVA: 0x00276520 File Offset: 0x00274720
		// (set) Token: 0x06009B3A RID: 39738 RVA: 0x0004C002 File Offset: 0x0004A202
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCD RID: 12237
		// (get) Token: 0x06009B3B RID: 39739 RVA: 0x00276550 File Offset: 0x00274750
		// (set) Token: 0x06009B3C RID: 39740 RVA: 0x0004C021 File Offset: 0x0004A221
		public unsafe ObjectFieldUI SuppliesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_SuppliesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FCE RID: 12238
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x00276580 File Offset: 0x00274780
		// (set) Token: 0x06009B3E RID: 39742 RVA: 0x0004C040 File Offset: 0x0004A240
		public unsafe ObjectListFieldUI PotsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfigPanel.NativeFieldInfoPtr_PotsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006859 RID: 26713
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x0400685A RID: 26714
		private static readonly IntPtr NativeFieldInfoPtr_SuppliesUI;

		// Token: 0x0400685B RID: 26715
		private static readonly IntPtr NativeFieldInfoPtr_PotsUI;

		// Token: 0x0400685C RID: 26716
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400685D RID: 26717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
