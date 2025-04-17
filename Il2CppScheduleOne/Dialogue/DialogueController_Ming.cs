using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Property;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x02000431 RID: 1073
	public class DialogueController_Ming : DialogueController
	{
		// Token: 0x06005E54 RID: 24148 RVA: 0x001B26CC File Offset: 0x001B08CC
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController_Ming()
		{
			Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController_Ming");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr);
			DialogueController_Ming.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Property");
			DialogueController_Ming.NativeFieldInfoPtr_Price = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "Price");
			DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_BuyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "BuyText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindText");
			DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "RemindLocationDialogue");
			DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "PurchaseRoomQuests");
			DialogueController_Ming.NativeFieldInfoPtr_onPurchase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "onPurchase");
			DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675319);
			DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675320);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675321);
			DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675322);
			DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675323);
			DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675324);
			DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675325);
			DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, 100675326);
		}

		// Token: 0x06005E55 RID: 24149 RVA: 0x001B283C File Offset: 0x001B0A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196984, XrefRangeEnd = 197022, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E56 RID: 24150 RVA: 0x001B2878 File Offset: 0x001B0A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197022, XrefRangeEnd = 197027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanBuyRoom(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E57 RID: 24151 RVA: 0x001B28C4 File Offset: 0x001B0AC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197027, XrefRangeEnd = 197039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E58 RID: 24152 RVA: 0x001B292C File Offset: 0x001B0B2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197039, XrefRangeEnd = 197053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005E59 RID: 24153 RVA: 0x001B2994 File Offset: 0x001B0B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197053, XrefRangeEnd = 197065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005E5A RID: 24154 RVA: 0x001B2A08 File Offset: 0x001B0C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197065, XrefRangeEnd = 197082, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController_Ming.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E5B RID: 24155 RVA: 0x001B2A58 File Offset: 0x001B0C58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197082, XrefRangeEnd = 197094, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController_Ming() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E5C RID: 24156 RVA: 0x001B2A94 File Offset: 0x001B0C94
		[CallerCount(0)]
		public unsafe bool _Start_b__8_0(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E5D RID: 24157 RVA: 0x0002C77E File Offset: 0x0002A97E
		public DialogueController_Ming(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06005E5E RID: 24158 RVA: 0x001B2AE0 File Offset: 0x001B0CE0
		// (set) Token: 0x06005E5F RID: 24159 RVA: 0x0002C787 File Offset: 0x0002A987
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06005E60 RID: 24160 RVA: 0x001B2B10 File Offset: 0x001B0D10
		// (set) Token: 0x06005E61 RID: 24161 RVA: 0x0002C7A6 File Offset: 0x0002A9A6
		public unsafe float Price
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_Price)) = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x001B2B38 File Offset: 0x001B0D38
		// (set) Token: 0x06005E63 RID: 24163 RVA: 0x0002C7C1 File Offset: 0x0002A9C1
		public unsafe DialogueContainer BuyDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x001B2B68 File Offset: 0x001B0D68
		// (set) Token: 0x06005E65 RID: 24165 RVA: 0x0002C7E0 File Offset: 0x0002A9E0
		public unsafe string BuyText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_BuyText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06005E66 RID: 24166 RVA: 0x001B2B90 File Offset: 0x001B0D90
		// (set) Token: 0x06005E67 RID: 24167 RVA: 0x0002C7FF File Offset: 0x0002A9FF
		public unsafe string RemindText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06005E68 RID: 24168 RVA: 0x001B2BB8 File Offset: 0x001B0DB8
		// (set) Token: 0x06005E69 RID: 24169 RVA: 0x0002C81E File Offset: 0x0002AA1E
		public unsafe DialogueContainer RemindLocationDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_RemindLocationDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x06005E6A RID: 24170 RVA: 0x001B2BE8 File Offset: 0x001B0DE8
		// (set) Token: 0x06005E6B RID: 24171 RVA: 0x0002C83D File Offset: 0x0002AA3D
		public unsafe Il2CppReferenceArray<QuestEntry> PurchaseRoomQuests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<QuestEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_PurchaseRoomQuests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x06005E6C RID: 24172 RVA: 0x001B2C18 File Offset: 0x001B0E18
		// (set) Token: 0x06005E6D RID: 24173 RVA: 0x0002C85C File Offset: 0x0002AA5C
		public unsafe UnityEvent onPurchase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController_Ming.NativeFieldInfoPtr_onPurchase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004087 RID: 16519
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x04004088 RID: 16520
		private static readonly IntPtr NativeFieldInfoPtr_Price;

		// Token: 0x04004089 RID: 16521
		private static readonly IntPtr NativeFieldInfoPtr_BuyDialogue;

		// Token: 0x0400408A RID: 16522
		private static readonly IntPtr NativeFieldInfoPtr_BuyText;

		// Token: 0x0400408B RID: 16523
		private static readonly IntPtr NativeFieldInfoPtr_RemindText;

		// Token: 0x0400408C RID: 16524
		private static readonly IntPtr NativeFieldInfoPtr_RemindLocationDialogue;

		// Token: 0x0400408D RID: 16525
		private static readonly IntPtr NativeFieldInfoPtr_PurchaseRoomQuests;

		// Token: 0x0400408E RID: 16526
		private static readonly IntPtr NativeFieldInfoPtr_onPurchase;

		// Token: 0x0400408F RID: 16527
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004090 RID: 16528
		private static readonly IntPtr NativeMethodInfoPtr_CanBuyRoom_Private_Boolean_Boolean_0;

		// Token: 0x04004091 RID: 16529
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_String_String_String_0;

		// Token: 0x04004092 RID: 16530
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_String_String_String_0;

		// Token: 0x04004093 RID: 16531
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_Boolean_String_byref_String_0;

		// Token: 0x04004094 RID: 16532
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_Void_String_0;

		// Token: 0x04004095 RID: 16533
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004096 RID: 16534
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__8_0_Private_Boolean_Boolean_0;

		// Token: 0x020009F8 RID: 2552
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController_Ming+<>c")]
		[Serializable]
		public new sealed class __c : Object
		{
			// Token: 0x0600CE08 RID: 52744 RVA: 0x0031943C File Offset: 0x0031763C
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController_Ming>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr);
				DialogueController_Ming.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9");
				DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, "<>9__9_0");
				DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675328);
				DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr, 100675329);
			}

			// Token: 0x0600CE09 RID: 52745 RVA: 0x003194B8 File Offset: 0x003176B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController_Ming.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE0A RID: 52746 RVA: 0x003194F4 File Offset: 0x003176F4
			[CallerCount(0)]
			public unsafe bool _CanBuyRoom_b__9_0(QuestEntry q)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(q);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController_Ming.__c.NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE0B RID: 52747 RVA: 0x0006438D File Offset: 0x0006258D
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004022 RID: 16418
			// (get) Token: 0x0600CE0C RID: 52748 RVA: 0x00319544 File Offset: 0x00317744
			// (set) Token: 0x0600CE0D RID: 52749 RVA: 0x00064396 File Offset: 0x00062596
			public unsafe static DialogueController_Ming.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController_Ming.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004023 RID: 16419
			// (get) Token: 0x0600CE0E RID: 52750 RVA: 0x0031956C File Offset: 0x0031776C
			// (set) Token: 0x0600CE0F RID: 52751 RVA: 0x000643A8 File Offset: 0x000625A8
			public unsafe static Func<QuestEntry, bool> __9__9_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<QuestEntry, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController_Ming.__c.NativeFieldInfoPtr___9__9_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B22 RID: 35618
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B23 RID: 35619
			private static readonly IntPtr NativeFieldInfoPtr___9__9_0;

			// Token: 0x04008B24 RID: 35620
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B25 RID: 35621
			private static readonly IntPtr NativeMethodInfoPtr__CanBuyRoom_b__9_0_Internal_Boolean_QuestEntry_0;
		}
	}
}
