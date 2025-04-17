using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Police;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043E RID: 1086
	public class DialogueHandler_Police : ControlledDialogueHandler
	{
		// Token: 0x06005F27 RID: 24359 RVA: 0x001B55D4 File Offset: 0x001B37D4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_Police()
		{
			Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_Police");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr);
			DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, "CheckpointRequestDialogue");
			DialogueHandler_Police.NativeFieldInfoPtr_officer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, "officer");
			DialogueHandler_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675440);
			DialogueHandler_Police.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675441);
			DialogueHandler_Police.NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675442);
			DialogueHandler_Police.NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675443);
			DialogueHandler_Police.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675444);
			DialogueHandler_Police.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr, 100675445);
		}

		// Token: 0x06005F28 RID: 24360 RVA: 0x001B56A4 File Offset: 0x001B38A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198120, XrefRangeEnd = 198132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F29 RID: 24361 RVA: 0x001B56E0 File Offset: 0x001B38E0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2A RID: 24362 RVA: 0x001B571C File Offset: 0x001B391C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198132, XrefRangeEnd = 198165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2B RID: 24363 RVA: 0x001B5758 File Offset: 0x001B3958
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198165, XrefRangeEnd = 198172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanTalk_Checkpoint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Police.NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F2C RID: 24364 RVA: 0x001B5794 File Offset: 0x001B3994
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198172, XrefRangeEnd = 198193, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_Police.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F2D RID: 24365 RVA: 0x001B57EC File Offset: 0x001B39EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_Police() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_Police>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_Police.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F2E RID: 24366 RVA: 0x0002CDD0 File Offset: 0x0002AFD0
		public DialogueHandler_Police(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C94 RID: 7316
		// (get) Token: 0x06005F2F RID: 24367 RVA: 0x001B5828 File Offset: 0x001B3A28
		// (set) Token: 0x06005F30 RID: 24368 RVA: 0x0002CDD9 File Offset: 0x0002AFD9
		public unsafe DialogueContainer CheckpointRequestDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_CheckpointRequestDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x06005F31 RID: 24369 RVA: 0x001B5858 File Offset: 0x001B3A58
		// (set) Token: 0x06005F32 RID: 24370 RVA: 0x0002CDF8 File Offset: 0x0002AFF8
		public unsafe PoliceOfficer officer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_officer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceOfficer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_Police.NativeFieldInfoPtr_officer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400410E RID: 16654
		private static readonly IntPtr NativeFieldInfoPtr_CheckpointRequestDialogue;

		// Token: 0x0400410F RID: 16655
		private static readonly IntPtr NativeFieldInfoPtr_officer;

		// Token: 0x04004110 RID: 16656
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004111 RID: 16657
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_Void_0;

		// Token: 0x04004112 RID: 16658
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_Void_0;

		// Token: 0x04004113 RID: 16659
		private static readonly IntPtr NativeMethodInfoPtr_CanTalk_Checkpoint_Private_Boolean_0;

		// Token: 0x04004114 RID: 16660
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x04004115 RID: 16661
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
