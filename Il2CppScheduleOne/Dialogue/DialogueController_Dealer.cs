using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Economy;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042F RID: 1071
	public class DialogueController_Dealer : DialogueController
	{
		// Token: 0x06005E39 RID: 24121 RVA: 0x001B1F38 File Offset: 0x001B0138
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Dealer()
		{
			Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Dealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr);
			DialogueController_Dealer.NativeFieldInfoPtr__Dealer_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, "<Dealer>k__BackingField");
			DialogueController_Dealer.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675304);
			DialogueController_Dealer.NativeMethodInfoPtr_set_Dealer_Private_set_Void_Dealer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675305);
			DialogueController_Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675306);
			DialogueController_Dealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675307);
			DialogueController_Dealer.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675308);
			DialogueController_Dealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675309);
			DialogueController_Dealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675310);
			DialogueController_Dealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr, 100675311);
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x001B201C File Offset: 0x001B021C
		// (set) Token: 0x06005E3B RID: 24123 RVA: 0x001B205C File Offset: 0x001B025C
		public unsafe Dealer Dealer
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Dealer.NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Dealer.NativeMethodInfoPtr_set_Dealer_Private_set_Void_Dealer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x001B20A0 File Offset: 0x001B02A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196695, XrefRangeEnd = 196701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dealer.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x001B20DC File Offset: 0x001B02DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196701, XrefRangeEnd = 196738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x001B2144 File Offset: 0x001B0344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196738, XrefRangeEnd = 196756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dealer.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E3F RID: 24127 RVA: 0x001B21AC File Offset: 0x001B03AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196756, XrefRangeEnd = 196773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E40 RID: 24128 RVA: 0x001B2220 File Offset: 0x001B0420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196773, XrefRangeEnd = 196789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Dealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E41 RID: 24129 RVA: 0x001B2270 File Offset: 0x001B0470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196789, XrefRangeEnd = 196793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Dealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Dealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Dealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
		public DialogueController_Dealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06005E43 RID: 24131 RVA: 0x001B22AC File Offset: 0x001B04AC
		// (set) Token: 0x06005E44 RID: 24132 RVA: 0x0002C701 File Offset: 0x0002A901
		public unsafe Dealer _Dealer_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dealer.NativeFieldInfoPtr__Dealer_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dealer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Dealer.NativeFieldInfoPtr__Dealer_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004074 RID: 16500
		private static readonly IntPtr NativeFieldInfoPtr__Dealer_k__BackingField;

		// Token: 0x04004075 RID: 16501
		private static readonly IntPtr NativeMethodInfoPtr_get_Dealer_Public_get_Dealer_0;

		// Token: 0x04004076 RID: 16502
		private static readonly IntPtr NativeMethodInfoPtr_set_Dealer_Private_set_Void_Dealer_0;

		// Token: 0x04004077 RID: 16503
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004078 RID: 16504
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04004079 RID: 16505
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x0400407A RID: 16506
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x0400407B RID: 16507
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x0400407C RID: 16508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
