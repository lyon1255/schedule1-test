using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200042C RID: 1068
	public class DialogueController : MonoBehaviour
	{
		// Token: 0x06005DEB RID: 24043 RVA: 0x001B0D08 File Offset: 0x001AEF08
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueController()
		{
			Il2CppClassPointerStore<DialogueController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController>.NativeClassPtr);
			DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GREETING_COOLDOWN");
			DialogueController.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "IntObj");
			DialogueController.NativeFieldInfoPtr_GenericDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GenericDialogue");
			DialogueController.NativeFieldInfoPtr_DialogueEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueEnabled");
			DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "UseDialogueBehaviour");
			DialogueController.NativeFieldInfoPtr_Choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "Choices");
			DialogueController.NativeFieldInfoPtr_GreetingOverrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverrides");
			DialogueController.NativeFieldInfoPtr_OverrideContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "OverrideContainer");
			DialogueController.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "npc");
			DialogueController.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "handler");
			DialogueController.NativeFieldInfoPtr_lastGreetingTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "lastGreetingTime");
			DialogueController.NativeFieldInfoPtr_shownChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "shownChoices");
			DialogueController.NativeFieldInfoPtr_dialogueQueued = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "dialogueQueued");
			DialogueController.NativeFieldInfoPtr_cachedGreeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "cachedGreeting");
			DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675251);
			DialogueController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675252);
			DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675253);
			DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675254);
			DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675255);
			DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675256);
			DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675257);
			DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675258);
			DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675259);
			DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675260);
			DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675261);
			DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675262);
			DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675263);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675264);
			DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675265);
			DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675266);
			DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675267);
			DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675268);
			DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675269);
			DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675270);
			DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675271);
			DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, 100675272);
		}

		// Token: 0x06005DEC RID: 24044 RVA: 0x001B1008 File Offset: 0x001AF208
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 196242, RefRangeEnd = 196247, XrefRangeStart = 196223, XrefRangeEnd = 196242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DED RID: 24045 RVA: 0x001B1044 File Offset: 0x001AF244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196247, XrefRangeEnd = 196248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DEE RID: 24046 RVA: 0x001B1078 File Offset: 0x001AF278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196248, XrefRangeEnd = 196262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DEF RID: 24047 RVA: 0x001B10AC File Offset: 0x001AF2AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196263, RefRangeEnd = 196265, XrefRangeStart = 196262, XrefRangeEnd = 196263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartGenericDialogue(bool allowExit = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref allowExit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DF0 RID: 24048 RVA: 0x001B10EC File Offset: 0x001AF2EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196277, RefRangeEnd = 196278, XrefRangeStart = 196265, XrefRangeEnd = 196277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DF1 RID: 24049 RVA: 0x001B1120 File Offset: 0x001AF320
		[CallerCount(0)]
		public unsafe void Unqueue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_Unqueue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DF2 RID: 24050 RVA: 0x001B1154 File Offset: 0x001AF354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196291, RefRangeEnd = 196292, XrefRangeStart = 196278, XrefRangeEnd = 196291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetActiveGreeting(out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &playVO;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DF3 RID: 24051 RVA: 0x001B11A8 File Offset: 0x001AF3A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 196334, RefRangeEnd = 196336, XrefRangeStart = 196292, XrefRangeEnd = 196334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<DialogueController.DialogueChoice> GetActiveChoices()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr3) : null;
		}

		// Token: 0x06005DF4 RID: 24052 RVA: 0x001B11E8 File Offset: 0x001AF3E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196336, XrefRangeEnd = 196351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetCustomGreeting(out string greeting, out bool playVO, out EVOLineType voLineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			ref IntPtr ptr2 = ref *ptr;
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &playVO;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &voLineType;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			greeting = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005DF5 RID: 24053 RVA: 0x001B1268 File Offset: 0x001AF468
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196351, XrefRangeEnd = 196357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddDialogueChoice(DialogueController.DialogueChoice data, int priority = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref priority;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DF6 RID: 24054 RVA: 0x001B12D0 File Offset: 0x001AF4D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196357, XrefRangeEnd = 196363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int AddGreetingOverride(DialogueController.GreetingOverride data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DF7 RID: 24055 RVA: 0x001B1328 File Offset: 0x001AF528
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 196376, RefRangeEnd = 196377, XrefRangeStart = 196363, XrefRangeEnd = 196376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanStartDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005DF8 RID: 24056 RVA: 0x001B1370 File Offset: 0x001AF570
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 196387, RefRangeEnd = 196393, XrefRangeStart = 196377, XrefRangeEnd = 196387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DF9 RID: 24057 RVA: 0x001B13D8 File Offset: 0x001AF5D8
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005DFA RID: 24058 RVA: 0x001B1440 File Offset: 0x001AF640
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 196422, RefRangeEnd = 196425, XrefRangeStart = 196393, XrefRangeEnd = 196422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005DFB RID: 24059 RVA: 0x001B14B4 File Offset: 0x001AF6B4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 196448, RefRangeEnd = 196453, XrefRangeStart = 196425, XrefRangeEnd = 196448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DFC RID: 24060 RVA: 0x001B1504 File Offset: 0x001AF704
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196453, XrefRangeEnd = 196474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005DFD RID: 24061 RVA: 0x001B1578 File Offset: 0x001AF778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOverrideContainer(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DFE RID: 24062 RVA: 0x001B15BC File Offset: 0x001AF7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196474, XrefRangeEnd = 196475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearOverrideContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005DFF RID: 24063 RVA: 0x001B15F0 File Offset: 0x001AF7F0
		[CallerCount(0)]
		public unsafe virtual bool DecideBranch(string branchLabel, out int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueController.NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005E00 RID: 24064 RVA: 0x001B1658 File Offset: 0x001AF858
		[CallerCount(0)]
		public unsafe void SetDialogueEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E01 RID: 24065 RVA: 0x001B1698 File Offset: 0x001AF898
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 196498, RefRangeEnd = 196506, XrefRangeStart = 196475, XrefRangeEnd = 196498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005E02 RID: 24066 RVA: 0x0002C492 File Offset: 0x0002A692
		public DialogueController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06005E03 RID: 24067 RVA: 0x001B16D4 File Offset: 0x001AF8D4
		// (set) Token: 0x06005E04 RID: 24068 RVA: 0x0002C49B File Offset: 0x0002A69B
		public unsafe static float GREETING_COOLDOWN
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueController.NativeFieldInfoPtr_GREETING_COOLDOWN, (void*)(&value));
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06005E05 RID: 24069 RVA: 0x001B16F0 File Offset: 0x001AF8F0
		// (set) Token: 0x06005E06 RID: 24070 RVA: 0x0002C4A9 File Offset: 0x0002A6A9
		public unsafe InteractableObject IntObj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06005E07 RID: 24071 RVA: 0x001B1720 File Offset: 0x001AF920
		// (set) Token: 0x06005E08 RID: 24072 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
		public unsafe DialogueContainer GenericDialogue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GenericDialogue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06005E09 RID: 24073 RVA: 0x001B1750 File Offset: 0x001AF950
		// (set) Token: 0x06005E0A RID: 24074 RVA: 0x0002C4E7 File Offset: 0x0002A6E7
		public unsafe bool DialogueEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_DialogueEnabled)) = value;
			}
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06005E0B RID: 24075 RVA: 0x001B1778 File Offset: 0x001AF978
		// (set) Token: 0x06005E0C RID: 24076 RVA: 0x0002C502 File Offset: 0x0002A702
		public unsafe bool UseDialogueBehaviour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_UseDialogueBehaviour)) = value;
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06005E0D RID: 24077 RVA: 0x001B17A0 File Offset: 0x001AF9A0
		// (set) Token: 0x06005E0E RID: 24078 RVA: 0x0002C51D File Offset: 0x0002A71D
		public unsafe List<DialogueController.DialogueChoice> Choices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_Choices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005E0F RID: 24079 RVA: 0x001B17D0 File Offset: 0x001AF9D0
		// (set) Token: 0x06005E10 RID: 24080 RVA: 0x0002C53C File Offset: 0x0002A73C
		public unsafe List<DialogueController.GreetingOverride> GreetingOverrides
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.GreetingOverride>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_GreetingOverrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005E11 RID: 24081 RVA: 0x001B1800 File Offset: 0x001AFA00
		// (set) Token: 0x06005E12 RID: 24082 RVA: 0x0002C55B File Offset: 0x0002A75B
		public unsafe DialogueContainer OverrideContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_OverrideContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4C RID: 7244
		// (get) Token: 0x06005E13 RID: 24083 RVA: 0x001B1830 File Offset: 0x001AFA30
		// (set) Token: 0x06005E14 RID: 24084 RVA: 0x0002C57A File Offset: 0x0002A77A
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x06005E15 RID: 24085 RVA: 0x001B1860 File Offset: 0x001AFA60
		// (set) Token: 0x06005E16 RID: 24086 RVA: 0x0002C599 File Offset: 0x0002A799
		public unsafe DialogueHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06005E17 RID: 24087 RVA: 0x001B1890 File Offset: 0x001AFA90
		// (set) Token: 0x06005E18 RID: 24088 RVA: 0x0002C5B8 File Offset: 0x0002A7B8
		public unsafe float lastGreetingTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_lastGreetingTime)) = value;
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06005E19 RID: 24089 RVA: 0x001B18B8 File Offset: 0x001AFAB8
		// (set) Token: 0x06005E1A RID: 24090 RVA: 0x0002C5D3 File Offset: 0x0002A7D3
		public unsafe List<DialogueController.DialogueChoice> shownChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueController.DialogueChoice>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_shownChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06005E1B RID: 24091 RVA: 0x001B18E8 File Offset: 0x001AFAE8
		// (set) Token: 0x06005E1C RID: 24092 RVA: 0x0002C5F2 File Offset: 0x0002A7F2
		public unsafe bool dialogueQueued
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_dialogueQueued)) = value;
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06005E1D RID: 24093 RVA: 0x001B1910 File Offset: 0x001AFB10
		// (set) Token: 0x06005E1E RID: 24094 RVA: 0x0002C60D File Offset: 0x0002A80D
		public unsafe string cachedGreeting
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.NativeFieldInfoPtr_cachedGreeting), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04004040 RID: 16448
		private static readonly IntPtr NativeFieldInfoPtr_GREETING_COOLDOWN;

		// Token: 0x04004041 RID: 16449
		private static readonly IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004042 RID: 16450
		private static readonly IntPtr NativeFieldInfoPtr_GenericDialogue;

		// Token: 0x04004043 RID: 16451
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEnabled;

		// Token: 0x04004044 RID: 16452
		private static readonly IntPtr NativeFieldInfoPtr_UseDialogueBehaviour;

		// Token: 0x04004045 RID: 16453
		private static readonly IntPtr NativeFieldInfoPtr_Choices;

		// Token: 0x04004046 RID: 16454
		private static readonly IntPtr NativeFieldInfoPtr_GreetingOverrides;

		// Token: 0x04004047 RID: 16455
		private static readonly IntPtr NativeFieldInfoPtr_OverrideContainer;

		// Token: 0x04004048 RID: 16456
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x04004049 RID: 16457
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x0400404A RID: 16458
		private static readonly IntPtr NativeFieldInfoPtr_lastGreetingTime;

		// Token: 0x0400404B RID: 16459
		private static readonly IntPtr NativeFieldInfoPtr_shownChoices;

		// Token: 0x0400404C RID: 16460
		private static readonly IntPtr NativeFieldInfoPtr_dialogueQueued;

		// Token: 0x0400404D RID: 16461
		private static readonly IntPtr NativeFieldInfoPtr_cachedGreeting;

		// Token: 0x0400404E RID: 16462
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x0400404F RID: 16463
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04004050 RID: 16464
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x04004051 RID: 16465
		private static readonly IntPtr NativeMethodInfoPtr_StartGenericDialogue_Public_Void_Boolean_0;

		// Token: 0x04004052 RID: 16466
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x04004053 RID: 16467
		private static readonly IntPtr NativeMethodInfoPtr_Unqueue_Private_Void_0;

		// Token: 0x04004054 RID: 16468
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveGreeting_Private_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04004055 RID: 16469
		private static readonly IntPtr NativeMethodInfoPtr_GetActiveChoices_Private_List_1_DialogueChoice_0;

		// Token: 0x04004056 RID: 16470
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomGreeting_Protected_Virtual_New_Boolean_byref_String_byref_Boolean_byref_EVOLineType_0;

		// Token: 0x04004057 RID: 16471
		private static readonly IntPtr NativeMethodInfoPtr_AddDialogueChoice_Public_Virtual_New_Int32_DialogueChoice_Int32_0;

		// Token: 0x04004058 RID: 16472
		private static readonly IntPtr NativeMethodInfoPtr_AddGreetingOverride_Public_Virtual_New_Int32_GreetingOverride_0;

		// Token: 0x04004059 RID: 16473
		private static readonly IntPtr NativeMethodInfoPtr_CanStartDialogue_Public_Virtual_New_Boolean_0;

		// Token: 0x0400405A RID: 16474
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Public_Virtual_New_String_String_String_0;

		// Token: 0x0400405B RID: 16475
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Public_Virtual_New_String_String_String_0;

		// Token: 0x0400405C RID: 16476
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Public_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x0400405D RID: 16477
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Public_Virtual_New_Void_String_0;

		// Token: 0x0400405E RID: 16478
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x0400405F RID: 16479
		private static readonly IntPtr NativeMethodInfoPtr_SetOverrideContainer_Public_Void_DialogueContainer_0;

		// Token: 0x04004060 RID: 16480
		private static readonly IntPtr NativeMethodInfoPtr_ClearOverrideContainer_Public_Void_0;

		// Token: 0x04004061 RID: 16481
		private static readonly IntPtr NativeMethodInfoPtr_DecideBranch_Public_Virtual_New_Boolean_String_byref_Int32_0;

		// Token: 0x04004062 RID: 16482
		private static readonly IntPtr NativeMethodInfoPtr_SetDialogueEnabled_Public_Void_Boolean_0;

		// Token: 0x04004063 RID: 16483
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009F2 RID: 2546
		[Serializable]
		public class DialogueChoice : Il2CppSystem.Object
		{
			// Token: 0x0600CDC9 RID: 52681 RVA: 0x00318A84 File Offset: 0x00316C84
			// Note: this type is marked as 'beforefieldinit'.
			static DialogueChoice()
			{
				Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "DialogueChoice");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr);
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Enabled");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ChoiceText");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Conversation");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "onChoosen");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "shouldShowCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "isValidCheck");
				DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "Priority");
				DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675274);
				DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675275);
				DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, 100675276);
			}

			// Token: 0x0600CDCA RID: 52682 RVA: 0x00318B78 File Offset: 0x00316D78
			[CallerCount(0)]
			public unsafe bool ShouldShow()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_ShouldShow_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDCB RID: 52683 RVA: 0x00318BB4 File Offset: 0x00316DB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196196, XrefRangeEnd = 196199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool IsValid(out string invalidReason)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = 0;
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600CDCC RID: 52684 RVA: 0x00318C0C File Offset: 0x00316E0C
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 196205, RefRangeEnd = 196221, XrefRangeStart = 196199, XrefRangeEnd = 196205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DialogueChoice() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDCD RID: 52685 RVA: 0x00064121 File Offset: 0x00062321
			public DialogueChoice(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700400E RID: 16398
			// (get) Token: 0x0600CDCE RID: 52686 RVA: 0x00318C48 File Offset: 0x00316E48
			// (set) Token: 0x0600CDCF RID: 52687 RVA: 0x0006412A File Offset: 0x0006232A
			public unsafe bool Enabled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Enabled)) = value;
				}
			}

			// Token: 0x1700400F RID: 16399
			// (get) Token: 0x0600CDD0 RID: 52688 RVA: 0x00318C70 File Offset: 0x00316E70
			// (set) Token: 0x0600CDD1 RID: 52689 RVA: 0x00064145 File Offset: 0x00062345
			public unsafe string ChoiceText
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_ChoiceText), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004010 RID: 16400
			// (get) Token: 0x0600CDD2 RID: 52690 RVA: 0x00318C98 File Offset: 0x00316E98
			// (set) Token: 0x0600CDD3 RID: 52691 RVA: 0x00064164 File Offset: 0x00062364
			public unsafe DialogueContainer Conversation
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Conversation), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004011 RID: 16401
			// (get) Token: 0x0600CDD4 RID: 52692 RVA: 0x00318CC8 File Offset: 0x00316EC8
			// (set) Token: 0x0600CDD5 RID: 52693 RVA: 0x00064183 File Offset: 0x00062383
			public unsafe UnityEvent onChoosen
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_onChoosen), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004012 RID: 16402
			// (get) Token: 0x0600CDD6 RID: 52694 RVA: 0x00318CF8 File Offset: 0x00316EF8
			// (set) Token: 0x0600CDD7 RID: 52695 RVA: 0x000641A2 File Offset: 0x000623A2
			public unsafe DialogueController.DialogueChoice.ShouldShowCheck shouldShowCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.ShouldShowCheck>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_shouldShowCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004013 RID: 16403
			// (get) Token: 0x0600CDD8 RID: 52696 RVA: 0x00318D28 File Offset: 0x00316F28
			// (set) Token: 0x0600CDD9 RID: 52697 RVA: 0x000641C1 File Offset: 0x000623C1
			public unsafe DialogueController.DialogueChoice.IsChoiceValid isValidCheck
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.DialogueChoice.IsChoiceValid>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_isValidCheck), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004014 RID: 16404
			// (get) Token: 0x0600CDDA RID: 52698 RVA: 0x00318D58 File Offset: 0x00316F58
			// (set) Token: 0x0600CDDB RID: 52699 RVA: 0x000641E0 File Offset: 0x000623E0
			public unsafe int Priority
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.DialogueChoice.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x04008B03 RID: 35587
			private static readonly IntPtr NativeFieldInfoPtr_Enabled;

			// Token: 0x04008B04 RID: 35588
			private static readonly IntPtr NativeFieldInfoPtr_ChoiceText;

			// Token: 0x04008B05 RID: 35589
			private static readonly IntPtr NativeFieldInfoPtr_Conversation;

			// Token: 0x04008B06 RID: 35590
			private static readonly IntPtr NativeFieldInfoPtr_onChoosen;

			// Token: 0x04008B07 RID: 35591
			private static readonly IntPtr NativeFieldInfoPtr_shouldShowCheck;

			// Token: 0x04008B08 RID: 35592
			private static readonly IntPtr NativeFieldInfoPtr_isValidCheck;

			// Token: 0x04008B09 RID: 35593
			private static readonly IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04008B0A RID: 35594
			private static readonly IntPtr NativeMethodInfoPtr_ShouldShow_Public_Boolean_0;

			// Token: 0x04008B0B RID: 35595
			private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_byref_String_0;

			// Token: 0x04008B0C RID: 35596
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x02000C52 RID: 3154
			public sealed class ShouldShowCheck : MulticastDelegate
			{
				// Token: 0x0600E333 RID: 58163 RVA: 0x00355454 File Offset: 0x00353654
				// Note: this type is marked as 'beforefieldinit'.
				static ShouldShowCheck()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "ShouldShowCheck");
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675277);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675278);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675279);
					DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr, 100675280);
				}

				// Token: 0x0600E334 RID: 58164 RVA: 0x003554C8 File Offset: 0x003536C8
				[CallerCount(16)]
				[CachedScanResults(RefRangeStart = 196151, RefRangeEnd = 196167, XrefRangeStart = 196148, XrefRangeEnd = 196151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ShouldShowCheck(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.ShouldShowCheck>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E335 RID: 58165 RVA: 0x00355524 File Offset: 0x00353724
				[CallerCount(0)]
				public unsafe bool Invoke(bool enabled)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E336 RID: 58166 RVA: 0x00355570 File Offset: 0x00353770
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196167, XrefRangeEnd = 196171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(bool enabled, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref enabled;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
				}

				// Token: 0x0600E337 RID: 58167 RVA: 0x003555E0 File Offset: 0x003537E0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.ShouldShowCheck.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x0600E338 RID: 58168 RVA: 0x0006EBF4 File Offset: 0x0006CDF4
				public ShouldShowCheck(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x0600E339 RID: 58169 RVA: 0x0006EBFD File Offset: 0x0006CDFD
				public static implicit operator DialogueController.DialogueChoice.ShouldShowCheck(Func<bool, bool> A_0)
				{
					return DelegateSupport.ConvertDelegate<DialogueController.DialogueChoice.ShouldShowCheck>(A_0);
				}

				// Token: 0x0600E33A RID: 58170 RVA: 0x0006EC05 File Offset: 0x0006CE05
				public static DialogueController.DialogueChoice.ShouldShowCheck operator +(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					return Delegate.Combine(A_0, A_1).Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
				}

				// Token: 0x0600E33B RID: 58171 RVA: 0x0006EC13 File Offset: 0x0006CE13
				public static DialogueController.DialogueChoice.ShouldShowCheck operator -(DialogueController.DialogueChoice.ShouldShowCheck A_0, DialogueController.DialogueChoice.ShouldShowCheck A_1)
				{
					Delegate result;
					Delegate @delegate = result = Delegate.Remove(A_0, A_1);
					if (@delegate != null)
					{
						result = @delegate.Cast<DialogueController.DialogueChoice.ShouldShowCheck>();
					}
					return result;
				}

				// Token: 0x0400980D RID: 38925
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x0400980E RID: 38926
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_Boolean_0;

				// Token: 0x0400980F RID: 38927
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Boolean_AsyncCallback_Object_0;

				// Token: 0x04009810 RID: 38928
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_IAsyncResult_0;
			}

			// Token: 0x02000C53 RID: 3155
			public sealed class IsChoiceValid : MulticastDelegate
			{
				// Token: 0x0600E33C RID: 58172 RVA: 0x00355630 File Offset: 0x00353830
				// Note: this type is marked as 'beforefieldinit'.
				static IsChoiceValid()
				{
					Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController.DialogueChoice>.NativeClassPtr, "IsChoiceValid");
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675281);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675282);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675283);
					DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr, 100675284);
				}

				// Token: 0x0600E33D RID: 58173 RVA: 0x003556A4 File Offset: 0x003538A4
				[CallerCount(20)]
				[CachedScanResults(RefRangeStart = 196175, RefRangeEnd = 196195, XrefRangeStart = 196171, XrefRangeEnd = 196175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IsChoiceValid(Il2CppSystem.Object @object, IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.DialogueChoice.IsChoiceValid>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E33E RID: 58174 RVA: 0x00355700 File Offset: 0x00353900
				[CallerCount(0)]
				public unsafe bool Invoke(out string invalidReason)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600E33F RID: 58175 RVA: 0x00355758 File Offset: 0x00353958
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196195, XrefRangeEnd = 196196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe IAsyncResult BeginInvoke(out string invalidReason, AsyncCallback callback, Il2CppSystem.Object @object)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
					ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					IntPtr intPtr4 = intPtr2;
					return (intPtr4 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr4) : null;
				}

				// Token: 0x0600E340 RID: 58176 RVA: 0x003557D8 File Offset: 0x003539D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool EndInvoke(out string invalidReason, IAsyncResult result)
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr = 0;
					ptr2 = &intPtr;
					ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(result);
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueController.DialogueChoice.IsChoiceValid.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
					invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
					return *IL2CPP.il2cpp_object_unbox(intPtr2);
				}

				// Token: 0x0600E341 RID: 58177 RVA: 0x0006EC24 File Offset: 0x0006CE24
				public IsChoiceValid(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x04009811 RID: 38929
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

				// Token: 0x04009812 RID: 38930
				private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_byref_String_0;

				// Token: 0x04009813 RID: 38931
				private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_byref_String_AsyncCallback_Object_0;

				// Token: 0x04009814 RID: 38932
				private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Boolean_byref_String_IAsyncResult_0;
			}
		}

		// Token: 0x020009F3 RID: 2547
		[Serializable]
		public class GreetingOverride : Il2CppSystem.Object
		{
			// Token: 0x0600CDDC RID: 52700 RVA: 0x00318D80 File Offset: 0x00316F80
			// Note: this type is marked as 'beforefieldinit'.
			static GreetingOverride()
			{
				Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "GreetingOverride");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr);
				DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "Greeting");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "ShouldShow");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "PlayVO");
				DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, "VOType");
				DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr, 100675285);
			}

			// Token: 0x0600CDDD RID: 52701 RVA: 0x00318E10 File Offset: 0x00317010
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GreetingOverride() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.GreetingOverride>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.GreetingOverride.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDDE RID: 52702 RVA: 0x000641FB File Offset: 0x000623FB
			public GreetingOverride(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004015 RID: 16405
			// (get) Token: 0x0600CDDF RID: 52703 RVA: 0x00318E4C File Offset: 0x0031704C
			// (set) Token: 0x0600CDE0 RID: 52704 RVA: 0x00064204 File Offset: 0x00062404
			public unsafe string Greeting
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_Greeting), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004016 RID: 16406
			// (get) Token: 0x0600CDE1 RID: 52705 RVA: 0x00318E74 File Offset: 0x00317074
			// (set) Token: 0x0600CDE2 RID: 52706 RVA: 0x00064223 File Offset: 0x00062423
			public unsafe bool ShouldShow
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_ShouldShow)) = value;
				}
			}

			// Token: 0x17004017 RID: 16407
			// (get) Token: 0x0600CDE3 RID: 52707 RVA: 0x00318E9C File Offset: 0x0031709C
			// (set) Token: 0x0600CDE4 RID: 52708 RVA: 0x0006423E File Offset: 0x0006243E
			public unsafe bool PlayVO
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_PlayVO)) = value;
				}
			}

			// Token: 0x17004018 RID: 16408
			// (get) Token: 0x0600CDE5 RID: 52709 RVA: 0x00318EC4 File Offset: 0x003170C4
			// (set) Token: 0x0600CDE6 RID: 52710 RVA: 0x00064259 File Offset: 0x00062459
			public unsafe EVOLineType VOType
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueController.GreetingOverride.NativeFieldInfoPtr_VOType)) = value;
				}
			}

			// Token: 0x04008B0D RID: 35597
			private static readonly IntPtr NativeFieldInfoPtr_Greeting;

			// Token: 0x04008B0E RID: 35598
			private static readonly IntPtr NativeFieldInfoPtr_ShouldShow;

			// Token: 0x04008B0F RID: 35599
			private static readonly IntPtr NativeFieldInfoPtr_PlayVO;

			// Token: 0x04008B10 RID: 35600
			private static readonly IntPtr NativeFieldInfoPtr_VOType;

			// Token: 0x04008B11 RID: 35601
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009F4 RID: 2548
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueController+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600CDE7 RID: 52711 RVA: 0x00318EEC File Offset: 0x003170EC
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueController>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr);
				DialogueController.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9");
				DialogueController.__c.NativeFieldInfoPtr___9__23_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, "<>9__23_0");
				DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675287);
				DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr, 100675288);
			}

			// Token: 0x0600CDE8 RID: 52712 RVA: 0x00318F68 File Offset: 0x00317168
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueController.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CDE9 RID: 52713 RVA: 0x00318FA4 File Offset: 0x003171A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 196221, XrefRangeEnd = 196223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _GetActiveChoices_b__23_0(DialogueController.DialogueChoice a, DialogueController.DialogueChoice b)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueController.__c.NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CDEA RID: 52714 RVA: 0x00064274 File Offset: 0x00062474
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004019 RID: 16409
			// (get) Token: 0x0600CDEB RID: 52715 RVA: 0x00319004 File Offset: 0x00317204
			// (set) Token: 0x0600CDEC RID: 52716 RVA: 0x0006427D File Offset: 0x0006247D
			public unsafe static DialogueController.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueController.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700401A RID: 16410
			// (get) Token: 0x0600CDED RID: 52717 RVA: 0x0031902C File Offset: 0x0031722C
			// (set) Token: 0x0600CDEE RID: 52718 RVA: 0x0006428F File Offset: 0x0006248F
			public unsafe static Comparison<DialogueController.DialogueChoice> __9__23_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Comparison<DialogueController.DialogueChoice>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DialogueController.__c.NativeFieldInfoPtr___9__23_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008B12 RID: 35602
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008B13 RID: 35603
			private static readonly IntPtr NativeFieldInfoPtr___9__23_0;

			// Token: 0x04008B14 RID: 35604
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B15 RID: 35605
			private static readonly IntPtr NativeMethodInfoPtr__GetActiveChoices_b__23_0_Internal_Int32_DialogueChoice_DialogueChoice_0;
		}
	}
}
