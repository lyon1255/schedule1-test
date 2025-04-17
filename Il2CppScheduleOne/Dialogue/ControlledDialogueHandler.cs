using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042B RID: 1067
	public class ControlledDialogueHandler : DialogueHandler
	{
		// Token: 0x06005DDF RID: 24031 RVA: 0x001B091C File Offset: 0x001AEB1C
		// Note: this type is marked as 'beforefieldinit'.
		static ControlledDialogueHandler()
		{
			Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "ControlledDialogueHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr);
			ControlledDialogueHandler.NativeFieldInfoPtr_controller = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, "controller");
			ControlledDialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675243);
			ControlledDialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675244);
			ControlledDialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675245);
			ControlledDialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675246);
			ControlledDialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675247);
			ControlledDialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675248);
			ControlledDialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675249);
			ControlledDialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr, 100675250);
		}

		// Token: 0x06005DE0 RID: 24032 RVA: 0x001B0A00 File Offset: 0x001AEC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196107, XrefRangeEnd = 196112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE1 RID: 24033 RVA: 0x001B0A3C File Offset: 0x001AEC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196112, XrefRangeEnd = 196113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DE2 RID: 24034 RVA: 0x001B0AA4 File Offset: 0x001AECA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196113, XrefRangeEnd = 196114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DE3 RID: 24035 RVA: 0x001B0B0C File Offset: 0x001AED0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196114, XrefRangeEnd = 196115, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005DE4 RID: 24036 RVA: 0x001B0B80 File Offset: 0x001AED80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196118, RefRangeEnd = 196120, XrefRangeStart = 196115, XrefRangeEnd = 196118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE5 RID: 24037 RVA: 0x001B0BD0 File Offset: 0x001AEDD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196138, RefRangeEnd = 196140, XrefRangeStart = 196120, XrefRangeEnd = 196138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DE6 RID: 24038 RVA: 0x001B0C28 File Offset: 0x001AEE28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196140, XrefRangeEnd = 196147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ControlledDialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005DE7 RID: 24039 RVA: 0x001B0C9C File Offset: 0x001AEE9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196147, XrefRangeEnd = 196148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ControlledDialogueHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlledDialogueHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ControlledDialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DE8 RID: 24040 RVA: 0x0002C46A File Offset: 0x0002A66A
		public ControlledDialogueHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06005DE9 RID: 24041 RVA: 0x001B0CD8 File Offset: 0x001AEED8
		// (set) Token: 0x06005DEA RID: 24042 RVA: 0x0002C473 File Offset: 0x0002A673
		public unsafe DialogueController controller
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlledDialogueHandler.NativeFieldInfoPtr_controller);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ControlledDialogueHandler.NativeFieldInfoPtr_controller), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004037 RID: 16439
		private static readonly IntPtr NativeFieldInfoPtr_controller;

		// Token: 0x04004038 RID: 16440
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004039 RID: 16441
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400403A RID: 16442
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400403B RID: 16443
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x0400403C RID: 16444
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400403D RID: 16445
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x0400403E RID: 16446
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x0400403F RID: 16447
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
