using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042D RID: 1069
	public class DialogueController_ArmsDealer : DialogueController
	{
		// Token: 0x06005E1F RID: 24095 RVA: 0x001B1938 File Offset: 0x001AFB38
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_ArmsDealer()
		{
			Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_ArmsDealer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr);
			DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "MeleeWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "RangedWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "Ammo");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "allWeapons");
			DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "chosenWeapon");
			DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675289);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675290);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675291);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675292);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675293);
			DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675294);
			DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, 100675295);
		}

		// Token: 0x06005E20 RID: 24096 RVA: 0x001B1A58 File Offset: 0x001AFC58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196506, XrefRangeEnd = 196521, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E21 RID: 24097 RVA: 0x001B1A8C File Offset: 0x001AFC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196521, XrefRangeEnd = 196555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E22 RID: 24098 RVA: 0x001B1ADC File Offset: 0x001AFCDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196555, XrefRangeEnd = 196576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005E23 RID: 24099 RVA: 0x001B1B50 File Offset: 0x001AFD50
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196613, RefRangeEnd = 196616, XrefRangeStart = 196576, XrefRangeEnd = 196613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueChoiceData> GetWeaponChoices(List<DialogueController_ArmsDealer.WeaponOption> options)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(options);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr3) : null;
		}

		// Token: 0x06005E24 RID: 24100 RVA: 0x001B1BA0 File Offset: 0x001AFDA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196616, XrefRangeEnd = 196646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E25 RID: 24101 RVA: 0x001B1C14 File Offset: 0x001AFE14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196646, XrefRangeEnd = 196663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_ArmsDealer.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E26 RID: 24102 RVA: 0x001B1C7C File Offset: 0x001AFE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196663, XrefRangeEnd = 196667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_ArmsDealer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E27 RID: 24103 RVA: 0x0002C62C File Offset: 0x0002A82C
		public DialogueController_ArmsDealer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06005E28 RID: 24104 RVA: 0x001B1CB8 File Offset: 0x001AFEB8
		// (set) Token: 0x06005E29 RID: 24105 RVA: 0x0002C635 File Offset: 0x0002A835
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> MeleeWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_MeleeWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06005E2A RID: 24106 RVA: 0x001B1CE8 File Offset: 0x001AFEE8
		// (set) Token: 0x06005E2B RID: 24107 RVA: 0x0002C654 File Offset: 0x0002A854
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> RangedWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_RangedWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x06005E2C RID: 24108 RVA: 0x001B1D18 File Offset: 0x001AFF18
		// (set) Token: 0x06005E2D RID: 24109 RVA: 0x0002C673 File Offset: 0x0002A873
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> Ammo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_Ammo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x06005E2E RID: 24110 RVA: 0x001B1D48 File Offset: 0x001AFF48
		// (set) Token: 0x06005E2F RID: 24111 RVA: 0x0002C692 File Offset: 0x0002A892
		public unsafe List<DialogueController_ArmsDealer.WeaponOption> allWeapons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController_ArmsDealer.WeaponOption>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_allWeapons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06005E30 RID: 24112 RVA: 0x001B1D78 File Offset: 0x001AFF78
		// (set) Token: 0x06005E31 RID: 24113 RVA: 0x0002C6B1 File Offset: 0x0002A8B1
		public unsafe DialogueController_ArmsDealer.WeaponOption chosenWeapon
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_ArmsDealer.WeaponOption>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.NativeFieldInfoPtr_chosenWeapon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004064 RID: 16484
		private static readonly IntPtr NativeFieldInfoPtr_MeleeWeapons;

		// Token: 0x04004065 RID: 16485
		private static readonly IntPtr NativeFieldInfoPtr_RangedWeapons;

		// Token: 0x04004066 RID: 16486
		private static readonly IntPtr NativeFieldInfoPtr_Ammo;

		// Token: 0x04004067 RID: 16487
		private static readonly IntPtr NativeFieldInfoPtr_allWeapons;

		// Token: 0x04004068 RID: 16488
		private static readonly IntPtr NativeFieldInfoPtr_chosenWeapon;

		// Token: 0x04004069 RID: 16489
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400406A RID: 16490
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x0400406B RID: 16491
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x0400406C RID: 16492
		private static readonly IntPtr NativeMethodInfoPtr_GetWeaponChoices_Private_List_1_DialogueChoiceData_List_1_WeaponOption_0;

		// Token: 0x0400406D RID: 16493
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x0400406E RID: 16494
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x0400406F RID: 16495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F5 RID: 2549
		[Serializable]
		public class WeaponOption : Object
		{
			// Token: 0x0600CDEF RID: 52719 RVA: 0x00319054 File Offset: 0x00317254
			// Note: this type is marked as 'beforefieldinit'.
			static WeaponOption()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "WeaponOption");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr);
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Name");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Price");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "IsAvailable");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "NotAvailableReason");
				DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, "Item");
				DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr, 100675296);
			}

			// Token: 0x0600CDF0 RID: 52720 RVA: 0x003190F8 File Offset: 0x003172F8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeaponOption() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.WeaponOption>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.WeaponOption.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDF1 RID: 52721 RVA: 0x000642A1 File Offset: 0x000624A1
			public WeaponOption(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700401B RID: 16411
			// (get) Token: 0x0600CDF2 RID: 52722 RVA: 0x00319134 File Offset: 0x00317334
			// (set) Token: 0x0600CDF3 RID: 52723 RVA: 0x000642AA File Offset: 0x000624AA
			public unsafe string Name
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700401C RID: 16412
			// (get) Token: 0x0600CDF4 RID: 52724 RVA: 0x0031915C File Offset: 0x0031735C
			// (set) Token: 0x0600CDF5 RID: 52725 RVA: 0x000642C9 File Offset: 0x000624C9
			public unsafe float Price
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Price)) = value;
				}
			}

			// Token: 0x1700401D RID: 16413
			// (get) Token: 0x0600CDF6 RID: 52726 RVA: 0x00319184 File Offset: 0x00317384
			// (set) Token: 0x0600CDF7 RID: 52727 RVA: 0x000642E4 File Offset: 0x000624E4
			public unsafe bool IsAvailable
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_IsAvailable)) = value;
				}
			}

			// Token: 0x1700401E RID: 16414
			// (get) Token: 0x0600CDF8 RID: 52728 RVA: 0x003191AC File Offset: 0x003173AC
			// (set) Token: 0x0600CDF9 RID: 52729 RVA: 0x000642FF File Offset: 0x000624FF
			public unsafe string NotAvailableReason
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_NotAvailableReason), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700401F RID: 16415
			// (get) Token: 0x0600CDFA RID: 52730 RVA: 0x003191D4 File Offset: 0x003173D4
			// (set) Token: 0x0600CDFB RID: 52731 RVA: 0x0006431E File Offset: 0x0006251E
			public unsafe StorableItemDefinition Item
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<StorableItemDefinition>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.WeaponOption.NativeFieldInfoPtr_Item), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B16 RID: 35606
			private static readonly IntPtr NativeFieldInfoPtr_Name;

			// Token: 0x04008B17 RID: 35607
			private static readonly IntPtr NativeFieldInfoPtr_Price;

			// Token: 0x04008B18 RID: 35608
			private static readonly IntPtr NativeFieldInfoPtr_IsAvailable;

			// Token: 0x04008B19 RID: 35609
			private static readonly IntPtr NativeFieldInfoPtr_NotAvailableReason;

			// Token: 0x04008B1A RID: 35610
			private static readonly IntPtr NativeFieldInfoPtr_Item;

			// Token: 0x04008B1B RID: 35611
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F6 RID: 2550
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass10_0")]
		public sealed class __c__DisplayClass10_0 : Object
		{
			// Token: 0x0600CDFC RID: 52732 RVA: 0x00319204 File Offset: 0x00317404
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass10_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass10_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675297);
				DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr, 100675298);
			}

			// Token: 0x0600CDFD RID: 52733 RVA: 0x0031926C File Offset: 0x0031746C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass10_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass10_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDFE RID: 52734 RVA: 0x003192A8 File Offset: 0x003174A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CheckChoice_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDFF RID: 52735 RVA: 0x0006433D File Offset: 0x0006253D
			public __c__DisplayClass10_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004020 RID: 16416
			// (get) Token: 0x0600CE00 RID: 52736 RVA: 0x003192F8 File Offset: 0x003174F8
			// (set) Token: 0x0600CE01 RID: 52737 RVA: 0x00064346 File Offset: 0x00062546
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass10_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B1C RID: 35612
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B1D RID: 35613
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B1E RID: 35614
			private static readonly IntPtr NativeMethodInfoPtr__CheckChoice_b__0_Internal_Boolean_WeaponOption_0;
		}

		// Token: 0x020009F7 RID: 2551
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_ArmsDealer+<>c__DisplayClass7_0")]
		public sealed class __c__DisplayClass7_0 : Object
		{
			// Token: 0x0600CE02 RID: 52738 RVA: 0x00319320 File Offset: 0x00317520
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass7_0()
			{
				Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_ArmsDealer>.NativeClassPtr, "<>c__DisplayClass7_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, "choiceLabel");
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675299);
				DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr, 100675300);
			}

			// Token: 0x0600CE03 RID: 52739 RVA: 0x00319388 File Offset: 0x00317588
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass7_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_ArmsDealer.__c__DisplayClass7_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE04 RID: 52740 RVA: 0x003193C4 File Offset: 0x003175C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _ChoiceCallback_b__0(DialogueController_ArmsDealer.WeaponOption x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE05 RID: 52741 RVA: 0x00064365 File Offset: 0x00062565
			public __c__DisplayClass7_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004021 RID: 16417
			// (get) Token: 0x0600CE06 RID: 52742 RVA: 0x00319414 File Offset: 0x00317614
			// (set) Token: 0x0600CE07 RID: 52743 RVA: 0x0006436E File Offset: 0x0006256E
			public unsafe string choiceLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_ArmsDealer.__c__DisplayClass7_0.NativeFieldInfoPtr_choiceLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B1F RID: 35615
			private static readonly IntPtr NativeFieldInfoPtr_choiceLabel;

			// Token: 0x04008B20 RID: 35616
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B21 RID: 35617
			private static readonly IntPtr NativeMethodInfoPtr__ChoiceCallback_b__0_Internal_Boolean_WeaponOption_0;
		}
	}
}
