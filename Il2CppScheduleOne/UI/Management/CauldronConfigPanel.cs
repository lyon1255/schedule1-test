using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BB RID: 1723
	public class CauldronConfigPanel : ConfigPanel
	{
		// Token: 0x06009B45 RID: 39749 RVA: 0x002766D8 File Offset: 0x002748D8
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigPanel()
		{
			Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "CauldronConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr);
			CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, "DestinationUI");
			CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682392);
			CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr, 100682393);
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x00276744 File Offset: 0x00274944
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275643, XrefRangeEnd = 275678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CauldronConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x00276794 File Offset: 0x00274994
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x0004C087 File Offset: 0x0004A287
		public CauldronConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FD0 RID: 12240
		// (get) Token: 0x06009B49 RID: 39753 RVA: 0x002767D0 File Offset: 0x002749D0
		// (set) Token: 0x06009B4A RID: 39754 RVA: 0x0004C090 File Offset: 0x0004A290
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006861 RID: 26721
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006862 RID: 26722
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006863 RID: 26723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
