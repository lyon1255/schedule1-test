using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BF RID: 1727
	public class DryingRackConfigPanel : ConfigPanel
	{
		// Token: 0x06009B63 RID: 39779 RVA: 0x00276C44 File Offset: 0x00274E44
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigPanel()
		{
			Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "DryingRackConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr);
			DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "QualityUI");
			DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, "DestinationUI");
			DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682400);
			DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr, 100682401);
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x00276CC4 File Offset: 0x00274EC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275813, XrefRangeEnd = 275858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x00276D14 File Offset: 0x00274F14
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x0004C184 File Offset: 0x0004A384
		public DryingRackConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD7 RID: 12247
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x00276D50 File Offset: 0x00274F50
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x0004C18D File Offset: 0x0004A38D
		public unsafe QualityFieldUI QualityUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_QualityUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FD8 RID: 12248
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x00276D80 File Offset: 0x00274F80
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x0004C1AC File Offset: 0x0004A3AC
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006870 RID: 26736
		private static readonly IntPtr NativeFieldInfoPtr_QualityUI;

		// Token: 0x04006871 RID: 26737
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006872 RID: 26738
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006873 RID: 26739
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
