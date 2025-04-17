using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs.CharacterClasses;
using Il2CppSystem;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043F RID: 1087
	public class DialogueHandler_VehicleSalesman : ControlledDialogueHandler
	{
		// Token: 0x06005F33 RID: 24371 RVA: 0x001B5888 File Offset: 0x001B3A88
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler_VehicleSalesman()
		{
			Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler_VehicleSalesman");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr);
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "Salesman");
			DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "selectedVehicle");
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675446);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675447);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675448);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675449);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675450);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675451);
			DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, 100675452);
		}

		// Token: 0x06005F34 RID: 24372 RVA: 0x001B596C File Offset: 0x001B3B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198193, XrefRangeEnd = 198225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F35 RID: 24373 RVA: 0x001B59D4 File Offset: 0x001B3BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198225, XrefRangeEnd = 198240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005F36 RID: 24374 RVA: 0x001B5A48 File Offset: 0x001B3C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198240, XrefRangeEnd = 198265, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F37 RID: 24375 RVA: 0x001B5A98 File Offset: 0x001B3C98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198265, XrefRangeEnd = 198273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005F38 RID: 24376 RVA: 0x001B5AF0 File Offset: 0x001B3CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198273, XrefRangeEnd = 198274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DialogueCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F39 RID: 24377 RVA: 0x001B5B40 File Offset: 0x001B3D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 198274, XrefRangeEnd = 198282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler_VehicleSalesman.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005F3A RID: 24378 RVA: 0x001B5BA8 File Offset: 0x001B3DA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler_VehicleSalesman() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005F3B RID: 24379 RVA: 0x0002CE17 File Offset: 0x0002B017
		public DialogueHandler_VehicleSalesman(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x06005F3C RID: 24380 RVA: 0x001B5BE4 File Offset: 0x001B3DE4
		// (set) Token: 0x06005F3D RID: 24381 RVA: 0x0002CE20 File Offset: 0x0002B020
		public unsafe Jeremy Salesman
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_Salesman), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C97 RID: 7319
		// (get) Token: 0x06005F3E RID: 24382 RVA: 0x001B5C14 File Offset: 0x001B3E14
		// (set) Token: 0x06005F3F RID: 24383 RVA: 0x0002CE3F File Offset: 0x0002B03F
		public unsafe Jeremy.DealershipListing selectedVehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jeremy.DealershipListing>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.NativeFieldInfoPtr_selectedVehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004116 RID: 16662
		private static readonly IntPtr NativeFieldInfoPtr_Salesman;

		// Token: 0x04004117 RID: 16663
		private static readonly IntPtr NativeFieldInfoPtr_selectedVehicle;

		// Token: 0x04004118 RID: 16664
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_String_String_String_0;

		// Token: 0x04004119 RID: 16665
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x0400411A RID: 16666
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400411B RID: 16667
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_Int32_String_0;

		// Token: 0x0400411C RID: 16668
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_Void_String_0;

		// Token: 0x0400411D RID: 16669
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_String_String_String_0;

		// Token: 0x0400411E RID: 16670
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A04 RID: 2564
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x0600CE64 RID: 52836 RVA: 0x0031A4F0 File Offset: 0x003186F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100675453);
				DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr, 100675454);
			}

			// Token: 0x0600CE65 RID: 52837 RVA: 0x0031A558 File Offset: 0x00318758
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE66 RID: 52838 RVA: 0x0031A594 File Offset: 0x00318794
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ModifyChoiceText_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE67 RID: 52839 RVA: 0x0006463F File Offset: 0x0006283F
			public __c__DisplayClass2_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004036 RID: 16438
			// (get) Token: 0x0600CE68 RID: 52840 RVA: 0x0031A5E4 File Offset: 0x003187E4
			// (set) Token: 0x0600CE69 RID: 52841 RVA: 0x00064648 File Offset: 0x00062848
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass2_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B52 RID: 35666
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B53 RID: 35667
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B54 RID: 35668
			private static readonly IntPtr NativeMethodInfoPtr__ModifyChoiceText_b__0_Internal_Boolean_DealershipListing_0;
		}

		// Token: 0x02000A05 RID: 2565
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler_VehicleSalesman+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Object
		{
			// Token: 0x0600CE6A RID: 52842 RVA: 0x0031A60C File Offset: 0x0031880C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, "choiceLabel");
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100675455);
				DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr, 100675456);
			}

			// Token: 0x0600CE6B RID: 52843 RVA: 0x0031A674 File Offset: 0x00318874
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler_VehicleSalesman.__c__DisplayClass4_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE6C RID: 52844 RVA: 0x0031A6B0 File Offset: 0x003188B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(Jeremy.DealershipListing x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE6D RID: 52845 RVA: 0x00064667 File Offset: 0x00062867
			public __c__DisplayClass4_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004037 RID: 16439
			// (get) Token: 0x0600CE6E RID: 52846 RVA: 0x0031A700 File Offset: 0x00318900
			// (set) Token: 0x0600CE6F RID: 52847 RVA: 0x00064670 File Offset: 0x00062870
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler_VehicleSalesman.__c__DisplayClass4_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B55 RID: 35669
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B56 RID: 35670
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B57 RID: 35671
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_DealershipListing_0;
		}
	}
}
