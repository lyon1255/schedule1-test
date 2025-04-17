using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.UI;
using Il2CppScheduleOne.VoiceOver;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dialogue
{
	// Token: 0x0200043B RID: 1083
	public class DialogueHandler : MonoBehaviour
	{
		// Token: 0x06005EC0 RID: 24256 RVA: 0x001B3CD4 File Offset: 0x001B1ED4
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueHandler()
		{
			Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dialogue", "DialogueHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr);
			DialogueHandler.NativeFieldInfoPtr_TimePerChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TimePerChar");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMinDuration");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceDialogueMaxDuration");
			DialogueHandler.NativeFieldInfoPtr_activeDialogue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogue");
			DialogueHandler.NativeFieldInfoPtr_activeDialogueNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "activeDialogueNode");
			DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_Database = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "Database");
			DialogueHandler.NativeFieldInfoPtr_LookPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "LookPosition");
			DialogueHandler.NativeFieldInfoPtr_WorldspaceRend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "WorldspaceRend");
			DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<NPC>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_VOEmitter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "VOEmitter");
			DialogueHandler.NativeFieldInfoPtr_CurrentChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "CurrentChoices");
			DialogueHandler.NativeFieldInfoPtr_DialogueEvents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "DialogueEvents");
			DialogueHandler.NativeFieldInfoPtr_onConversationStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onConversationStart");
			DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueNodeDisplayed");
			DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "onDialogueChoiceChosen");
			DialogueHandler.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "overrideText");
			DialogueHandler.NativeFieldInfoPtr_dialogueContainers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "dialogueContainers");
			DialogueHandler.NativeFieldInfoPtr_TempLinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "TempLinks");
			DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "skipNextDialogueBehaviourEnd");
			DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<runtimeModules>k__BackingField");
			DialogueHandler.NativeFieldInfoPtr_passChecked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "passChecked");
			DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675366);
			DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675367);
			DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675368);
			DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675369);
			DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675370);
			DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675371);
			DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675372);
			DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675373);
			DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675374);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675375);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675376);
			DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675377);
			DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675378);
			DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675379);
			DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675380);
			DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675381);
			DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675382);
			DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675383);
			DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675384);
			DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675385);
			DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675386);
			DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675387);
			DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675388);
			DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675389);
			DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675390);
			DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675391);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675392);
			DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675393);
			DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675394);
			DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675395);
			DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675396);
			DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675397);
			DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675398);
			DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675399);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675400);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675401);
			DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675402);
			DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675403);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675404);
			DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675405);
			DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, 100675406);
		}

		// Token: 0x17001C8E RID: 7310
		// (get) Token: 0x06005EC1 RID: 24257 RVA: 0x001B41F0 File Offset: 0x001B23F0
		// (set) Token: 0x06005EC2 RID: 24258 RVA: 0x001B422C File Offset: 0x001B242C
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 35362, RefRangeEnd = 35364, XrefRangeStart = 35362, XrefRangeEnd = 35364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C8F RID: 7311
		// (get) Token: 0x06005EC3 RID: 24259 RVA: 0x001B426C File Offset: 0x001B246C
		// (set) Token: 0x06005EC4 RID: 24260 RVA: 0x001B42AC File Offset: 0x001B24AC
		public unsafe NPC NPC
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35354, RefRangeEnd = 35355, XrefRangeStart = 35354, XrefRangeEnd = 35355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_NPC_Public_get_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001C90 RID: 7312
		// (get) Token: 0x06005EC5 RID: 24261 RVA: 0x001B42F0 File Offset: 0x001B24F0
		public unsafe DialogueCanvas canvas
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 197499, RefRangeEnd = 197501, XrefRangeStart = 197496, XrefRangeEnd = 197499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr3) : null;
			}
		}

		// Token: 0x17001C91 RID: 7313
		// (get) Token: 0x06005EC6 RID: 24262 RVA: 0x001B4330 File Offset: 0x001B2530
		// (set) Token: 0x06005EC7 RID: 24263 RVA: 0x001B4370 File Offset: 0x001B2570
		public unsafe List<DialogueModule> runtimeModules
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06005EC8 RID: 24264 RVA: 0x001B43B4 File Offset: 0x001B25B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197525, RefRangeEnd = 197527, XrefRangeStart = 197501, XrefRangeEnd = 197525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EC9 RID: 24265 RVA: 0x001B43F0 File Offset: 0x001B25F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197527, XrefRangeEnd = 197562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECA RID: 24266 RVA: 0x001B442C File Offset: 0x001B262C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197565, RefRangeEnd = 197567, XrefRangeStart = 197562, XrefRangeEnd = 197565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer container)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(container);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECB RID: 24267 RVA: 0x001B4470 File Offset: 0x001B2670
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 197597, RefRangeEnd = 197601, XrefRangeStart = 197567, XrefRangeEnd = 197597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(DialogueContainer dialogueContainer, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogueContainer);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECC RID: 24268 RVA: 0x001B44D4 File Offset: 0x001B26D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197623, RefRangeEnd = 197624, XrefRangeStart = 197601, XrefRangeEnd = 197623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InitializeDialogue(string dialogueContainerName, bool enableDialogueBehaviour = true, string entryNodeLabel = "ENTRY")
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueContainerName);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableDialogueBehaviour;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(entryNodeLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECD RID: 24269 RVA: 0x001B4538 File Offset: 0x001B2738
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197624, XrefRangeEnd = 197629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanBeginConversation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ECE RID: 24270 RVA: 0x001B4580 File Offset: 0x001B2780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197629, XrefRangeEnd = 197633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideShownDialogue(string _overrideText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_overrideText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ECF RID: 24271 RVA: 0x001B45C4 File Offset: 0x001B27C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197633, XrefRangeEnd = 197641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_StopOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED0 RID: 24272 RVA: 0x001B45F8 File Offset: 0x001B27F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197641, XrefRangeEnd = 197665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED1 RID: 24273 RVA: 0x001B4634 File Offset: 0x001B2834
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197665, RefRangeEnd = 197668, XrefRangeStart = 197665, XrefRangeEnd = 197665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipNextDialogueBehaviourEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED2 RID: 24274 RVA: 0x001B4668 File Offset: 0x001B2868
		[CallerCount(0)]
		public unsafe virtual DialogueNodeData FinalizeDialogueNode(DialogueNodeData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr3) : null;
		}

		// Token: 0x06005ED3 RID: 24275 RVA: 0x001B46C4 File Offset: 0x001B28C4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 197723, RefRangeEnd = 197729, XrefRangeStart = 197668, XrefRangeEnd = 197723, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowNode(DialogueNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED4 RID: 24276 RVA: 0x001B4708 File Offset: 0x001B2908
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197750, RefRangeEnd = 197752, XrefRangeStart = 197729, XrefRangeEnd = 197750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EvaluateBranch(BranchNodeData node)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED5 RID: 24277 RVA: 0x001B474C File Offset: 0x001B294C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197761, RefRangeEnd = 197762, XrefRangeStart = 197752, XrefRangeEnd = 197761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED6 RID: 24278 RVA: 0x001B478C File Offset: 0x001B298C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 197765, RefRangeEnd = 197766, XrefRangeStart = 197762, XrefRangeEnd = 197765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ContinueSubmitted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005ED7 RID: 24279 RVA: 0x001B47C0 File Offset: 0x001B29C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197766, XrefRangeEnd = 197773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CheckChoice(string choiceLabel, out string invalidReason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			invalidReason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06005ED8 RID: 24280 RVA: 0x001B4834 File Offset: 0x001B2A34
		[CallerCount(20)]
		[CachedScanResults(RefRangeStart = 30137, RefRangeEnd = 30157, XrefRangeStart = 30137, XrefRangeEnd = 30157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldChoiceBeShown(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005ED9 RID: 24281 RVA: 0x001B488C File Offset: 0x001B2A8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197773, XrefRangeEnd = 197791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CheckBranch(string branchLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(branchLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06005EDA RID: 24282 RVA: 0x001B48E4 File Offset: 0x001B2AE4
		[CallerCount(0)]
		public unsafe virtual string ModifyDialogueText(string dialogueLabel, string dialogueText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EDB RID: 24283 RVA: 0x001B494C File Offset: 0x001B2B4C
		[CallerCount(0)]
		public unsafe virtual string ModifyChoiceText(string choiceLabel, string choiceText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(choiceText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06005EDC RID: 24284 RVA: 0x001B49B4 File Offset: 0x001B2BB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197791, XrefRangeEnd = 197794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ChoiceCallback(string choiceLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(choiceLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDD RID: 24285 RVA: 0x001B4A04 File Offset: 0x001B2C04
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197807, RefRangeEnd = 197809, XrefRangeStart = 197794, XrefRangeEnd = 197807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void DialogueCallback(string dialogueLabel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EDE RID: 24286 RVA: 0x001B4A54 File Offset: 0x001B2C54
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ModifyChoiceList(string dialogueLabel, ref List<DialogueChoiceData> existingChoices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(dialogueLabel);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtr(existingChoices);
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			existingChoices = ((intPtr4 == 0) ? null : new List<DialogueChoiceData>(intPtr4));
		}

		// Token: 0x06005EDF RID: 24287 RVA: 0x001B4AC8 File Offset: 0x001B2CC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197809, XrefRangeEnd = 197819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateTempLink(string baseNodeGUID, string baseOptionGUID, string targetNodeGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseNodeGUID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(baseOptionGUID);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(targetNodeGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE0 RID: 24288 RVA: 0x001B4B30 File Offset: 0x001B2D30
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197849, RefRangeEnd = 197852, XrefRangeStart = 197819, XrefRangeEnd = 197849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NodeLinkData GetLink(string baseChoiceOrOptionGUID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(baseChoiceOrOptionGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<NodeLinkData>(intPtr3) : null;
		}

		// Token: 0x06005EE1 RID: 24289 RVA: 0x001B4B80 File Offset: 0x001B2D80
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE2 RID: 24290 RVA: 0x001B4BBC File Offset: 0x001B2DBC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE3 RID: 24291 RVA: 0x001B4BF8 File Offset: 0x001B2DF8
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Local(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE4 RID: 24292 RVA: 0x001B4C48 File Offset: 0x001B2E48
		[CallerCount(0)]
		public unsafe virtual void PlayReaction_Networked(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE5 RID: 24293 RVA: 0x001B4C98 File Offset: 0x001B2E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197852, XrefRangeEnd = 197858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PlayReaction(string key, float duration, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE6 RID: 24294 RVA: 0x001B4D04 File Offset: 0x001B2F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197858, XrefRangeEnd = 197860, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void HideWorldspaceDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE7 RID: 24295 RVA: 0x001B4D40 File Offset: 0x001B2F40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197860, XrefRangeEnd = 197862, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ShowWorldspaceDialogue(string text, float duration)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref duration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE8 RID: 24296 RVA: 0x001B4D9C File Offset: 0x001B2F9C
		[CallerCount(0)]
		public unsafe virtual void ShowWorldspaceDialogue_5s(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueHandler.NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EE9 RID: 24297 RVA: 0x001B4DEC File Offset: 0x001B2FEC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 197894, RefRangeEnd = 197899, XrefRangeStart = 197862, XrefRangeEnd = 197894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueHandler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005EEA RID: 24298 RVA: 0x0002CAED File Offset: 0x0002ACED
		public DialogueHandler(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C78 RID: 7288
		// (get) Token: 0x06005EEB RID: 24299 RVA: 0x001B4E28 File Offset: 0x001B3028
		// (set) Token: 0x06005EEC RID: 24300 RVA: 0x0002CAF6 File Offset: 0x0002ACF6
		public unsafe static float TimePerChar
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_TimePerChar, (void*)(&value));
			}
		}

		// Token: 0x17001C79 RID: 7289
		// (get) Token: 0x06005EED RID: 24301 RVA: 0x001B4E44 File Offset: 0x001B3044
		// (set) Token: 0x06005EEE RID: 24302 RVA: 0x0002CB04 File Offset: 0x0002AD04
		public unsafe static float WorldspaceDialogueMinDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMinDuration, (void*)(&value));
			}
		}

		// Token: 0x17001C7A RID: 7290
		// (get) Token: 0x06005EEF RID: 24303 RVA: 0x001B4E60 File Offset: 0x001B3060
		// (set) Token: 0x06005EF0 RID: 24304 RVA: 0x0002CB12 File Offset: 0x0002AD12
		public unsafe static float WorldspaceDialogueMaxDuration
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_WorldspaceDialogueMaxDuration, (void*)(&value));
			}
		}

		// Token: 0x17001C7B RID: 7291
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x001B4E7C File Offset: 0x001B307C
		// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x0002CB20 File Offset: 0x0002AD20
		public unsafe static DialogueContainer activeDialogue
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogue, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7C RID: 7292
		// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x001B4EA4 File Offset: 0x001B30A4
		// (set) Token: 0x06005EF4 RID: 24308 RVA: 0x0002CB32 File Offset: 0x0002AD32
		public unsafe static DialogueNodeData activeDialogueNode
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueHandler.NativeFieldInfoPtr_activeDialogueNode, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7D RID: 7293
		// (get) Token: 0x06005EF5 RID: 24309 RVA: 0x001B4ECC File Offset: 0x001B30CC
		// (set) Token: 0x06005EF6 RID: 24310 RVA: 0x0002CB44 File Offset: 0x0002AD44
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C7E RID: 7294
		// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x001B4EF4 File Offset: 0x001B30F4
		// (set) Token: 0x06005EF8 RID: 24312 RVA: 0x0002CB5F File Offset: 0x0002AD5F
		public unsafe DialogueDatabase Database
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueDatabase>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_Database), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06005EF9 RID: 24313 RVA: 0x001B4F24 File Offset: 0x001B3124
		// (set) Token: 0x06005EFA RID: 24314 RVA: 0x0002CB7E File Offset: 0x0002AD7E
		public unsafe Transform LookPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_LookPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06005EFB RID: 24315 RVA: 0x001B4F54 File Offset: 0x001B3154
		// (set) Token: 0x06005EFC RID: 24316 RVA: 0x0002CB9D File Offset: 0x0002AD9D
		public unsafe WorldspaceDialogueRenderer WorldspaceRend
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_WorldspaceRend), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06005EFD RID: 24317 RVA: 0x001B4F84 File Offset: 0x001B3184
		// (set) Token: 0x06005EFE RID: 24318 RVA: 0x0002CBBC File Offset: 0x0002ADBC
		public unsafe NPC _NPC_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__NPC_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06005EFF RID: 24319 RVA: 0x001B4FB4 File Offset: 0x001B31B4
		// (set) Token: 0x06005F00 RID: 24320 RVA: 0x0002CBDB File Offset: 0x0002ADDB
		public unsafe VOEmitter VOEmitter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VOEmitter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_VOEmitter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C83 RID: 7299
		// (get) Token: 0x06005F01 RID: 24321 RVA: 0x001B4FE4 File Offset: 0x001B31E4
		// (set) Token: 0x06005F02 RID: 24322 RVA: 0x0002CBFA File Offset: 0x0002ADFA
		public unsafe List<DialogueChoiceData> CurrentChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_CurrentChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C84 RID: 7300
		// (get) Token: 0x06005F03 RID: 24323 RVA: 0x001B5014 File Offset: 0x001B3214
		// (set) Token: 0x06005F04 RID: 24324 RVA: 0x0002CC19 File Offset: 0x0002AE19
		public unsafe Il2CppReferenceArray<DialogueEvent> DialogueEvents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogueEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_DialogueEvents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C85 RID: 7301
		// (get) Token: 0x06005F05 RID: 24325 RVA: 0x001B5044 File Offset: 0x001B3244
		// (set) Token: 0x06005F06 RID: 24326 RVA: 0x0002CC38 File Offset: 0x0002AE38
		public unsafe UnityEvent onConversationStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onConversationStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C86 RID: 7302
		// (get) Token: 0x06005F07 RID: 24327 RVA: 0x001B5074 File Offset: 0x001B3274
		// (set) Token: 0x06005F08 RID: 24328 RVA: 0x0002CC57 File Offset: 0x0002AE57
		public unsafe UnityEvent<string> onDialogueNodeDisplayed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueNodeDisplayed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C87 RID: 7303
		// (get) Token: 0x06005F09 RID: 24329 RVA: 0x001B50A4 File Offset: 0x001B32A4
		// (set) Token: 0x06005F0A RID: 24330 RVA: 0x0002CC76 File Offset: 0x0002AE76
		public unsafe UnityEvent<string> onDialogueChoiceChosen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_onDialogueChoiceChosen), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C88 RID: 7304
		// (get) Token: 0x06005F0B RID: 24331 RVA: 0x001B50D4 File Offset: 0x001B32D4
		// (set) Token: 0x06005F0C RID: 24332 RVA: 0x0002CC95 File Offset: 0x0002AE95
		public unsafe string overrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x06005F0D RID: 24333 RVA: 0x001B50FC File Offset: 0x001B32FC
		// (set) Token: 0x06005F0E RID: 24334 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		public unsafe List<DialogueContainer> dialogueContainers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueContainer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_dialogueContainers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8A RID: 7306
		// (get) Token: 0x06005F0F RID: 24335 RVA: 0x001B512C File Offset: 0x001B332C
		// (set) Token: 0x06005F10 RID: 24336 RVA: 0x0002CCD3 File Offset: 0x0002AED3
		public unsafe List<NodeLinkData> TempLinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<NodeLinkData>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_TempLinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8B RID: 7307
		// (get) Token: 0x06005F11 RID: 24337 RVA: 0x001B515C File Offset: 0x001B335C
		// (set) Token: 0x06005F12 RID: 24338 RVA: 0x0002CCF2 File Offset: 0x0002AEF2
		public unsafe bool skipNextDialogueBehaviourEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_skipNextDialogueBehaviourEnd)) = value;
			}
		}

		// Token: 0x17001C8C RID: 7308
		// (get) Token: 0x06005F13 RID: 24339 RVA: 0x001B5184 File Offset: 0x001B3384
		// (set) Token: 0x06005F14 RID: 24340 RVA: 0x0002CD0D File Offset: 0x0002AF0D
		public unsafe List<DialogueModule> _runtimeModules_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueModule>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr__runtimeModules_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C8D RID: 7309
		// (get) Token: 0x06005F15 RID: 24341 RVA: 0x001B51B4 File Offset: 0x001B33B4
		// (set) Token: 0x06005F16 RID: 24342 RVA: 0x0002CD2C File Offset: 0x0002AF2C
		public unsafe bool passChecked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.NativeFieldInfoPtr_passChecked)) = value;
			}
		}

		// Token: 0x040040C5 RID: 16581
		private static readonly IntPtr NativeFieldInfoPtr_TimePerChar;

		// Token: 0x040040C6 RID: 16582
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMinDuration;

		// Token: 0x040040C7 RID: 16583
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceDialogueMaxDuration;

		// Token: 0x040040C8 RID: 16584
		private static readonly IntPtr NativeFieldInfoPtr_activeDialogue;

		// Token: 0x040040C9 RID: 16585
		private static readonly IntPtr NativeFieldInfoPtr_activeDialogueNode;

		// Token: 0x040040CA RID: 16586
		private static readonly IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x040040CB RID: 16587
		private static readonly IntPtr NativeFieldInfoPtr_Database;

		// Token: 0x040040CC RID: 16588
		private static readonly IntPtr NativeFieldInfoPtr_LookPosition;

		// Token: 0x040040CD RID: 16589
		private static readonly IntPtr NativeFieldInfoPtr_WorldspaceRend;

		// Token: 0x040040CE RID: 16590
		private static readonly IntPtr NativeFieldInfoPtr__NPC_k__BackingField;

		// Token: 0x040040CF RID: 16591
		private static readonly IntPtr NativeFieldInfoPtr_VOEmitter;

		// Token: 0x040040D0 RID: 16592
		private static readonly IntPtr NativeFieldInfoPtr_CurrentChoices;

		// Token: 0x040040D1 RID: 16593
		private static readonly IntPtr NativeFieldInfoPtr_DialogueEvents;

		// Token: 0x040040D2 RID: 16594
		private static readonly IntPtr NativeFieldInfoPtr_onConversationStart;

		// Token: 0x040040D3 RID: 16595
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueNodeDisplayed;

		// Token: 0x040040D4 RID: 16596
		private static readonly IntPtr NativeFieldInfoPtr_onDialogueChoiceChosen;

		// Token: 0x040040D5 RID: 16597
		private static readonly IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x040040D6 RID: 16598
		private static readonly IntPtr NativeFieldInfoPtr_dialogueContainers;

		// Token: 0x040040D7 RID: 16599
		private static readonly IntPtr NativeFieldInfoPtr_TempLinks;

		// Token: 0x040040D8 RID: 16600
		private static readonly IntPtr NativeFieldInfoPtr_skipNextDialogueBehaviourEnd;

		// Token: 0x040040D9 RID: 16601
		private static readonly IntPtr NativeFieldInfoPtr__runtimeModules_k__BackingField;

		// Token: 0x040040DA RID: 16602
		private static readonly IntPtr NativeFieldInfoPtr_passChecked;

		// Token: 0x040040DB RID: 16603
		private static readonly IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040040DC RID: 16604
		private static readonly IntPtr NativeMethodInfoPtr_set_IsPlaying_Private_set_Void_Boolean_0;

		// Token: 0x040040DD RID: 16605
		private static readonly IntPtr NativeMethodInfoPtr_get_NPC_Public_get_NPC_0;

		// Token: 0x040040DE RID: 16606
		private static readonly IntPtr NativeMethodInfoPtr_set_NPC_Protected_set_Void_NPC_0;

		// Token: 0x040040DF RID: 16607
		private static readonly IntPtr NativeMethodInfoPtr_get_canvas_Private_get_DialogueCanvas_0;

		// Token: 0x040040E0 RID: 16608
		private static readonly IntPtr NativeMethodInfoPtr_get_runtimeModules_Public_get_List_1_DialogueModule_0;

		// Token: 0x040040E1 RID: 16609
		private static readonly IntPtr NativeMethodInfoPtr_set_runtimeModules_Private_set_Void_List_1_DialogueModule_0;

		// Token: 0x040040E2 RID: 16610
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040040E3 RID: 16611
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040040E4 RID: 16612
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_0;

		// Token: 0x040040E5 RID: 16613
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_DialogueContainer_Boolean_String_0;

		// Token: 0x040040E6 RID: 16614
		private static readonly IntPtr NativeMethodInfoPtr_InitializeDialogue_Public_Void_String_Boolean_String_0;

		// Token: 0x040040E7 RID: 16615
		private static readonly IntPtr NativeMethodInfoPtr_CanBeginConversation_Public_Virtual_New_Boolean_0;

		// Token: 0x040040E8 RID: 16616
		private static readonly IntPtr NativeMethodInfoPtr_OverrideShownDialogue_Public_Void_String_0;

		// Token: 0x040040E9 RID: 16617
		private static readonly IntPtr NativeMethodInfoPtr_StopOverride_Public_Void_0;

		// Token: 0x040040EA RID: 16618
		private static readonly IntPtr NativeMethodInfoPtr_EndDialogue_Public_Virtual_New_Void_0;

		// Token: 0x040040EB RID: 16619
		private static readonly IntPtr NativeMethodInfoPtr_SkipNextDialogueBehaviourEnd_Public_Void_0;

		// Token: 0x040040EC RID: 16620
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeDialogueNode_Protected_Virtual_New_DialogueNodeData_DialogueNodeData_0;

		// Token: 0x040040ED RID: 16621
		private static readonly IntPtr NativeMethodInfoPtr_ShowNode_Public_Void_DialogueNodeData_0;

		// Token: 0x040040EE RID: 16622
		private static readonly IntPtr NativeMethodInfoPtr_EvaluateBranch_Private_Void_BranchNodeData_0;

		// Token: 0x040040EF RID: 16623
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x040040F0 RID: 16624
		private static readonly IntPtr NativeMethodInfoPtr_ContinueSubmitted_Public_Void_0;

		// Token: 0x040040F1 RID: 16625
		private static readonly IntPtr NativeMethodInfoPtr_CheckChoice_Public_Virtual_New_Boolean_String_byref_String_0;

		// Token: 0x040040F2 RID: 16626
		private static readonly IntPtr NativeMethodInfoPtr_ShouldChoiceBeShown_Public_Virtual_New_Boolean_String_0;

		// Token: 0x040040F3 RID: 16627
		private static readonly IntPtr NativeMethodInfoPtr_CheckBranch_Protected_Virtual_New_Int32_String_0;

		// Token: 0x040040F4 RID: 16628
		private static readonly IntPtr NativeMethodInfoPtr_ModifyDialogueText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x040040F5 RID: 16629
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceText_Protected_Virtual_New_String_String_String_0;

		// Token: 0x040040F6 RID: 16630
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x040040F7 RID: 16631
		private static readonly IntPtr NativeMethodInfoPtr_DialogueCallback_Protected_Virtual_New_Void_String_0;

		// Token: 0x040040F8 RID: 16632
		private static readonly IntPtr NativeMethodInfoPtr_ModifyChoiceList_Protected_Virtual_New_Void_String_byref_List_1_DialogueChoiceData_0;

		// Token: 0x040040F9 RID: 16633
		private static readonly IntPtr NativeMethodInfoPtr_CreateTempLink_Protected_Void_String_String_String_0;

		// Token: 0x040040FA RID: 16634
		private static readonly IntPtr NativeMethodInfoPtr_GetLink_Private_NodeLinkData_String_0;

		// Token: 0x040040FB RID: 16635
		private static readonly IntPtr NativeMethodInfoPtr_Hovered_Public_Virtual_New_Void_0;

		// Token: 0x040040FC RID: 16636
		private static readonly IntPtr NativeMethodInfoPtr_Interacted_Public_Virtual_New_Void_0;

		// Token: 0x040040FD RID: 16637
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Local_Public_Virtual_New_Void_String_0;

		// Token: 0x040040FE RID: 16638
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Networked_Public_Virtual_New_Void_String_0;

		// Token: 0x040040FF RID: 16639
		private static readonly IntPtr NativeMethodInfoPtr_PlayReaction_Public_Virtual_New_Void_String_Single_Boolean_0;

		// Token: 0x04004100 RID: 16640
		private static readonly IntPtr NativeMethodInfoPtr_HideWorldspaceDialogue_Public_Virtual_New_Void_0;

		// Token: 0x04004101 RID: 16641
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_Public_Virtual_New_Void_String_Single_0;

		// Token: 0x04004102 RID: 16642
		private static readonly IntPtr NativeMethodInfoPtr_ShowWorldspaceDialogue_5s_Public_Virtual_New_Void_String_0;

		// Token: 0x04004103 RID: 16643
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FD RID: 2557
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0")]
		public sealed class __c__DisplayClass35_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE2F RID: 52783 RVA: 0x00319A98 File Offset: 0x00317C98
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass35_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass35_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "npc");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<>4__this");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "dialogueContainer");
				DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "entryNodeLabel");
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675407);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675408);
				DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, 100675409);
			}

			// Token: 0x0600CE30 RID: 52784 RVA: 0x00319B50 File Offset: 0x00317D50
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass35_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE31 RID: 52785 RVA: 0x00319B8C File Offset: 0x00317D8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197456, XrefRangeEnd = 197461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600CE32 RID: 52786 RVA: 0x00319BCC File Offset: 0x00317DCC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 197490, RefRangeEnd = 197491, XrefRangeStart = 197461, XrefRangeEnd = 197490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Method_Internal_Void_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.NativeMethodInfoPtr_Method_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE33 RID: 52787 RVA: 0x000644CA File Offset: 0x000626CA
			public __c__DisplayClass35_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700402C RID: 16428
			// (get) Token: 0x0600CE34 RID: 52788 RVA: 0x00319C00 File Offset: 0x00317E00
			// (set) Token: 0x0600CE35 RID: 52789 RVA: 0x000644D3 File Offset: 0x000626D3
			public unsafe NPC npc
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402D RID: 16429
			// (get) Token: 0x0600CE36 RID: 52790 RVA: 0x00319C30 File Offset: 0x00317E30
			// (set) Token: 0x0600CE37 RID: 52791 RVA: 0x000644F2 File Offset: 0x000626F2
			public unsafe DialogueHandler __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402E RID: 16430
			// (get) Token: 0x0600CE38 RID: 52792 RVA: 0x00319C60 File Offset: 0x00317E60
			// (set) Token: 0x0600CE39 RID: 52793 RVA: 0x00064511 File Offset: 0x00062711
			public unsafe DialogueContainer dialogueContainer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueContainer>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_dialogueContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700402F RID: 16431
			// (get) Token: 0x0600CE3A RID: 52794 RVA: 0x00319C90 File Offset: 0x00317E90
			// (set) Token: 0x0600CE3B RID: 52795 RVA: 0x00064530 File Offset: 0x00062730
			public unsafe string entryNodeLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.NativeFieldInfoPtr_entryNodeLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B35 RID: 35637
			private static readonly IntPtr NativeFieldInfoPtr_npc;

			// Token: 0x04008B36 RID: 35638
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008B37 RID: 35639
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainer;

			// Token: 0x04008B38 RID: 35640
			private static readonly IntPtr NativeFieldInfoPtr_entryNodeLabel;

			// Token: 0x04008B39 RID: 35641
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B3A RID: 35642
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x04008B3B RID: 35643
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_Void_0;

			// Token: 0x02000C54 RID: 3156
			[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass35_0+<<InitializeDialogue>g__Wait|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E342 RID: 58178 RVA: 0x00355840 File Offset: 0x00353A40
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0>.NativeClassPtr, "<<InitializeDialogue>g__Wait|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675410);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675411);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675412);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675413);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675414);
					DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100675415);
				}

				// Token: 0x0600E343 RID: 58179 RVA: 0x00355920 File Offset: 0x00353B20
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E344 RID: 58180 RVA: 0x00355968 File Offset: 0x00353B68
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E345 RID: 58181 RVA: 0x0035599C File Offset: 0x00353B9C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197446, XrefRangeEnd = 197451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004683 RID: 18051
				// (get) Token: 0x0600E346 RID: 58182 RVA: 0x003559D8 File Offset: 0x00353BD8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E347 RID: 58183 RVA: 0x00355A18 File Offset: 0x00353C18
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197451, XrefRangeEnd = 197456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004684 RID: 18052
				// (get) Token: 0x0600E348 RID: 58184 RVA: 0x00355A4C File Offset: 0x00353C4C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E349 RID: 58185 RVA: 0x0006EC2D File Offset: 0x0006CE2D
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004680 RID: 18048
				// (get) Token: 0x0600E34A RID: 58186 RVA: 0x00355A8C File Offset: 0x00353C8C
				// (set) Token: 0x0600E34B RID: 58187 RVA: 0x0006EC36 File Offset: 0x0006CE36
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004681 RID: 18049
				// (get) Token: 0x0600E34C RID: 58188 RVA: 0x00355AB4 File Offset: 0x00353CB4
				// (set) Token: 0x0600E34D RID: 58189 RVA: 0x0006EC51 File Offset: 0x0006CE51
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004682 RID: 18050
				// (get) Token: 0x0600E34E RID: 58190 RVA: 0x00355AE4 File Offset: 0x00353CE4
				// (set) Token: 0x0600E34F RID: 58191 RVA: 0x0006EC70 File Offset: 0x0006CE70
				public unsafe DialogueHandler.__c__DisplayClass35_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler.__c__DisplayClass35_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass35_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009815 RID: 38933
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009816 RID: 38934
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009817 RID: 38935
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009818 RID: 38936
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009819 RID: 38937
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400981A RID: 38938
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400981B RID: 38939
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400981C RID: 38940
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400981D RID: 38941
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x020009FE RID: 2558
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass36_0")]
		public sealed class __c__DisplayClass36_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE3C RID: 52796 RVA: 0x00319CB8 File Offset: 0x00317EB8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass36_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass36_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, "dialogueContainerName");
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675416);
				DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr, 100675417);
			}

			// Token: 0x0600CE3D RID: 52797 RVA: 0x00319D20 File Offset: 0x00317F20
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass36_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass36_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE3E RID: 52798 RVA: 0x00319D5C File Offset: 0x00317F5C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 197491, XrefRangeEnd = 197496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _InitializeDialogue_b__0(DialogueContainer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass36_0.NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE3F RID: 52799 RVA: 0x0006454F File Offset: 0x0006274F
			public __c__DisplayClass36_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004030 RID: 16432
			// (get) Token: 0x0600CE40 RID: 52800 RVA: 0x00319DAC File Offset: 0x00317FAC
			// (set) Token: 0x0600CE41 RID: 52801 RVA: 0x00064558 File Offset: 0x00062758
			public unsafe string dialogueContainerName
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass36_0.NativeFieldInfoPtr_dialogueContainerName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B3C RID: 35644
			private static readonly IntPtr NativeFieldInfoPtr_dialogueContainerName;

			// Token: 0x04008B3D RID: 35645
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B3E RID: 35646
			private static readonly IntPtr NativeMethodInfoPtr__InitializeDialogue_b__0_Internal_Boolean_DialogueContainer_0;
		}

		// Token: 0x020009FF RID: 2559
		[ObfuscatedName("ScheduleOne.Dialogue.DialogueHandler+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CE42 RID: 52802 RVA: 0x00319DD4 File Offset: 0x00317FD4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueHandler>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr);
				DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, "baseChoiceOrOptionGUID");
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675418);
				DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr, 100675419);
			}

			// Token: 0x0600CE43 RID: 52803 RVA: 0x00319E3C File Offset: 0x0031803C
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueHandler.__c__DisplayClass57_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600CE44 RID: 52804 RVA: 0x00319E78 File Offset: 0x00318078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetLink_b__0(NodeLinkData x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueHandler.__c__DisplayClass57_0.NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600CE45 RID: 52805 RVA: 0x00064577 File Offset: 0x00062777
			public __c__DisplayClass57_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004031 RID: 16433
			// (get) Token: 0x0600CE46 RID: 52806 RVA: 0x00319EC8 File Offset: 0x003180C8
			// (set) Token: 0x0600CE47 RID: 52807 RVA: 0x00064580 File Offset: 0x00062780
			public unsafe string baseChoiceOrOptionGUID
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueHandler.__c__DisplayClass57_0.NativeFieldInfoPtr_baseChoiceOrOptionGUID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008B3F RID: 35647
			private static readonly IntPtr NativeFieldInfoPtr_baseChoiceOrOptionGUID;

			// Token: 0x04008B40 RID: 35648
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008B41 RID: 35649
			private static readonly IntPtr NativeMethodInfoPtr__GetLink_b__0_Internal_Boolean_NodeLinkData_0;
		}
	}
}
