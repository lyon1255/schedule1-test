using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management;
using Il2CppScheduleOne.Management.UI;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.UI.Management
{
	// Token: 0x020006C4 RID: 1732
	public class PotConfigPanel : ConfigPanel
	{
		// Token: 0x06009B89 RID: 39817 RVA: 0x0027731C File Offset: 0x0027551C
		// Note: this type is marked as 'beforefieldinit'.
		static PotConfigPanel()
		{
			Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Management", "PotConfigPanel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr);
			PotConfigPanel.NativeFieldInfoPtr_SeedUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "SeedUI");
			PotConfigPanel.NativeFieldInfoPtr_Additive1UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive1UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive2UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive2UI");
			PotConfigPanel.NativeFieldInfoPtr_Additive3UI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "Additive3UI");
			PotConfigPanel.NativeFieldInfoPtr_DestinationUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, "DestinationUI");
			PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682410);
			PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr, 100682411);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x002773D8 File Offset: 0x002755D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 276028, XrefRangeEnd = 276103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Bind(List<EntityConfiguration> configs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(configs);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotConfigPanel.NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x00277428 File Offset: 0x00275628
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 19449, RefRangeEnd = 19463, XrefRangeStart = 19449, XrefRangeEnd = 19463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotConfigPanel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotConfigPanel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotConfigPanel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x0004C2C8 File Offset: 0x0004A4C8
		public PotConfigPanel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002FE0 RID: 12256
		// (get) Token: 0x06009B8D RID: 39821 RVA: 0x00277464 File Offset: 0x00275664
		// (set) Token: 0x06009B8E RID: 39822 RVA: 0x0004C2D1 File Offset: 0x0004A4D1
		public unsafe ItemFieldUI SeedUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_SeedUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x06009B8F RID: 39823 RVA: 0x00277494 File Offset: 0x00275694
		// (set) Token: 0x06009B90 RID: 39824 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		public unsafe ItemFieldUI Additive1UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive1UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x06009B91 RID: 39825 RVA: 0x002774C4 File Offset: 0x002756C4
		// (set) Token: 0x06009B92 RID: 39826 RVA: 0x0004C30F File Offset: 0x0004A50F
		public unsafe ItemFieldUI Additive2UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive2UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x06009B93 RID: 39827 RVA: 0x002774F4 File Offset: 0x002756F4
		// (set) Token: 0x06009B94 RID: 39828 RVA: 0x0004C32E File Offset: 0x0004A52E
		public unsafe ItemFieldUI Additive3UI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_Additive3UI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x06009B95 RID: 39829 RVA: 0x00277524 File Offset: 0x00275724
		// (set) Token: 0x06009B96 RID: 39830 RVA: 0x0004C34D File Offset: 0x0004A54D
		public unsafe ObjectFieldUI DestinationUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotConfigPanel.NativeFieldInfoPtr_DestinationUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006883 RID: 26755
		private static readonly IntPtr NativeFieldInfoPtr_SeedUI;

		// Token: 0x04006884 RID: 26756
		private static readonly IntPtr NativeFieldInfoPtr_Additive1UI;

		// Token: 0x04006885 RID: 26757
		private static readonly IntPtr NativeFieldInfoPtr_Additive2UI;

		// Token: 0x04006886 RID: 26758
		private static readonly IntPtr NativeFieldInfoPtr_Additive3UI;

		// Token: 0x04006887 RID: 26759
		private static readonly IntPtr NativeFieldInfoPtr_DestinationUI;

		// Token: 0x04006888 RID: 26760
		private static readonly IntPtr NativeMethodInfoPtr_Bind_Public_Virtual_Void_List_1_EntityConfiguration_0;

		// Token: 0x04006889 RID: 26761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
