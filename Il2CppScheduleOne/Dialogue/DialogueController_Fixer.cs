using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.Property;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000430 RID: 1072
	public class DialogueController_Fixer : DialogueController
	{
		// Token: 0x06005E45 RID: 24133 RVA: 0x001B22DC File Offset: 0x001B04DC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Fixer()
		{
			Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Fixer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr);
			DialogueController_Fixer.NativeFieldInfoPtr_selectedEmployeeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, "selectedEmployeeType");
			DialogueController_Fixer.NativeFieldInfoPtr_selectedProperty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, "selectedProperty");
			DialogueController_Fixer.NativeFieldInfoPtr_lastConfirmationWasInitial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, "lastConfirmationWasInitial");
			DialogueController_Fixer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675312);
			DialogueController_Fixer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675313);
			DialogueController_Fixer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675314);
			DialogueController_Fixer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675315);
			DialogueController_Fixer.NativeMethodInfoPtr_DecideBranch_Public_Virtual_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675316);
			DialogueController_Fixer.NativeMethodInfoPtr_Confirm_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675317);
			DialogueController_Fixer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr, 100675318);
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x001B23D4 File Offset: 0x001B05D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196793, XrefRangeEnd = 196848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Fixer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x001B2424 File Offset: 0x001B0624
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196848, XrefRangeEnd = 196887, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Fixer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E48 RID: 24136 RVA: 0x001B2498 File Offset: 0x001B0698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196887, XrefRangeEnd = 196915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Fixer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E49 RID: 24137 RVA: 0x001B250C File Offset: 0x001B070C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196915, XrefRangeEnd = 196942, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Fixer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E4A RID: 24138 RVA: 0x001B2574 File Offset: 0x001B0774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196942, XrefRangeEnd = 196945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool DecideBranch(string branchLabel, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Fixer.NativeMethodInfoPtr_DecideBranch_Public_Virtual_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x001B25DC File Offset: 0x001B07DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196979, RefRangeEnd = 196980, XrefRangeStart = 196945, XrefRangeEnd = 196979, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Confirm()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Fixer.NativeMethodInfoPtr_Confirm_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4C RID: 24140 RVA: 0x001B2610 File Offset: 0x001B0810
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196980, XrefRangeEnd = 196984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Fixer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Fixer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Fixer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E4D RID: 24141 RVA: 0x0002C720 File Offset: 0x0002A920
		public DialogueController_Fixer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06005E4E RID: 24142 RVA: 0x001B264C File Offset: 0x001B084C
		// (set) Token: 0x06005E4F RID: 24143 RVA: 0x0002C729 File Offset: 0x0002A929
		public unsafe EEmployeeType selectedEmployeeType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_selectedEmployeeType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_selectedEmployeeType)) = value;
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06005E50 RID: 24144 RVA: 0x001B2674 File Offset: 0x001B0874
		// (set) Token: 0x06005E51 RID: 24145 RVA: 0x0002C744 File Offset: 0x0002A944
		public unsafe Property selectedProperty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_selectedProperty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_selectedProperty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06005E52 RID: 24146 RVA: 0x001B26A4 File Offset: 0x001B08A4
		// (set) Token: 0x06005E53 RID: 24147 RVA: 0x0002C763 File Offset: 0x0002A963
		public unsafe bool lastConfirmationWasInitial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_lastConfirmationWasInitial);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Fixer.NativeFieldInfoPtr_lastConfirmationWasInitial)) = value;
			}
		}

		// Token: 0x0400407D RID: 16509
		private static readonly IntPtr NativeFieldInfoPtr_selectedEmployeeType;

		// Token: 0x0400407E RID: 16510
		private static readonly IntPtr NativeFieldInfoPtr_selectedProperty;

		// Token: 0x0400407F RID: 16511
		private static readonly IntPtr NativeFieldInfoPtr_lastConfirmationWasInitial;

		// Token: 0x04004080 RID: 16512
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04004081 RID: 16513
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x04004082 RID: 16514
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004083 RID: 16515
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04004084 RID: 16516
		private static readonly IntPtr NativeMethodInfoPtr_DecideBranch_Public_Virtual_Boolean_String_byref_Int32_0;

		// Token: 0x04004085 RID: 16517
		private static readonly IntPtr NativeMethodInfoPtr_Confirm_Private_Void_0;

		// Token: 0x04004086 RID: 16518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
