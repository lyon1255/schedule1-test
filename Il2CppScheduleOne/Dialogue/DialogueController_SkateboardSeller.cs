using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000433 RID: 1075
	public class DialogueController_SkateboardSeller : DialogueController
	{
		// Token: 0x06005E75 RID: 24181 RVA: 0x001B2DB8 File Offset: 0x001B0FB8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_SkateboardSeller()
		{
			Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_SkateboardSeller");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr);
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Options");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "chosenWeapon");
			DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "onPurchase");
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675333);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675334);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675335);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675336);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675337);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675338);
			DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, 100675339);
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x001B2EB0 File Offset: 0x001B10B0
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E77 RID: 24183 RVA: 0x001B2EE4 File Offset: 0x001B10E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197107, XrefRangeEnd = 197153, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E78 RID: 24184 RVA: 0x001B2F34 File Offset: 0x001B1134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197153, XrefRangeEnd = 197168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E79 RID: 24185 RVA: 0x001B2FA8 File Offset: 0x001B11A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197205, RefRangeEnd = 197206, XrefRangeStart = 197168, XrefRangeEnd = 197205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetChoices(List<DialogueController_SkateboardSeller.Option> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005E7A RID: 24186 RVA: 0x001B2FF8 File Offset: 0x001B11F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197206, XrefRangeEnd = 197231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E7B RID: 24187 RVA: 0x001B306C File Offset: 0x001B126C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197231, XrefRangeEnd = 197248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_SkateboardSeller.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E7C RID: 24188 RVA: 0x001B30D4 File Offset: 0x001B12D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197248, XrefRangeEnd = 197259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_SkateboardSeller() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E7D RID: 24189 RVA: 0x0002C8A3 File Offset: 0x0002AAA3
		public DialogueController_SkateboardSeller(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C66 RID: 7270
		// (get) Token: 0x06005E7E RID: 24190 RVA: 0x001B3110 File Offset: 0x001B1310
		// (set) Token: 0x06005E7F RID: 24191 RVA: 0x0002C8AC File Offset: 0x0002AAAC
		public unsafe List<DialogueController_SkateboardSeller.Option> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_SkateboardSeller.Option>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C67 RID: 7271
		// (get) Token: 0x06005E80 RID: 24192 RVA: 0x001B3140 File Offset: 0x001B1340
		// (set) Token: 0x06005E81 RID: 24193 RVA: 0x0002C8CB File Offset: 0x0002AACB
		public unsafe DialogueController_SkateboardSeller.Option chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_SkateboardSeller.Option>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C68 RID: 7272
		// (get) Token: 0x06005E82 RID: 24194 RVA: 0x001B3170 File Offset: 0x001B1370
		// (set) Token: 0x06005E83 RID: 24195 RVA: 0x0002C8EA File Offset: 0x0002AAEA
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400409B RID: 16539
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x0400409C RID: 16540
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x0400409D RID: 16541
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x0400409E RID: 16542
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400409F RID: 16543
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x040040A0 RID: 16544
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040040A1 RID: 16545
		private static readonly IntPtr NativeMethodInfoPtr_GetChoices_Private_List_1_DialogueChoiceData_List_1_Option_0;

		// Token: 0x040040A2 RID: 16546
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x040040A3 RID: 16547
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x040040A4 RID: 16548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F9 RID: 2553
		[Serializable]
		public class Option : Object
		{
			// Token: 0x0600CE10 RID: 52752 RVA: 0x00319594 File Offset: 0x00317794
			// Note: this type is marked as 'beforefieldinit'.
			static Option()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "Option");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr);
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Name");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Price");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "IsAvailable");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "NotAvailableReason");
				DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, "Item");
				DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr, 100675340);
			}

			// Token: 0x0600CE11 RID: 52753 RVA: 0x00319638 File Offset: 0x00317838
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Option() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.Option>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.Option.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE12 RID: 52754 RVA: 0x000643BA File Offset: 0x000625BA
			public Option(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004024 RID: 16420
			// (get) Token: 0x0600CE13 RID: 52755 RVA: 0x00319674 File Offset: 0x00317874
			// (set) Token: 0x0600CE14 RID: 52756 RVA: 0x000643C3 File Offset: 0x000625C3
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004025 RID: 16421
			// (get) Token: 0x0600CE15 RID: 52757 RVA: 0x0031969C File Offset: 0x0031789C
			// (set) Token: 0x0600CE16 RID: 52758 RVA: 0x000643E2 File Offset: 0x000625E2
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x17004026 RID: 16422
			// (get) Token: 0x0600CE17 RID: 52759 RVA: 0x003196C4 File Offset: 0x003178C4
			// (set) Token: 0x0600CE18 RID: 52760 RVA: 0x000643FD File Offset: 0x000625FD
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x17004027 RID: 16423
			// (get) Token: 0x0600CE19 RID: 52761 RVA: 0x003196EC File Offset: 0x003178EC
			// (set) Token: 0x0600CE1A RID: 52762 RVA: 0x00064418 File Offset: 0x00062618
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004028 RID: 16424
			// (get) Token: 0x0600CE1B RID: 52763 RVA: 0x00319714 File Offset: 0x00317914
			// (set) Token: 0x0600CE1C RID: 52764 RVA: 0x00064437 File Offset: 0x00062637
			public unsafe ItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.Option.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B26 RID: 35622
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008B27 RID: 35623
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008B28 RID: 35624
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008B29 RID: 35625
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008B2A RID: 35626
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008B2B RID: 35627
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009FA RID: 2554
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass5_0")]
		public sealed class __c__DisplayClass5_0 : Object
		{
			// Token: 0x0600CE1D RID: 52765 RVA: 0x00319744 File Offset: 0x00317944
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass5_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass5_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675341);
				DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr, 100675342);
			}

			// Token: 0x0600CE1E RID: 52766 RVA: 0x003197AC File Offset: 0x003179AC
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass5_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass5_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE1F RID: 52767 RVA: 0x003197E8 File Offset: 0x003179E8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE20 RID: 52768 RVA: 0x00064456 File Offset: 0x00062656
			public __c__DisplayClass5_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004029 RID: 16425
			// (get) Token: 0x0600CE21 RID: 52769 RVA: 0x00319838 File Offset: 0x00317A38
			// (set) Token: 0x0600CE22 RID: 52770 RVA: 0x0006445F File Offset: 0x0006265F
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass5_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B2C RID: 35628
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B2D RID: 35629
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B2E RID: 35630
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_Option_0;
		}

		// Token: 0x020009FB RID: 2555
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_SkateboardSeller+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Object
		{
			// Token: 0x0600CE23 RID: 52771 RVA: 0x00319860 File Offset: 0x00317A60
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_SkateboardSeller>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, "choiceLabel");
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675343);
				DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr, 100675344);
			}

			// Token: 0x0600CE24 RID: 52772 RVA: 0x003198C8 File Offset: 0x00317AC8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_SkateboardSeller.__c__DisplayClass8_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE25 RID: 52773 RVA: 0x00319904 File Offset: 0x00317B04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_SkateboardSeller.Option x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE26 RID: 52774 RVA: 0x0006447E File Offset: 0x0006267E
			public __c__DisplayClass8_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402A RID: 16426
			// (get) Token: 0x0600CE27 RID: 52775 RVA: 0x00319954 File Offset: 0x00317B54
			// (set) Token: 0x0600CE28 RID: 52776 RVA: 0x00064487 File Offset: 0x00062687
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_SkateboardSeller.__c__DisplayClass8_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B2F RID: 35631
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B30 RID: 35632
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B31 RID: 35633
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_Option_0;
		}
	}
}
