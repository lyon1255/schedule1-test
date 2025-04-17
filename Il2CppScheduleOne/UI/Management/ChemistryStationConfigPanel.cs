using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BD RID: 1725
	public class ChemistryStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009B53 RID: 39763 RVA: 0x0027696C File Offset: 0x00274B6C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigPanel()
		{
			Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "ChemistryStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr);
			ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "RecipeUI");
			ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, "DestinationUI");
			ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682396);
			ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr, 100682397);
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x002769EC File Offset: 0x00274BEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275723, XrefRangeEnd = 275768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x00276A3C File Offset: 0x00274C3C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x0004C0F6 File Offset: 0x0004A2F6
		public ChemistryStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD3 RID: 12243
		// (get) Token: 0x06009B57 RID: 39767 RVA: 0x00276A78 File Offset: 0x00274C78
		// (set) Token: 0x06009B58 RID: 39768 RVA: 0x0004C0FF File Offset: 0x0004A2FF
		public unsafe StationRecipeFieldUI RecipeUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_RecipeUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD4 RID: 12244
		// (get) Token: 0x06009B59 RID: 39769 RVA: 0x00276AA8 File Offset: 0x00274CA8
		// (set) Token: 0x06009B5A RID: 39770 RVA: 0x0004C11E File Offset: 0x0004A31E
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006868 RID: 26728
		private static readonly IntPtr NativeFieldInfoPtr_RecipeUI;

		// Token: 0x04006869 RID: 26729
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x0400686A RID: 26730
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400686B RID: 26731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
