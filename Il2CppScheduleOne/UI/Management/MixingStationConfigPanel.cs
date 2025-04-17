using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C1 RID: 1729
	public class MixingStationConfigPanel : ConfigPanel
	{
		// Token: 0x06009B71 RID: 39793 RVA: 0x00276ED8 File Offset: 0x002750D8
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigPanel()
		{
			Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "MixingStationConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr);
			MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "DestinationUI");
			MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, "StartThresholdUI");
			MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682404);
			MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr, 100682405);
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x00276F58 File Offset: 0x00275158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275893, XrefRangeEnd = 275938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x00276FA8 File Offset: 0x002751A8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x0004C1F3 File Offset: 0x0004A3F3
		public MixingStationConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FDA RID: 12250
		// (get) Token: 0x06009B75 RID: 39797 RVA: 0x00276FE4 File Offset: 0x002751E4
		// (set) Token: 0x06009B76 RID: 39798 RVA: 0x0004C1FC File Offset: 0x0004A3FC
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FDB RID: 12251
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x00277014 File Offset: 0x00275214
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x0004C21B File Offset: 0x0004A41B
		public unsafe NumberFieldUI StartThresholdUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigPanel.NativeFieldInfoPtr_StartThresholdUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006877 RID: 26743
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006878 RID: 26744
		private static readonly IntPtr NativeFieldInfoPtr_StartThresholdUI;

		// Token: 0x04006879 RID: 26745
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x0400687A RID: 26746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
