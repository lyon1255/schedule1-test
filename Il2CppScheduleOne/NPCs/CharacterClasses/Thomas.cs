using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs.Schedules;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Handover;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs.CharacterClasses
{
	// Token: 0x02000335 RID: 821
	public class Thomas : NPC
	{
		// Token: 0x06003C86 RID: 15494 RVA: 0x00135364 File Offset: 0x00133564
		// Note: this type is marked as 'beforefieldinit'.
		static Thomas()
		{
			Il2CppClassPointerStore<Thomas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.CharacterClasses", "Thomas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Thomas>.NativeClassPtr);
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_QUANTITY");
			Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "CARTEL_CONTRACT_PAYMENT");
			Thomas.NativeFieldInfoPtr_FirstMeetingEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "FirstMeetingEvent");
			Thomas.NativeFieldInfoPtr_HandoverEvent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "HandoverEvent");
			Thomas.NativeFieldInfoPtr_onCartelContractReceived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "onCartelContractReceived");
			Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<MeetingReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "<HandoverReminderSent>k__BackingField");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Thomas>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.ThomasAssembly-CSharp.dll_Excuted");
			Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670354);
			Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670355);
			Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670356);
			Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670357);
			Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670358);
			Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670359);
			Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670360);
			Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670361);
			Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670362);
			Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670363);
			Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670364);
			Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670365);
			Thomas.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670366);
			Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670367);
			Thomas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670368);
			Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670369);
			Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670370);
			Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670371);
			Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Thomas>.NativeClassPtr, 100670372);
		}

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x001355C4 File Offset: 0x001337C4
		// (set) Token: 0x06003C88 RID: 15496 RVA: 0x00135600 File Offset: 0x00133800
		public unsafe bool MeetingReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00135640 File Offset: 0x00133840
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x0013567C File Offset: 0x0013387C
		public unsafe bool HandoverReminderSent
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003C8B RID: 15499 RVA: 0x001356BC File Offset: 0x001338BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142920, XrefRangeEnd = 142931, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8C RID: 15500 RVA: 0x001356F8 File Offset: 0x001338F8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142934, RefRangeEnd = 142935, XrefRangeStart = 142931, XrefRangeEnd = 142934, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFirstMeetingEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x00135738 File Offset: 0x00133938
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 142938, RefRangeEnd = 142940, XrefRangeStart = 142935, XrefRangeEnd = 142938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandoverEventActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x00135778 File Offset: 0x00133978
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142952, RefRangeEnd = 142953, XrefRangeStart = 142940, XrefRangeEnd = 142952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMeetingReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001357AC File Offset: 0x001339AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142970, RefRangeEnd = 142971, XrefRangeStart = 142953, XrefRangeEnd = 142970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendHandoverReminder()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x001357E0 File Offset: 0x001339E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 142975, RefRangeEnd = 142976, XrefRangeStart = 142971, XrefRangeEnd = 142975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitialMeetingComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C91 RID: 15505 RVA: 0x00135814 File Offset: 0x00133A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 142976, XrefRangeEnd = 143039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DialogueChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x00135858 File Offset: 0x00133A58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143039, XrefRangeEnd = 143052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ProcessItemHandover(HandoverScreen.EHandoverOutcome outcome, List<ItemInstance> items, float price)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(items);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x001358B8 File Offset: 0x00133AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143052, XrefRangeEnd = 143057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x001358FC File Offset: 0x00133AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143057, XrefRangeEnd = 143066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(NPCData data, string containerPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(containerPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x0013595C File Offset: 0x00133B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Thomas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Thomas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Thomas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x00135998 File Offset: 0x00133B98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143066, XrefRangeEnd = 143067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x001359D4 File Offset: 0x00133BD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 143067, XrefRangeEnd = 143068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x00135A10 File Offset: 0x00133C10
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x00135A4C File Offset: 0x00133C4C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 141969, RefRangeEnd = 141972, XrefRangeStart = 141969, XrefRangeEnd = 141972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Thomas.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0001EAEC File Offset: 0x0001CCEC
		public Thomas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00135A88 File Offset: 0x00133C88
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x0001EAF5 File Offset: 0x0001CCF5
		public unsafe static int CARTEL_CONTRACT_QUANTITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY, (void*)(&value));
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00135AA4 File Offset: 0x00133CA4
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x0001EB03 File Offset: 0x0001CD03
		public unsafe static float CARTEL_CONTRACT_PAYMENT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Thomas.NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT, (void*)(&value));
			}
		}

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00135AC0 File Offset: 0x00133CC0
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x0001EB11 File Offset: 0x0001CD11
		public unsafe NPCEvent_LocationDialogue FirstMeetingEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_FirstMeetingEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x00135AF0 File Offset: 0x00133CF0
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x0001EB30 File Offset: 0x0001CD30
		public unsafe NPCEvent_LocationDialogue HandoverEvent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCEvent_LocationDialogue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_HandoverEvent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00135B20 File Offset: 0x00133D20
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x0001EB4F File Offset: 0x0001CD4F
		public unsafe UnityEvent onCartelContractReceived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_onCartelContractReceived), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00135B50 File Offset: 0x00133D50
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x0001EB6E File Offset: 0x0001CD6E
		public unsafe bool _MeetingReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__MeetingReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00135B78 File Offset: 0x00133D78
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x0001EB89 File Offset: 0x0001CD89
		public unsafe bool _HandoverReminderSent_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr__HandoverReminderSent_k__BackingField)) = value;
			}
		}

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00135BA0 File Offset: 0x00133DA0
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x0001EBA4 File Offset: 0x0001CDA4
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00135BC8 File Offset: 0x00133DC8
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x0001EBBF File Offset: 0x0001CDBF
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Thomas.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040027EB RID: 10219
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_QUANTITY;

		// Token: 0x040027EC RID: 10220
		private static readonly IntPtr NativeFieldInfoPtr_CARTEL_CONTRACT_PAYMENT;

		// Token: 0x040027ED RID: 10221
		private static readonly IntPtr NativeFieldInfoPtr_FirstMeetingEvent;

		// Token: 0x040027EE RID: 10222
		private static readonly IntPtr NativeFieldInfoPtr_HandoverEvent;

		// Token: 0x040027EF RID: 10223
		private static readonly IntPtr NativeFieldInfoPtr_onCartelContractReceived;

		// Token: 0x040027F0 RID: 10224
		private static readonly IntPtr NativeFieldInfoPtr__MeetingReminderSent_k__BackingField;

		// Token: 0x040027F1 RID: 10225
		private static readonly IntPtr NativeFieldInfoPtr__HandoverReminderSent_k__BackingField;

		// Token: 0x040027F2 RID: 10226
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040027F3 RID: 10227
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040027F4 RID: 10228
		private static readonly IntPtr NativeMethodInfoPtr_get_MeetingReminderSent_Public_get_Boolean_0;

		// Token: 0x040027F5 RID: 10229
		private static readonly IntPtr NativeMethodInfoPtr_set_MeetingReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x040027F6 RID: 10230
		private static readonly IntPtr NativeMethodInfoPtr_get_HandoverReminderSent_Public_get_Boolean_0;

		// Token: 0x040027F7 RID: 10231
		private static readonly IntPtr NativeMethodInfoPtr_set_HandoverReminderSent_Protected_set_Void_Boolean_0;

		// Token: 0x040027F8 RID: 10232
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040027F9 RID: 10233
		private static readonly IntPtr NativeMethodInfoPtr_SetFirstMeetingEventActive_Public_Void_Boolean_0;

		// Token: 0x040027FA RID: 10234
		private static readonly IntPtr NativeMethodInfoPtr_SetHandoverEventActive_Public_Void_Boolean_0;

		// Token: 0x040027FB RID: 10235
		private static readonly IntPtr NativeMethodInfoPtr_SendMeetingReminder_Public_Void_0;

		// Token: 0x040027FC RID: 10236
		private static readonly IntPtr NativeMethodInfoPtr_SendHandoverReminder_Public_Void_0;

		// Token: 0x040027FD RID: 10237
		private static readonly IntPtr NativeMethodInfoPtr_InitialMeetingComplete_Public_Void_0;

		// Token: 0x040027FE RID: 10238
		private static readonly IntPtr NativeMethodInfoPtr_DialogueChoiceCallback_Private_Void_String_0;

		// Token: 0x040027FF RID: 10239
		private static readonly IntPtr NativeMethodInfoPtr_ProcessItemHandover_Private_Void_EHandoverOutcome_List_1_ItemInstance_Single_0;

		// Token: 0x04002800 RID: 10240
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002801 RID: 10241
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_NPCData_String_0;

		// Token: 0x04002802 RID: 10242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002803 RID: 10243
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002804 RID: 10244
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002805 RID: 10245
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002806 RID: 10246
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
