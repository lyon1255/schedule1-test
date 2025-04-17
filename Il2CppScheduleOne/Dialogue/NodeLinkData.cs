using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000448 RID: 1096
	[Serializable]
	public class NodeLinkData : Object
	{
		// Token: 0x06005F90 RID: 24464 RVA: 0x001B6A9C File Offset: 0x001B4C9C
		// Note: this type is marked as 'beforefieldinit'.
		static NodeLinkData()
		{
			Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "NodeLinkData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr);
			NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseDialogueOrBranchNodeGuid");
			NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "BaseChoiceOrOptionGUID");
			NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, "TargetNodeGuid");
			NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr, 100675493);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x001B6B1C File Offset: 0x001B4D1C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NodeLinkData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NodeLinkData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x0002D133 File Offset: 0x0002B333
		public NodeLinkData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06005F93 RID: 24467 RVA: 0x001B6B58 File Offset: 0x001B4D58
		// (set) Token: 0x06005F94 RID: 24468 RVA: 0x0002D13C File Offset: 0x0002B33C
		public unsafe string BaseDialogueOrBranchNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06005F95 RID: 24469 RVA: 0x001B6B80 File Offset: 0x001B4D80
		// (set) Token: 0x06005F96 RID: 24470 RVA: 0x0002D15B File Offset: 0x0002B35B
		public unsafe string BaseChoiceOrOptionGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_BaseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06005F97 RID: 24471 RVA: 0x001B6BA8 File Offset: 0x001B4DA8
		// (set) Token: 0x06005F98 RID: 24472 RVA: 0x0002D17A File Offset: 0x0002B37A
		public unsafe string TargetNodeGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NodeLinkData.NativeFieldInfoPtr_TargetNodeGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004153 RID: 16723
		private static readonly IntPtr NativeFieldInfoPtr_BaseDialogueOrBranchNodeGuid;

		// Token: 0x04004154 RID: 16724
		private static readonly IntPtr NativeFieldInfoPtr_BaseChoiceOrOptionGUID;

		// Token: 0x04004155 RID: 16725
		private static readonly IntPtr NativeFieldInfoPtr_TargetNodeGuid;

		// Token: 0x04004156 RID: 16726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
