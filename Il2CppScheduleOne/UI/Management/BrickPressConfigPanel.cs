using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006BA RID: 1722
	public class BrickPressConfigPanel : ConfigPanel
	{
		// Token: 0x06009B3F RID: 39743 RVA: 0x002765B0 File Offset: 0x002747B0
		// Note: this type is marked as 'beforefieldinit'.
		static BrickPressConfigPanel()
		{
			Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "BrickPressConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr);
			BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, "DestinationUI");
			BrickPressConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, 100682390);
			BrickPressConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr, 100682391);
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x0027661C File Offset: 0x0027481C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275608, XrefRangeEnd = 275643, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BrickPressConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x0027666C File Offset: 0x0027486C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BrickPressConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BrickPressConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BrickPressConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0004C05F File Offset: 0x0004A25F
		public BrickPressConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FCF RID: 12239
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x002766A8 File Offset: 0x002748A8
		// (set) Token: 0x06009B44 RID: 39748 RVA: 0x0004C068 File Offset: 0x0004A268
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BrickPressConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400685E RID: 26718
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x0400685F RID: 26719
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006860 RID: 26720
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
