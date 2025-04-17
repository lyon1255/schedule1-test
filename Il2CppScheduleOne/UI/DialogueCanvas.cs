using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Dialogue;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000635 RID: 1589
	public class DialogueCanvas : Singleton<DialogueCanvas>
	{
		// Token: 0x06008C62 RID: 35938 RVA: 0x0024A5F0 File Offset: 0x002487F0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogueCanvas()
		{
			Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DialogueCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr);
			DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "TIME_PER_CHAR");
			DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "SkipNextRollout");
			DialogueCanvas.NativeFieldInfoPtr_canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "canvas");
			DialogueCanvas.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "Container");
			DialogueCanvas.NativeFieldInfoPtr_dialogueText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueText");
			DialogueCanvas.NativeFieldInfoPtr_continuePopup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "continuePopup");
			DialogueCanvas.NativeFieldInfoPtr_dialogueChoices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueChoices");
			DialogueCanvas.NativeFieldInfoPtr_currentHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentHandler");
			DialogueCanvas.NativeFieldInfoPtr_currentNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "currentNode");
			DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "spaceDownThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "leftClickThisFrame");
			DialogueCanvas.NativeFieldInfoPtr_overrideText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "overrideText");
			DialogueCanvas.NativeFieldInfoPtr_dialogueRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "dialogueRollout");
			DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "choiceSelectionResidualCoroutine");
			DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "hasChoiceBeenSelected");
			DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680725);
			DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680726);
			DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680727);
			DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680728);
			DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680729);
			DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680730);
			DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680731);
			DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680732);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680733);
			DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680734);
			DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680735);
			DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680736);
			DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680737);
			DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680738);
			DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, 100680739);
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x06008C63 RID: 35939 RVA: 0x0024A878 File Offset: 0x00248A78
		public unsafe bool isActive
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 256454, RefRangeEnd = 256456, XrefRangeStart = 256450, XrefRangeEnd = 256454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06008C64 RID: 35940 RVA: 0x0024A8B4 File Offset: 0x00248AB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256456, XrefRangeEnd = 256473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DialogueCanvas.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C65 RID: 35941 RVA: 0x0024A8F0 File Offset: 0x00248AF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256489, RefRangeEnd = 256490, XrefRangeStart = 256473, XrefRangeEnd = 256489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayDialogueNode(DialogueHandler diag, DialogueNodeData node, string dialogueText, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(diag);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(node);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dialogueText);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C66 RID: 35942 RVA: 0x0024A96C File Offset: 0x00248B6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256496, RefRangeEnd = 256497, XrefRangeStart = 256490, XrefRangeEnd = 256496, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OverrideText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_OverrideText_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C67 RID: 35943 RVA: 0x0024A9B0 File Offset: 0x00248BB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256500, RefRangeEnd = 256501, XrefRangeStart = 256497, XrefRangeEnd = 256500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopTextOverride()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StopTextOverride_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C68 RID: 35944 RVA: 0x0024A9E4 File Offset: 0x00248BE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256501, XrefRangeEnd = 256510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C69 RID: 35945 RVA: 0x0024AA18 File Offset: 0x00248C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256510, XrefRangeEnd = 256517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C6A RID: 35946 RVA: 0x0024AA5C File Offset: 0x00248C5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256517, XrefRangeEnd = 256524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator RolloutDialogue(string text, List<string> choices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(choices);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008C6B RID: 35947 RVA: 0x0024AAC0 File Offset: 0x00248CC0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256530, RefRangeEnd = 256531, XrefRangeStart = 256524, XrefRangeEnd = 256530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ChoiceSelectionResidual(DialogueChoiceEntry choice, float fadeTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(choice);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref fadeTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06008C6C RID: 35948 RVA: 0x0024AB20 File Offset: 0x00248D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256585, RefRangeEnd = 256586, XrefRangeStart = 256531, XrefRangeEnd = 256585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDialogue(DialogueHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C6D RID: 35949 RVA: 0x0024AB64 File Offset: 0x00248D64
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 256617, RefRangeEnd = 256618, XrefRangeStart = 256586, XrefRangeEnd = 256617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndDialogue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_EndDialogue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C6E RID: 35950 RVA: 0x0024AB98 File Offset: 0x00248D98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256618, XrefRangeEnd = 256645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChoiceSelected(int choiceIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C6F RID: 35951 RVA: 0x0024ABD8 File Offset: 0x00248DD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256645, XrefRangeEnd = 256653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsChoiceValid(int choiceIndex, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref choiceIndex;
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06008C70 RID: 35952 RVA: 0x0024AC3C File Offset: 0x00248E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256653, XrefRangeEnd = 256666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogueCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06008C71 RID: 35953 RVA: 0x0024AC78 File Offset: 0x00248E78
		[CallerCount(0)]
		public unsafe bool _RolloutDialogue_b__21_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas.NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06008C72 RID: 35954 RVA: 0x00043512 File Offset: 0x00041712
		public DialogueCanvas(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AD4 RID: 10964
		// (get) Token: 0x06008C73 RID: 35955 RVA: 0x0024ACB4 File Offset: 0x00248EB4
		// (set) Token: 0x06008C74 RID: 35956 RVA: 0x0004351B File Offset: 0x0004171B
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DialogueCanvas.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002AD5 RID: 10965
		// (get) Token: 0x06008C75 RID: 35957 RVA: 0x0024ACD0 File Offset: 0x00248ED0
		// (set) Token: 0x06008C76 RID: 35958 RVA: 0x00043529 File Offset: 0x00041729
		public unsafe bool SkipNextRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_SkipNextRollout)) = value;
			}
		}

		// Token: 0x17002AD6 RID: 10966
		// (get) Token: 0x06008C77 RID: 35959 RVA: 0x0024ACF8 File Offset: 0x00248EF8
		// (set) Token: 0x06008C78 RID: 35960 RVA: 0x00043544 File Offset: 0x00041744
		public unsafe Canvas canvas
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD7 RID: 10967
		// (get) Token: 0x06008C79 RID: 35961 RVA: 0x0024AD28 File Offset: 0x00248F28
		// (set) Token: 0x06008C7A RID: 35962 RVA: 0x00043563 File Offset: 0x00041763
		public unsafe RectTransform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD8 RID: 10968
		// (get) Token: 0x06008C7B RID: 35963 RVA: 0x0024AD58 File Offset: 0x00248F58
		// (set) Token: 0x06008C7C RID: 35964 RVA: 0x00043582 File Offset: 0x00041782
		public unsafe TextMeshProUGUI dialogueText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AD9 RID: 10969
		// (get) Token: 0x06008C7D RID: 35965 RVA: 0x0024AD88 File Offset: 0x00248F88
		// (set) Token: 0x06008C7E RID: 35966 RVA: 0x000435A1 File Offset: 0x000417A1
		public unsafe GameObject continuePopup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_continuePopup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x06008C7F RID: 35967 RVA: 0x0024ADB8 File Offset: 0x00248FB8
		// (set) Token: 0x06008C80 RID: 35968 RVA: 0x000435C0 File Offset: 0x000417C0
		public unsafe List<DialogueChoiceEntry> dialogueChoices
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DialogueChoiceEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueChoices), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x06008C81 RID: 35969 RVA: 0x0024ADE8 File Offset: 0x00248FE8
		// (set) Token: 0x06008C82 RID: 35970 RVA: 0x000435DF File Offset: 0x000417DF
		public unsafe DialogueHandler currentHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x06008C83 RID: 35971 RVA: 0x0024AE18 File Offset: 0x00249018
		// (set) Token: 0x06008C84 RID: 35972 RVA: 0x000435FE File Offset: 0x000417FE
		public unsafe DialogueNodeData currentNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueNodeData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_currentNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x06008C85 RID: 35973 RVA: 0x0024AE48 File Offset: 0x00249048
		// (set) Token: 0x06008C86 RID: 35974 RVA: 0x0004361D File Offset: 0x0004181D
		public unsafe bool spaceDownThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_spaceDownThisFrame)) = value;
			}
		}

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x06008C87 RID: 35975 RVA: 0x0024AE70 File Offset: 0x00249070
		// (set) Token: 0x06008C88 RID: 35976 RVA: 0x00043638 File Offset: 0x00041838
		public unsafe bool leftClickThisFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_leftClickThisFrame)) = value;
			}
		}

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x06008C89 RID: 35977 RVA: 0x0024AE98 File Offset: 0x00249098
		// (set) Token: 0x06008C8A RID: 35978 RVA: 0x00043653 File Offset: 0x00041853
		public unsafe string overrideText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_overrideText), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x06008C8B RID: 35979 RVA: 0x0024AEC0 File Offset: 0x002490C0
		// (set) Token: 0x06008C8C RID: 35980 RVA: 0x00043672 File Offset: 0x00041872
		public unsafe Coroutine dialogueRollout
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_dialogueRollout), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x06008C8D RID: 35981 RVA: 0x0024AEF0 File Offset: 0x002490F0
		// (set) Token: 0x06008C8E RID: 35982 RVA: 0x00043691 File Offset: 0x00041891
		public unsafe Coroutine choiceSelectionResidualCoroutine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_choiceSelectionResidualCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008C8F RID: 35983 RVA: 0x0024AF20 File Offset: 0x00249120
		// (set) Token: 0x06008C90 RID: 35984 RVA: 0x000436B0 File Offset: 0x000418B0
		public unsafe bool hasChoiceBeenSelected
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas.NativeFieldInfoPtr_hasChoiceBeenSelected)) = value;
			}
		}

		// Token: 0x04005F25 RID: 24357
		private static readonly IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x04005F26 RID: 24358
		private static readonly IntPtr NativeFieldInfoPtr_SkipNextRollout;

		// Token: 0x04005F27 RID: 24359
		private static readonly IntPtr NativeFieldInfoPtr_canvas;

		// Token: 0x04005F28 RID: 24360
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04005F29 RID: 24361
		private static readonly IntPtr NativeFieldInfoPtr_dialogueText;

		// Token: 0x04005F2A RID: 24362
		private static readonly IntPtr NativeFieldInfoPtr_continuePopup;

		// Token: 0x04005F2B RID: 24363
		private static readonly IntPtr NativeFieldInfoPtr_dialogueChoices;

		// Token: 0x04005F2C RID: 24364
		private static readonly IntPtr NativeFieldInfoPtr_currentHandler;

		// Token: 0x04005F2D RID: 24365
		private static readonly IntPtr NativeFieldInfoPtr_currentNode;

		// Token: 0x04005F2E RID: 24366
		private static readonly IntPtr NativeFieldInfoPtr_spaceDownThisFrame;

		// Token: 0x04005F2F RID: 24367
		private static readonly IntPtr NativeFieldInfoPtr_leftClickThisFrame;

		// Token: 0x04005F30 RID: 24368
		private static readonly IntPtr NativeFieldInfoPtr_overrideText;

		// Token: 0x04005F31 RID: 24369
		private static readonly IntPtr NativeFieldInfoPtr_dialogueRollout;

		// Token: 0x04005F32 RID: 24370
		private static readonly IntPtr NativeFieldInfoPtr_choiceSelectionResidualCoroutine;

		// Token: 0x04005F33 RID: 24371
		private static readonly IntPtr NativeFieldInfoPtr_hasChoiceBeenSelected;

		// Token: 0x04005F34 RID: 24372
		private static readonly IntPtr NativeMethodInfoPtr_get_isActive_Public_get_Boolean_0;

		// Token: 0x04005F35 RID: 24373
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04005F36 RID: 24374
		private static readonly IntPtr NativeMethodInfoPtr_DisplayDialogueNode_Public_Void_DialogueHandler_DialogueNodeData_String_List_1_String_0;

		// Token: 0x04005F37 RID: 24375
		private static readonly IntPtr NativeMethodInfoPtr_OverrideText_Public_Void_String_0;

		// Token: 0x04005F38 RID: 24376
		private static readonly IntPtr NativeMethodInfoPtr_StopTextOverride_Public_Void_0;

		// Token: 0x04005F39 RID: 24377
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04005F3A RID: 24378
		private static readonly IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04005F3B RID: 24379
		private static readonly IntPtr NativeMethodInfoPtr_RolloutDialogue_Protected_IEnumerator_String_List_1_String_0;

		// Token: 0x04005F3C RID: 24380
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelectionResidual_Private_IEnumerator_DialogueChoiceEntry_Single_0;

		// Token: 0x04005F3D RID: 24381
		private static readonly IntPtr NativeMethodInfoPtr_StartDialogue_Private_Void_DialogueHandler_0;

		// Token: 0x04005F3E RID: 24382
		private static readonly IntPtr NativeMethodInfoPtr_EndDialogue_Public_Void_0;

		// Token: 0x04005F3F RID: 24383
		private static readonly IntPtr NativeMethodInfoPtr_ChoiceSelected_Public_Void_Int32_0;

		// Token: 0x04005F40 RID: 24384
		private static readonly IntPtr NativeMethodInfoPtr_IsChoiceValid_Private_Boolean_Int32_byref_String_0;

		// Token: 0x04005F41 RID: 24385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04005F42 RID: 24386
		private static readonly IntPtr NativeMethodInfoPtr__RolloutDialogue_b__21_0_Private_Boolean_0;

		// Token: 0x02000B1B RID: 2843
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<ChoiceSelectionResidual>d__23")]
		public sealed class _ChoiceSelectionResidual_d__23 : Il2CppSystem.Object
		{
			// Token: 0x0600D706 RID: 55046 RVA: 0x00332694 File Offset: 0x00330894
			// Note: this type is marked as 'beforefieldinit'.
			static _ChoiceSelectionResidual_d__23()
			{
				Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<ChoiceSelectionResidual>d__23");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>1__state");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>2__current");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "fadeTime");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "choice");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<>4__this");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<realFadeTime>5__2");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, "<i>5__3");
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680740);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680741);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680742);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680743);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680744);
				DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr, 100680745);
			}

			// Token: 0x0600D707 RID: 55047 RVA: 0x003327C4 File Offset: 0x003309C4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ChoiceSelectionResidual_d__23(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._ChoiceSelectionResidual_d__23>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D708 RID: 55048 RVA: 0x0033280C File Offset: 0x00330A0C
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D709 RID: 55049 RVA: 0x00332840 File Offset: 0x00330A40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256382, XrefRangeEnd = 256394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042A4 RID: 17060
			// (get) Token: 0x0600D70A RID: 55050 RVA: 0x0033287C File Offset: 0x00330A7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D70B RID: 55051 RVA: 0x003328BC File Offset: 0x00330ABC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256394, XrefRangeEnd = 256399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042A5 RID: 17061
			// (get) Token: 0x0600D70C RID: 55052 RVA: 0x003328F0 File Offset: 0x00330AF0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D70D RID: 55053 RVA: 0x00068A7C File Offset: 0x00066C7C
			public _ChoiceSelectionResidual_d__23(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700429D RID: 17053
			// (get) Token: 0x0600D70E RID: 55054 RVA: 0x00332930 File Offset: 0x00330B30
			// (set) Token: 0x0600D70F RID: 55055 RVA: 0x00068A85 File Offset: 0x00066C85
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x1700429E RID: 17054
			// (get) Token: 0x0600D710 RID: 55056 RVA: 0x00332958 File Offset: 0x00330B58
			// (set) Token: 0x0600D711 RID: 55057 RVA: 0x00068AA0 File Offset: 0x00066CA0
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700429F RID: 17055
			// (get) Token: 0x0600D712 RID: 55058 RVA: 0x00332988 File Offset: 0x00330B88
			// (set) Token: 0x0600D713 RID: 55059 RVA: 0x00068ABF File Offset: 0x00066CBF
			public unsafe float fadeTime
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_fadeTime)) = value;
				}
			}

			// Token: 0x170042A0 RID: 17056
			// (get) Token: 0x0600D714 RID: 55060 RVA: 0x003329B0 File Offset: 0x00330BB0
			// (set) Token: 0x0600D715 RID: 55061 RVA: 0x00068ADA File Offset: 0x00066CDA
			public unsafe DialogueChoiceEntry choice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueChoiceEntry>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr_choice), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A1 RID: 17057
			// (get) Token: 0x0600D716 RID: 55062 RVA: 0x003329E0 File Offset: 0x00330BE0
			// (set) Token: 0x0600D717 RID: 55063 RVA: 0x00068AF9 File Offset: 0x00066CF9
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A2 RID: 17058
			// (get) Token: 0x0600D718 RID: 55064 RVA: 0x00332A10 File Offset: 0x00330C10
			// (set) Token: 0x0600D719 RID: 55065 RVA: 0x00068B18 File Offset: 0x00066D18
			public unsafe float _realFadeTime_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__realFadeTime_5__2)) = value;
				}
			}

			// Token: 0x170042A3 RID: 17059
			// (get) Token: 0x0600D71A RID: 55066 RVA: 0x00332A38 File Offset: 0x00330C38
			// (set) Token: 0x0600D71B RID: 55067 RVA: 0x00068B33 File Offset: 0x00066D33
			public unsafe float _i_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._ChoiceSelectionResidual_d__23.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04009093 RID: 37011
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009094 RID: 37012
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009095 RID: 37013
			private static readonly IntPtr NativeFieldInfoPtr_fadeTime;

			// Token: 0x04009096 RID: 37014
			private static readonly IntPtr NativeFieldInfoPtr_choice;

			// Token: 0x04009097 RID: 37015
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009098 RID: 37016
			private static readonly IntPtr NativeFieldInfoPtr__realFadeTime_5__2;

			// Token: 0x04009099 RID: 37017
			private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x0400909A RID: 37018
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400909B RID: 37019
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400909C RID: 37020
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400909D RID: 37021
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400909E RID: 37022
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400909F RID: 37023
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x02000B1C RID: 2844
		[ObfuscatedName("ScheduleOne.UI.DialogueCanvas+<RolloutDialogue>d__21")]
		public sealed class _RolloutDialogue_d__21 : Il2CppSystem.Object
		{
			// Token: 0x0600D71C RID: 55068 RVA: 0x00332A60 File Offset: 0x00330C60
			// Note: this type is marked as 'beforefieldinit'.
			static _RolloutDialogue_d__21()
			{
				Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogueCanvas>.NativeClassPtr, "<RolloutDialogue>d__21");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr);
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>1__state");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>2__current");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<>4__this");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "text");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "choices");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<activeDialogueChoices>5__2");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<rolloutTime>5__3");
				DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, "<i>5__4");
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680746);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680747);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680748);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680749);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680750);
				DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr, 100680751);
			}

			// Token: 0x0600D71D RID: 55069 RVA: 0x00332BA4 File Offset: 0x00330DA4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RolloutDialogue_d__21(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogueCanvas._RolloutDialogue_d__21>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D71E RID: 55070 RVA: 0x00332BEC File Offset: 0x00330DEC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600D71F RID: 55071 RVA: 0x00332C20 File Offset: 0x00330E20
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256399, XrefRangeEnd = 256445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170042AE RID: 17070
			// (get) Token: 0x0600D720 RID: 55072 RVA: 0x00332C5C File Offset: 0x00330E5C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D721 RID: 55073 RVA: 0x00332C9C File Offset: 0x00330E9C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256445, XrefRangeEnd = 256450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170042AF RID: 17071
			// (get) Token: 0x0600D722 RID: 55074 RVA: 0x00332CD0 File Offset: 0x00330ED0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogueCanvas._RolloutDialogue_d__21.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600D723 RID: 55075 RVA: 0x00068B4E File Offset: 0x00066D4E
			public _RolloutDialogue_d__21(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042A6 RID: 17062
			// (get) Token: 0x0600D724 RID: 55076 RVA: 0x00332D10 File Offset: 0x00330F10
			// (set) Token: 0x0600D725 RID: 55077 RVA: 0x00068B57 File Offset: 0x00066D57
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170042A7 RID: 17063
			// (get) Token: 0x0600D726 RID: 55078 RVA: 0x00332D38 File Offset: 0x00330F38
			// (set) Token: 0x0600D727 RID: 55079 RVA: 0x00068B72 File Offset: 0x00066D72
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A8 RID: 17064
			// (get) Token: 0x0600D728 RID: 55080 RVA: 0x00332D68 File Offset: 0x00330F68
			// (set) Token: 0x0600D729 RID: 55081 RVA: 0x00068B91 File Offset: 0x00066D91
			public unsafe DialogueCanvas __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogueCanvas>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042A9 RID: 17065
			// (get) Token: 0x0600D72A RID: 55082 RVA: 0x00332D98 File Offset: 0x00330F98
			// (set) Token: 0x0600D72B RID: 55083 RVA: 0x00068BB0 File Offset: 0x00066DB0
			public unsafe string text
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170042AA RID: 17066
			// (get) Token: 0x0600D72C RID: 55084 RVA: 0x00332DC0 File Offset: 0x00330FC0
			// (set) Token: 0x0600D72D RID: 55085 RVA: 0x00068BCF File Offset: 0x00066DCF
			public unsafe List<string> choices
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr_choices), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AB RID: 17067
			// (get) Token: 0x0600D72E RID: 55086 RVA: 0x00332DF0 File Offset: 0x00330FF0
			// (set) Token: 0x0600D72F RID: 55087 RVA: 0x00068BEE File Offset: 0x00066DEE
			public unsafe List<int> _activeDialogueChoices_5__2
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__activeDialogueChoices_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AC RID: 17068
			// (get) Token: 0x0600D730 RID: 55088 RVA: 0x00332E20 File Offset: 0x00331020
			// (set) Token: 0x0600D731 RID: 55089 RVA: 0x00068C0D File Offset: 0x00066E0D
			public unsafe float _rolloutTime_5__3
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__rolloutTime_5__3)) = value;
				}
			}

			// Token: 0x170042AD RID: 17069
			// (get) Token: 0x0600D732 RID: 55090 RVA: 0x00332E48 File Offset: 0x00331048
			// (set) Token: 0x0600D733 RID: 55091 RVA: 0x00068C28 File Offset: 0x00066E28
			public unsafe float _i_5__4
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogueCanvas._RolloutDialogue_d__21.NativeFieldInfoPtr__i_5__4)) = value;
				}
			}

			// Token: 0x040090A0 RID: 37024
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040090A1 RID: 37025
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040090A2 RID: 37026
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040090A3 RID: 37027
			private static readonly IntPtr NativeFieldInfoPtr_text;

			// Token: 0x040090A4 RID: 37028
			private static readonly IntPtr NativeFieldInfoPtr_choices;

			// Token: 0x040090A5 RID: 37029
			private static readonly IntPtr NativeFieldInfoPtr__activeDialogueChoices_5__2;

			// Token: 0x040090A6 RID: 37030
			private static readonly IntPtr NativeFieldInfoPtr__rolloutTime_5__3;

			// Token: 0x040090A7 RID: 37031
			private static readonly IntPtr NativeFieldInfoPtr__i_5__4;

			// Token: 0x040090A8 RID: 37032
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040090A9 RID: 37033
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090AA RID: 37034
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040090AB RID: 37035
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040090AC RID: 37036
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040090AD RID: 37037
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
