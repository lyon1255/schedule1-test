using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BC RID: 1724
	public class ChemistConfigPanel : ConfigPanel
	{
		// Token: 0x06009B4B RID: 39755 RVA: 0x00276800 File Offset: 0x00274A00
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigPanel()
		{
			Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr);
			ChemistConfigPanel.NativeFieldInfoPtr_BedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "BedUI");
			ChemistConfigPanel.NativeFieldInfoPtr_StationsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, "StationsUI");
			ChemistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100682394);
			ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr, 100682395);
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00276880 File Offset: 0x00274A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275678, XrefRangeEnd = 275723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x002768D0 File Offset: 0x00274AD0
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x0004C0AF File Offset: 0x0004A2AF
		public ChemistConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD1 RID: 12241
		// (get) Token: 0x06009B4F RID: 39759 RVA: 0x0027690C File Offset: 0x00274B0C
		// (set) Token: 0x06009B50 RID: 39760 RVA: 0x0004C0B8 File Offset: 0x0004A2B8
		public unsafe ObjectFieldUI BedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_BedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD2 RID: 12242
		// (get) Token: 0x06009B51 RID: 39761 RVA: 0x0027693C File Offset: 0x00274B3C
		// (set) Token: 0x06009B52 RID: 39762 RVA: 0x0004C0D7 File Offset: 0x0004A2D7
		public unsafe ObjectListFieldUI StationsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigPanel.NativeFieldInfoPtr_StationsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006864 RID: 26724
		private static readonly IntPtr NativeFieldInfoPtr_BedUI;

		// Token: 0x04006865 RID: 26725
		private static readonly IntPtr NativeFieldInfoPtr_StationsUI;

		// Token: 0x04006866 RID: 26726
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006867 RID: 26727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
