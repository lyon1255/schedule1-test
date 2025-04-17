using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Persistence.Loaders;
using Il2CppScheduleOne.UI.Phone.Messages;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000375 RID: 885
	[Serializable]
	public class MSGConversation : Il2CppSystem.Object
	{
		// Token: 0x0600451A RID: 17690 RVA: 0x001553B8 File Offset: 0x001535B8
		// Note: this type is marked as 'beforefieldinit'.
		static MSGConversation()
		{
			Il2CppClassPointerStore<MSGConversation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "MSGConversation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr);
			MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "MAX_MESSAGE_HISTORY");
			MSGConversation.NativeFieldInfoPtr_contactName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "contactName");
			MSGConversation.NativeFieldInfoPtr_sender = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sender");
			MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<IsSenderKnown>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_messageHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageHistory");
			MSGConversation.NativeFieldInfoPtr_messageChainHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "messageChainHistory");
			MSGConversation.NativeFieldInfoPtr_bubbles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbles");
			MSGConversation.NativeFieldInfoPtr_Sendables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Sendables");
			MSGConversation.NativeFieldInfoPtr_read = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "read");
			MSGConversation.NativeFieldInfoPtr__index_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<index>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<isOpen>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<rollingOut>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<EntryVisible>k__BackingField");
			MSGConversation.NativeFieldInfoPtr_Categories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "Categories");
			MSGConversation.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entry");
			MSGConversation.NativeFieldInfoPtr_container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "container");
			MSGConversation.NativeFieldInfoPtr_bubbleContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "bubbleContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRectContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRectContainer");
			MSGConversation.NativeFieldInfoPtr_scrollRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "scrollRect");
			MSGConversation.NativeFieldInfoPtr_entryPreviewText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "entryPreviewText");
			MSGConversation.NativeFieldInfoPtr_unreadDot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "unreadDot");
			MSGConversation.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "slider");
			MSGConversation.NativeFieldInfoPtr_sliderFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "sliderFill");
			MSGConversation.NativeFieldInfoPtr_responseContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseContainer");
			MSGConversation.NativeFieldInfoPtr_senderInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "senderInterface");
			MSGConversation.NativeFieldInfoPtr_uiCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "uiCreated");
			MSGConversation.NativeFieldInfoPtr_onMessageRendered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onMessageRendered");
			MSGConversation.NativeFieldInfoPtr_onLoaded = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onLoaded");
			MSGConversation.NativeFieldInfoPtr_onResponsesShown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "onResponsesShown");
			MSGConversation.NativeFieldInfoPtr_currentResponses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "currentResponses");
			MSGConversation.NativeFieldInfoPtr_responseRects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "responseRects");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFiles>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<LocalExtraFolders>k__BackingField");
			MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<HasChanged>k__BackingField");
			MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671772);
			MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671773);
			MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671774);
			MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671775);
			MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671776);
			MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671777);
			MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671778);
			MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671779);
			MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671780);
			MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671781);
			MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671782);
			MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671783);
			MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671784);
			MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671785);
			MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671786);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671787);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671788);
			MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671789);
			MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671790);
			MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671791);
			MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671792);
			MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671793);
			MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671794);
			MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671795);
			MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671796);
			MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671797);
			MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671798);
			MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671799);
			MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671800);
			MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671801);
			MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671802);
			MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671803);
			MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671804);
			MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671805);
			MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671806);
			MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671807);
			MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671808);
			MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671809);
			MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671810);
			MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671811);
			MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671812);
			MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671813);
			MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671814);
			MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671815);
			MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671816);
			MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671817);
			MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671818);
			MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671819);
			MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671820);
			MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671821);
			MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671822);
			MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671823);
			MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671824);
			MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671825);
			MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671826);
			MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, 100671827);
		}

		// Token: 0x170014F1 RID: 5361
		// (get) Token: 0x0600451B RID: 17691 RVA: 0x00155AF0 File Offset: 0x00153CF0
		// (set) Token: 0x0600451C RID: 17692 RVA: 0x00155B2C File Offset: 0x00153D2C
		public unsafe bool IsSenderKnown
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 35361, RefRangeEnd = 35362, XrefRangeStart = 35361, XrefRangeEnd = 35362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F2 RID: 5362
		// (get) Token: 0x0600451D RID: 17693 RVA: 0x00155B6C File Offset: 0x00153D6C
		// (set) Token: 0x0600451E RID: 17694 RVA: 0x00155BA8 File Offset: 0x00153DA8
		public unsafe int index
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 48687, RefRangeEnd = 48689, XrefRangeStart = 48687, XrefRangeEnd = 48689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_index_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 48689, RefRangeEnd = 48690, XrefRangeStart = 48689, XrefRangeEnd = 48690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F3 RID: 5363
		// (get) Token: 0x0600451F RID: 17695 RVA: 0x00155BE8 File Offset: 0x00153DE8
		// (set) Token: 0x06004520 RID: 17696 RVA: 0x00155C24 File Offset: 0x00153E24
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F4 RID: 5364
		// (get) Token: 0x06004521 RID: 17697 RVA: 0x00155C64 File Offset: 0x00153E64
		// (set) Token: 0x06004522 RID: 17698 RVA: 0x00155CA0 File Offset: 0x00153EA0
		public unsafe bool rollingOut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F5 RID: 5365
		// (get) Token: 0x06004523 RID: 17699 RVA: 0x00155CE0 File Offset: 0x00153EE0
		// (set) Token: 0x06004524 RID: 17700 RVA: 0x00155D1C File Offset: 0x00153F1C
		public unsafe bool EntryVisible
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014F6 RID: 5366
		// (get) Token: 0x06004525 RID: 17701 RVA: 0x00155D5C File Offset: 0x00153F5C
		public unsafe bool AreResponsesActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156515, XrefRangeEnd = 156516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014F7 RID: 5367
		// (get) Token: 0x06004526 RID: 17702 RVA: 0x00155D98 File Offset: 0x00153F98
		public unsafe virtual string SaveFolderName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156516, XrefRangeEnd = 156518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014F8 RID: 5368
		// (get) Token: 0x06004527 RID: 17703 RVA: 0x00155DD0 File Offset: 0x00153FD0
		public unsafe virtual string SaveFileName
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 156520, RefRangeEnd = 156521, XrefRangeStart = 156518, XrefRangeEnd = 156520, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170014F9 RID: 5369
		// (get) Token: 0x06004528 RID: 17704 RVA: 0x00155E08 File Offset: 0x00154008
		public unsafe virtual Loader Loader
		{
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 31226, RefRangeEnd = 31291, XrefRangeStart = 31226, XrefRangeEnd = 31291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Loader>(intPtr3) : null;
			}
		}

		// Token: 0x170014FA RID: 5370
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x00155E48 File Offset: 0x00154048
		public unsafe virtual bool ShouldSaveUnderFolder
		{
			[CallerCount(183)]
			[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170014FB RID: 5371
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x00155E84 File Offset: 0x00154084
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x00155EC4 File Offset: 0x001540C4
		public unsafe virtual List<string> LocalExtraFiles
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FC RID: 5372
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x00155F08 File Offset: 0x00154108
		// (set) Token: 0x0600452D RID: 17709 RVA: 0x00155F48 File Offset: 0x00154148
		public unsafe virtual List<string> LocalExtraFolders
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156521, XrefRangeEnd = 156522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170014FD RID: 5373
		// (get) Token: 0x0600452E RID: 17710 RVA: 0x00155F8C File Offset: 0x0015418C
		// (set) Token: 0x0600452F RID: 17711 RVA: 0x00155FC8 File Offset: 0x001541C8
		public unsafe virtual bool HasChanged
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004530 RID: 17712 RVA: 0x00156008 File Offset: 0x00154208
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156616, RefRangeEnd = 156617, XrefRangeStart = 156522, XrefRangeEnd = 156616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversation(NPC _npc, string _contactName) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_npc);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_contactName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004531 RID: 17713 RVA: 0x00156068 File Offset: 0x00154268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156617, XrefRangeEnd = 156623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void InitializeSaveable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004532 RID: 17714 RVA: 0x001560A4 File Offset: 0x001542A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCategories(List<EConversationCategory> cat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cat);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x001560E8 File Offset: 0x001542E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156640, RefRangeEnd = 156643, XrefRangeStart = 156623, XrefRangeEnd = 156640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MoveToTop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_MoveToTop_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x0015611C File Offset: 0x0015431C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 156768, RefRangeEnd = 156774, XrefRangeStart = 156643, XrefRangeEnd = 156768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00156150 File Offset: 0x00154350
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156774, XrefRangeEnd = 156775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureUIExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EnsureUIExists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00156184 File Offset: 0x00154384
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156783, RefRangeEnd = 156786, XrefRangeStart = 156775, XrefRangeEnd = 156783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshPreviewText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x001561B8 File Offset: 0x001543B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156798, RefRangeEnd = 156800, XrefRangeStart = 156786, XrefRangeEnd = 156798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepositionEntry()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RepositionEntry_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x001561EC File Offset: 0x001543EC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 156824, RefRangeEnd = 156827, XrefRangeStart = 156800, XrefRangeEnd = 156824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsKnown(bool known)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref known;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x0015622C File Offset: 0x0015442C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156827, XrefRangeEnd = 156828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EntryClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_EntryClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00156260 File Offset: 0x00154460
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 156858, RefRangeEnd = 156863, XrefRangeStart = 156828, XrefRangeEnd = 156858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x001562A0 File Offset: 0x001544A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156863, XrefRangeEnd = 156944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RenderMessage(Message m)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x001562F0 File Offset: 0x001544F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156944, XrefRangeEnd = 156947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEntryVisibility(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00156330 File Offset: 0x00154530
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 156978, RefRangeEnd = 156985, XrefRangeStart = 156947, XrefRangeEnd = 156978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRead(bool r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref r;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00156370 File Offset: 0x00154570
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 157030, RefRangeEnd = 157039, XrefRangeStart = 156985, XrefRangeEnd = 157030, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessage(Message message, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x001563D0 File Offset: 0x001545D0
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 157072, RefRangeEnd = 157093, XrefRangeStart = 157039, XrefRangeEnd = 157072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendMessageChain(MessageChain messages, float initialDelay = 0f, bool notify = true, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(messages);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref notify;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x0015643C File Offset: 0x0015463C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157152, RefRangeEnd = 157154, XrefRangeStart = 157093, XrefRangeEnd = 157152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MSGConversationData GetSaveData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MSGConversationData>(intPtr3) : null;
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x0015647C File Offset: 0x0015467C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157154, XrefRangeEnd = 157156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x001564C0 File Offset: 0x001546C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157156, XrefRangeEnd = 157210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Load(MSGConversationData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MSGConversation.NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00156510 File Offset: 0x00154710
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157216, RefRangeEnd = 157218, XrefRangeStart = 157210, XrefRangeEnd = 157216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSliderValue(float value, Color color)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x0015655C File Offset: 0x0015475C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157233, RefRangeEnd = 157234, XrefRangeStart = 157218, XrefRangeEnd = 157233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response GetResponse(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_GetResponse_Public_Response_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Response>(intPtr3) : null;
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x001565AC File Offset: 0x001547AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157261, RefRangeEnd = 157265, XrefRangeStart = 157234, XrefRangeEnd = 157261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowResponses(List<Response> _responses, float showResponseDelay = 0f, bool network = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_responses);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref showResponseDelay;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x0015660C File Offset: 0x0015480C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157316, RefRangeEnd = 157317, XrefRangeStart = 157265, XrefRangeEnd = 157316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateResponseUI(Response r)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x00156650 File Offset: 0x00154850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157317, XrefRangeEnd = 157337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshResponseContainer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00156684 File Offset: 0x00154884
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 157349, RefRangeEnd = 157353, XrefRangeStart = 157337, XrefRangeEnd = 157349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponseUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x001566B8 File Offset: 0x001548B8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 157363, RefRangeEnd = 157369, XrefRangeStart = 157353, XrefRangeEnd = 157363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetResponseContainerVisible(bool v)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref v;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x001566F8 File Offset: 0x001548F8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157380, RefRangeEnd = 157382, XrefRangeStart = 157369, XrefRangeEnd = 157380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResponseChosen(Response r, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(r);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00156748 File Offset: 0x00154948
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 157400, RefRangeEnd = 157405, XrefRangeStart = 157382, XrefRangeEnd = 157400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearResponses(bool network = false)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00156788 File Offset: 0x00154988
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 157424, RefRangeEnd = 157427, XrefRangeStart = 157405, XrefRangeEnd = 157424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SendableMessage CreateSendableMessage(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SendableMessage>(intPtr3) : null;
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x001567D8 File Offset: 0x001549D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157427, XrefRangeEnd = 157431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendPlayerMessage(int sendableIndex, int sentIndex, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref sendableIndex;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref sentIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00156834 File Offset: 0x00154A34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157431, XrefRangeEnd = 157438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RenderPlayerMessage(SendableMessage sendable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(sendable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x00156878 File Offset: 0x00154A78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157438, XrefRangeEnd = 157450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckSendLoop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CheckSendLoop_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x001568AC File Offset: 0x00154AAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 157469, RefRangeEnd = 157471, XrefRangeStart = 157450, XrefRangeEnd = 157469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanSendNewMessage()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x001568E8 File Offset: 0x00154AE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157471, XrefRangeEnd = 157474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _CreateUI_b__72_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x0015691C File Offset: 0x00154B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157474, XrefRangeEnd = 157479, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_PDM_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000219C1 File Offset: 0x0001FBC1
		public MSGConversation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x0015695C File Offset: 0x00154B5C
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x000219CA File Offset: 0x0001FBCA
		public unsafe static int MAX_MESSAGE_HISTORY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MSGConversation.NativeFieldInfoPtr_MAX_MESSAGE_HISTORY, (void*)(&value));
			}
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x00156978 File Offset: 0x00154B78
		// (set) Token: 0x06004557 RID: 17751 RVA: 0x000219D8 File Offset: 0x0001FBD8
		public unsafe string contactName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_contactName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06004558 RID: 17752 RVA: 0x001569A0 File Offset: 0x00154BA0
		// (set) Token: 0x06004559 RID: 17753 RVA: 0x000219F7 File Offset: 0x0001FBF7
		public unsafe NPC sender
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sender), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600455A RID: 17754 RVA: 0x001569D0 File Offset: 0x00154BD0
		// (set) Token: 0x0600455B RID: 17755 RVA: 0x00021A16 File Offset: 0x0001FC16
		public unsafe bool _IsSenderKnown_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__IsSenderKnown_k__BackingField)) = value;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600455C RID: 17756 RVA: 0x001569F8 File Offset: 0x00154BF8
		// (set) Token: 0x0600455D RID: 17757 RVA: 0x00021A31 File Offset: 0x0001FC31
		public unsafe List<Message> messageHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x0600455E RID: 17758 RVA: 0x00156A28 File Offset: 0x00154C28
		// (set) Token: 0x0600455F RID: 17759 RVA: 0x00021A50 File Offset: 0x0001FC50
		public unsafe List<MessageChain> messageChainHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageChain>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_messageChainHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x00156A58 File Offset: 0x00154C58
		// (set) Token: 0x06004561 RID: 17761 RVA: 0x00021A6F File Offset: 0x0001FC6F
		public unsafe List<MessageBubble> bubbles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MessageBubble>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x00156A88 File Offset: 0x00154C88
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x00021A8E File Offset: 0x0001FC8E
		public unsafe List<SendableMessage> Sendables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SendableMessage>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Sendables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014D7 RID: 5335
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x00156AB8 File Offset: 0x00154CB8
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x00021AAD File Offset: 0x0001FCAD
		public unsafe bool read
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_read)) = value;
			}
		}

		// Token: 0x170014D8 RID: 5336
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x00156AE0 File Offset: 0x00154CE0
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x00021AC8 File Offset: 0x0001FCC8
		public unsafe int _index_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__index_k__BackingField)) = value;
			}
		}

		// Token: 0x170014D9 RID: 5337
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x00156B08 File Offset: 0x00154D08
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x00021AE3 File Offset: 0x0001FCE3
		public unsafe bool _isOpen_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__isOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x170014DA RID: 5338
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x00156B30 File Offset: 0x00154D30
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x00021AFE File Offset: 0x0001FCFE
		public unsafe bool _rollingOut_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__rollingOut_k__BackingField)) = value;
			}
		}

		// Token: 0x170014DB RID: 5339
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x00156B58 File Offset: 0x00154D58
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x00021B19 File Offset: 0x0001FD19
		public unsafe bool _EntryVisible_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__EntryVisible_k__BackingField)) = value;
			}
		}

		// Token: 0x170014DC RID: 5340
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x00156B80 File Offset: 0x00154D80
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x00021B34 File Offset: 0x0001FD34
		public unsafe List<EConversationCategory> Categories
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<EConversationCategory>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_Categories), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DD RID: 5341
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x00156BB0 File Offset: 0x00154DB0
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x00021B53 File Offset: 0x0001FD53
		public unsafe RectTransform entry
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DE RID: 5342
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x00156BE0 File Offset: 0x00154DE0
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x00021B72 File Offset: 0x0001FD72
		public unsafe RectTransform container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00156C10 File Offset: 0x00154E10
		// (set) Token: 0x06004575 RID: 17781 RVA: 0x00021B91 File Offset: 0x0001FD91
		public unsafe RectTransform bubbleContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_bubbleContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x06004576 RID: 17782 RVA: 0x00156C40 File Offset: 0x00154E40
		// (set) Token: 0x06004577 RID: 17783 RVA: 0x00021BB0 File Offset: 0x0001FDB0
		public unsafe RectTransform scrollRectContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRectContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E1 RID: 5345
		// (get) Token: 0x06004578 RID: 17784 RVA: 0x00156C70 File Offset: 0x00154E70
		// (set) Token: 0x06004579 RID: 17785 RVA: 0x00021BCF File Offset: 0x0001FDCF
		public unsafe ScrollRect scrollRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScrollRect>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_scrollRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x00156CA0 File Offset: 0x00154EA0
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x00021BEE File Offset: 0x0001FDEE
		public unsafe Text entryPreviewText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_entryPreviewText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x00156CD0 File Offset: 0x00154ED0
		// (set) Token: 0x0600457D RID: 17789 RVA: 0x00021C0D File Offset: 0x0001FE0D
		public unsafe RectTransform unreadDot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_unreadDot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x0600457E RID: 17790 RVA: 0x00156D00 File Offset: 0x00154F00
		// (set) Token: 0x0600457F RID: 17791 RVA: 0x00021C2C File Offset: 0x0001FE2C
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x06004580 RID: 17792 RVA: 0x00156D30 File Offset: 0x00154F30
		// (set) Token: 0x06004581 RID: 17793 RVA: 0x00021C4B File Offset: 0x0001FE4B
		public unsafe Image sliderFill
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_sliderFill), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E6 RID: 5350
		// (get) Token: 0x06004582 RID: 17794 RVA: 0x00156D60 File Offset: 0x00154F60
		// (set) Token: 0x06004583 RID: 17795 RVA: 0x00021C6A File Offset: 0x0001FE6A
		public unsafe RectTransform responseContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E7 RID: 5351
		// (get) Token: 0x06004584 RID: 17796 RVA: 0x00156D90 File Offset: 0x00154F90
		// (set) Token: 0x06004585 RID: 17797 RVA: 0x00021C89 File Offset: 0x0001FE89
		public unsafe MessageSenderInterface senderInterface
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageSenderInterface>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_senderInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014E8 RID: 5352
		// (get) Token: 0x06004586 RID: 17798 RVA: 0x00156DC0 File Offset: 0x00154FC0
		// (set) Token: 0x06004587 RID: 17799 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		public unsafe bool uiCreated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_uiCreated)) = value;
			}
		}

		// Token: 0x170014E9 RID: 5353
		// (get) Token: 0x06004588 RID: 17800 RVA: 0x00156DE8 File Offset: 0x00154FE8
		// (set) Token: 0x06004589 RID: 17801 RVA: 0x00021CC3 File Offset: 0x0001FEC3
		public unsafe Action onMessageRendered
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onMessageRendered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EA RID: 5354
		// (get) Token: 0x0600458A RID: 17802 RVA: 0x00156E18 File Offset: 0x00155018
		// (set) Token: 0x0600458B RID: 17803 RVA: 0x00021CE2 File Offset: 0x0001FEE2
		public unsafe Action onLoaded
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onLoaded), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EB RID: 5355
		// (get) Token: 0x0600458C RID: 17804 RVA: 0x00156E48 File Offset: 0x00155048
		// (set) Token: 0x0600458D RID: 17805 RVA: 0x00021D01 File Offset: 0x0001FF01
		public unsafe Action onResponsesShown
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_onResponsesShown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EC RID: 5356
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00156E78 File Offset: 0x00155078
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x00021D20 File Offset: 0x0001FF20
		public unsafe List<Response> currentResponses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Response>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_currentResponses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014ED RID: 5357
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x00156EA8 File Offset: 0x001550A8
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x00021D3F File Offset: 0x0001FF3F
		public unsafe List<RectTransform> responseRects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr_responseRects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EE RID: 5358
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x00156ED8 File Offset: 0x001550D8
		// (set) Token: 0x06004593 RID: 17811 RVA: 0x00021D5E File Offset: 0x0001FF5E
		public unsafe List<string> _LocalExtraFiles_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFiles_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014EF RID: 5359
		// (get) Token: 0x06004594 RID: 17812 RVA: 0x00156F08 File Offset: 0x00155108
		// (set) Token: 0x06004595 RID: 17813 RVA: 0x00021D7D File Offset: 0x0001FF7D
		public unsafe List<string> _LocalExtraFolders_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__LocalExtraFolders_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014F0 RID: 5360
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x00156F38 File Offset: 0x00155138
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x00021D9C File Offset: 0x0001FF9C
		public unsafe bool _HasChanged_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.NativeFieldInfoPtr__HasChanged_k__BackingField)) = value;
			}
		}

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeFieldInfoPtr_MAX_MESSAGE_HISTORY;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeFieldInfoPtr_contactName;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeFieldInfoPtr_sender;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeFieldInfoPtr__IsSenderKnown_k__BackingField;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeFieldInfoPtr_messageHistory;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeFieldInfoPtr_messageChainHistory;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeFieldInfoPtr_bubbles;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeFieldInfoPtr_Sendables;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeFieldInfoPtr_read;

		// Token: 0x04002E63 RID: 11875
		private static readonly IntPtr NativeFieldInfoPtr__index_k__BackingField;

		// Token: 0x04002E64 RID: 11876
		private static readonly IntPtr NativeFieldInfoPtr__isOpen_k__BackingField;

		// Token: 0x04002E65 RID: 11877
		private static readonly IntPtr NativeFieldInfoPtr__rollingOut_k__BackingField;

		// Token: 0x04002E66 RID: 11878
		private static readonly IntPtr NativeFieldInfoPtr__EntryVisible_k__BackingField;

		// Token: 0x04002E67 RID: 11879
		private static readonly IntPtr NativeFieldInfoPtr_Categories;

		// Token: 0x04002E68 RID: 11880
		private static readonly IntPtr NativeFieldInfoPtr_entry;

		// Token: 0x04002E69 RID: 11881
		private static readonly IntPtr NativeFieldInfoPtr_container;

		// Token: 0x04002E6A RID: 11882
		private static readonly IntPtr NativeFieldInfoPtr_bubbleContainer;

		// Token: 0x04002E6B RID: 11883
		private static readonly IntPtr NativeFieldInfoPtr_scrollRectContainer;

		// Token: 0x04002E6C RID: 11884
		private static readonly IntPtr NativeFieldInfoPtr_scrollRect;

		// Token: 0x04002E6D RID: 11885
		private static readonly IntPtr NativeFieldInfoPtr_entryPreviewText;

		// Token: 0x04002E6E RID: 11886
		private static readonly IntPtr NativeFieldInfoPtr_unreadDot;

		// Token: 0x04002E6F RID: 11887
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x04002E70 RID: 11888
		private static readonly IntPtr NativeFieldInfoPtr_sliderFill;

		// Token: 0x04002E71 RID: 11889
		private static readonly IntPtr NativeFieldInfoPtr_responseContainer;

		// Token: 0x04002E72 RID: 11890
		private static readonly IntPtr NativeFieldInfoPtr_senderInterface;

		// Token: 0x04002E73 RID: 11891
		private static readonly IntPtr NativeFieldInfoPtr_uiCreated;

		// Token: 0x04002E74 RID: 11892
		private static readonly IntPtr NativeFieldInfoPtr_onMessageRendered;

		// Token: 0x04002E75 RID: 11893
		private static readonly IntPtr NativeFieldInfoPtr_onLoaded;

		// Token: 0x04002E76 RID: 11894
		private static readonly IntPtr NativeFieldInfoPtr_onResponsesShown;

		// Token: 0x04002E77 RID: 11895
		private static readonly IntPtr NativeFieldInfoPtr_currentResponses;

		// Token: 0x04002E78 RID: 11896
		private static readonly IntPtr NativeFieldInfoPtr_responseRects;

		// Token: 0x04002E79 RID: 11897
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFiles_k__BackingField;

		// Token: 0x04002E7A RID: 11898
		private static readonly IntPtr NativeFieldInfoPtr__LocalExtraFolders_k__BackingField;

		// Token: 0x04002E7B RID: 11899
		private static readonly IntPtr NativeFieldInfoPtr__HasChanged_k__BackingField;

		// Token: 0x04002E7C RID: 11900
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSenderKnown_Public_get_Boolean_0;

		// Token: 0x04002E7D RID: 11901
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSenderKnown_Protected_set_Void_Boolean_0;

		// Token: 0x04002E7E RID: 11902
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_Int32_0;

		// Token: 0x04002E7F RID: 11903
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Protected_set_Void_Int32_0;

		// Token: 0x04002E80 RID: 11904
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002E81 RID: 11905
		private static readonly IntPtr NativeMethodInfoPtr_set_isOpen_Protected_set_Void_Boolean_0;

		// Token: 0x04002E82 RID: 11906
		private static readonly IntPtr NativeMethodInfoPtr_get_rollingOut_Public_get_Boolean_0;

		// Token: 0x04002E83 RID: 11907
		private static readonly IntPtr NativeMethodInfoPtr_set_rollingOut_Protected_set_Void_Boolean_0;

		// Token: 0x04002E84 RID: 11908
		private static readonly IntPtr NativeMethodInfoPtr_get_EntryVisible_Public_get_Boolean_0;

		// Token: 0x04002E85 RID: 11909
		private static readonly IntPtr NativeMethodInfoPtr_set_EntryVisible_Protected_set_Void_Boolean_0;

		// Token: 0x04002E86 RID: 11910
		private static readonly IntPtr NativeMethodInfoPtr_get_AreResponsesActive_Public_get_Boolean_0;

		// Token: 0x04002E87 RID: 11911
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFolderName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002E88 RID: 11912
		private static readonly IntPtr NativeMethodInfoPtr_get_SaveFileName_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04002E89 RID: 11913
		private static readonly IntPtr NativeMethodInfoPtr_get_Loader_Public_Virtual_Final_New_get_Loader_0;

		// Token: 0x04002E8A RID: 11914
		private static readonly IntPtr NativeMethodInfoPtr_get_ShouldSaveUnderFolder_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002E8B RID: 11915
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFiles_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002E8C RID: 11916
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFiles_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002E8D RID: 11917
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalExtraFolders_Public_Virtual_Final_New_get_List_1_String_0;

		// Token: 0x04002E8E RID: 11918
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalExtraFolders_Public_Virtual_Final_New_set_Void_List_1_String_0;

		// Token: 0x04002E8F RID: 11919
		private static readonly IntPtr NativeMethodInfoPtr_get_HasChanged_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04002E90 RID: 11920
		private static readonly IntPtr NativeMethodInfoPtr_set_HasChanged_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x04002E91 RID: 11921
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NPC_String_0;

		// Token: 0x04002E92 RID: 11922
		private static readonly IntPtr NativeMethodInfoPtr_InitializeSaveable_Public_Virtual_New_Void_0;

		// Token: 0x04002E93 RID: 11923
		private static readonly IntPtr NativeMethodInfoPtr_SetCategories_Public_Void_List_1_EConversationCategory_0;

		// Token: 0x04002E94 RID: 11924
		private static readonly IntPtr NativeMethodInfoPtr_MoveToTop_Public_Void_0;

		// Token: 0x04002E95 RID: 11925
		private static readonly IntPtr NativeMethodInfoPtr_CreateUI_Protected_Void_0;

		// Token: 0x04002E96 RID: 11926
		private static readonly IntPtr NativeMethodInfoPtr_EnsureUIExists_Private_Void_0;

		// Token: 0x04002E97 RID: 11927
		private static readonly IntPtr NativeMethodInfoPtr_RefreshPreviewText_Protected_Void_0;

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeMethodInfoPtr_RepositionEntry_Public_Void_0;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr_SetIsKnown_Public_Void_Boolean_0;

		// Token: 0x04002E9A RID: 11930
		private static readonly IntPtr NativeMethodInfoPtr_EntryClicked_Public_Void_0;

		// Token: 0x04002E9B RID: 11931
		private static readonly IntPtr NativeMethodInfoPtr_SetOpen_Public_Void_Boolean_0;

		// Token: 0x04002E9C RID: 11932
		private static readonly IntPtr NativeMethodInfoPtr_RenderMessage_Protected_Virtual_New_Void_Message_0;

		// Token: 0x04002E9D RID: 11933
		private static readonly IntPtr NativeMethodInfoPtr_SetEntryVisibility_Public_Void_Boolean_0;

		// Token: 0x04002E9E RID: 11934
		private static readonly IntPtr NativeMethodInfoPtr_SetRead_Public_Void_Boolean_0;

		// Token: 0x04002E9F RID: 11935
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Void_Message_Boolean_Boolean_0;

		// Token: 0x04002EA0 RID: 11936
		private static readonly IntPtr NativeMethodInfoPtr_SendMessageChain_Public_Void_MessageChain_Single_Boolean_Boolean_0;

		// Token: 0x04002EA1 RID: 11937
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveData_Public_MSGConversationData_0;

		// Token: 0x04002EA2 RID: 11938
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;

		// Token: 0x04002EA3 RID: 11939
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_New_Void_MSGConversationData_0;

		// Token: 0x04002EA4 RID: 11940
		private static readonly IntPtr NativeMethodInfoPtr_SetSliderValue_Public_Void_Single_Color_0;

		// Token: 0x04002EA5 RID: 11941
		private static readonly IntPtr NativeMethodInfoPtr_GetResponse_Public_Response_String_0;

		// Token: 0x04002EA6 RID: 11942
		private static readonly IntPtr NativeMethodInfoPtr_ShowResponses_Public_Void_List_1_Response_Single_Boolean_0;

		// Token: 0x04002EA7 RID: 11943
		private static readonly IntPtr NativeMethodInfoPtr_CreateResponseUI_Protected_Void_Response_0;

		// Token: 0x04002EA8 RID: 11944
		private static readonly IntPtr NativeMethodInfoPtr_RefreshResponseContainer_Private_Void_0;

		// Token: 0x04002EA9 RID: 11945
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponseUI_Protected_Void_0;

		// Token: 0x04002EAA RID: 11946
		private static readonly IntPtr NativeMethodInfoPtr_SetResponseContainerVisible_Public_Void_Boolean_0;

		// Token: 0x04002EAB RID: 11947
		private static readonly IntPtr NativeMethodInfoPtr_ResponseChosen_Public_Void_Response_Boolean_0;

		// Token: 0x04002EAC RID: 11948
		private static readonly IntPtr NativeMethodInfoPtr_ClearResponses_Public_Void_Boolean_0;

		// Token: 0x04002EAD RID: 11949
		private static readonly IntPtr NativeMethodInfoPtr_CreateSendableMessage_Public_SendableMessage_String_0;

		// Token: 0x04002EAE RID: 11950
		private static readonly IntPtr NativeMethodInfoPtr_SendPlayerMessage_Public_Void_Int32_Int32_Boolean_0;

		// Token: 0x04002EAF RID: 11951
		private static readonly IntPtr NativeMethodInfoPtr_RenderPlayerMessage_Public_Void_SendableMessage_0;

		// Token: 0x04002EB0 RID: 11952
		private static readonly IntPtr NativeMethodInfoPtr_CheckSendLoop_Private_Void_0;

		// Token: 0x04002EB1 RID: 11953
		private static readonly IntPtr NativeMethodInfoPtr_CanSendNewMessage_Private_Boolean_0;

		// Token: 0x04002EB2 RID: 11954
		private static readonly IntPtr NativeMethodInfoPtr__CreateUI_b__72_0_Private_Void_0;

		// Token: 0x04002EB3 RID: 11955
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_PDM_0;

		// Token: 0x0200096B RID: 2411
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<<CheckSendLoop>g__Loop|99_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600C952 RID: 51538 RVA: 0x0030BDC4 File Offset: 0x00309FC4
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique()
			{
				Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<<CheckSendLoop>g__Loop|99_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>1__state");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>2__current");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, "<>4__this");
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671828);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671829);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671830);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671831);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671832);
				MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr, 100671833);
			}

			// Token: 0x0600C953 RID: 51539 RVA: 0x0030BEA4 File Offset: 0x0030A0A4
			[CallerCount(61)]
			[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref <>1__state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C954 RID: 51540 RVA: 0x0030BEEC File Offset: 0x0030A0EC
			[CallerCount(13604)]
			[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C955 RID: 51541 RVA: 0x0030BF20 File Offset: 0x0030A120
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156408, XrefRangeEnd = 156420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x17003ECF RID: 16079
			// (get) Token: 0x0600C956 RID: 51542 RVA: 0x0030BF5C File Offset: 0x0030A15C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C957 RID: 51543 RVA: 0x0030BF9C File Offset: 0x0030A19C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156420, XrefRangeEnd = 156425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x17003ED0 RID: 16080
			// (get) Token: 0x0600C958 RID: 51544 RVA: 0x0030BFD0 File Offset: 0x0030A1D0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(14)]
				[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600C959 RID: 51545 RVA: 0x00061EA3 File Offset: 0x000600A3
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ECC RID: 16076
			// (get) Token: 0x0600C95A RID: 51546 RVA: 0x0030C010 File Offset: 0x0030A210
			// (set) Token: 0x0600C95B RID: 51547 RVA: 0x00061EAC File Offset: 0x000600AC
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17003ECD RID: 16077
			// (get) Token: 0x0600C95C RID: 51548 RVA: 0x0030C038 File Offset: 0x0030A238
			// (set) Token: 0x0600C95D RID: 51549 RVA: 0x00061EC7 File Offset: 0x000600C7
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ECE RID: 16078
			// (get) Token: 0x0600C95E RID: 51550 RVA: 0x0030C068 File Offset: 0x0030A268
			// (set) Token: 0x0600C95F RID: 51551 RVA: 0x00061EE6 File Offset: 0x000600E6
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMSObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008848 RID: 34888
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008849 RID: 34889
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400884A RID: 34890
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400884B RID: 34891
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400884C RID: 34892
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400884D RID: 34893
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400884E RID: 34894
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400884F RID: 34895
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008850 RID: 34896
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x0200096C RID: 2412
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c")]
		[Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C960 RID: 51552 RVA: 0x0030C098 File Offset: 0x0030A298
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr);
				MSGConversation.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9");
				MSGConversation.__c.NativeFieldInfoPtr___9__100_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, "<>9__100_0");
				MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100671835);
				MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr, 100671836);
			}

			// Token: 0x0600C961 RID: 51553 RVA: 0x0030C114 File Offset: 0x0030A314
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C962 RID: 51554 RVA: 0x0030C150 File Offset: 0x0030A350
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156425, XrefRangeEnd = 156426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _CanSendNewMessage_b__100_0(SendableMessage x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c.NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C963 RID: 51555 RVA: 0x00061F05 File Offset: 0x00060105
			public __c(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED1 RID: 16081
			// (get) Token: 0x0600C964 RID: 51556 RVA: 0x0030C1A0 File Offset: 0x0030A3A0
			// (set) Token: 0x0600C965 RID: 51557 RVA: 0x00061F0E File Offset: 0x0006010E
			public unsafe static MSGConversation.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED2 RID: 16082
			// (get) Token: 0x0600C966 RID: 51558 RVA: 0x0030C1C8 File Offset: 0x0030A3C8
			// (set) Token: 0x0600C967 RID: 51559 RVA: 0x00061F20 File Offset: 0x00060120
			public unsafe static Func<SendableMessage, bool> __9__100_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SendableMessage, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(MSGConversation.__c.NativeFieldInfoPtr___9__100_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008851 RID: 34897
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008852 RID: 34898
			private static readonly IntPtr NativeFieldInfoPtr___9__100_0;

			// Token: 0x04008853 RID: 34899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008854 RID: 34900
			private static readonly IntPtr NativeMethodInfoPtr__CanSendNewMessage_b__100_0_Internal_Boolean_SendableMessage_0;
		}

		// Token: 0x0200096D RID: 2413
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass82_0")]
		public sealed class __c__DisplayClass82_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C968 RID: 51560 RVA: 0x0030C1F0 File Offset: 0x0030A3F0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass82_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass82_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, "message");
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100671837);
				MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr, 100671838);
			}

			// Token: 0x0600C969 RID: 51561 RVA: 0x0030C258 File Offset: 0x0030A458
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass82_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass82_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C96A RID: 51562 RVA: 0x0030C294 File Offset: 0x0030A494
			[CallerCount(0)]
			public unsafe bool _SendMessage_b__0(Message x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass82_0.NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C96B RID: 51563 RVA: 0x00061F32 File Offset: 0x00060132
			public __c__DisplayClass82_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED3 RID: 16083
			// (get) Token: 0x0600C96C RID: 51564 RVA: 0x0030C2E4 File Offset: 0x0030A4E4
			// (set) Token: 0x0600C96D RID: 51565 RVA: 0x00061F3B File Offset: 0x0006013B
			public unsafe Message message
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Message>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass82_0.NativeFieldInfoPtr_message), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008855 RID: 34901
			private static readonly IntPtr NativeFieldInfoPtr_message;

			// Token: 0x04008856 RID: 34902
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008857 RID: 34903
			private static readonly IntPtr NativeMethodInfoPtr__SendMessage_b__0_Internal_Boolean_Message_0;
		}

		// Token: 0x0200096E RID: 2414
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0")]
		public sealed class __c__DisplayClass83_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C96E RID: 51566 RVA: 0x0030C314 File Offset: 0x0030A514
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass83_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass83_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "messages");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "notify");
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671839);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671840);
				MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, 100671841);
			}

			// Token: 0x0600C96F RID: 51567 RVA: 0x0030C3B8 File Offset: 0x0030A5B8
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass83_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C970 RID: 51568 RVA: 0x0030C3F4 File Offset: 0x0030A5F4
			[CallerCount(0)]
			public unsafe bool _SendMessageChain_b__0(MessageChain x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C971 RID: 51569 RVA: 0x0030C444 File Offset: 0x0030A644
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156476, XrefRangeEnd = 156482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_MessageChain_Single_PDM_0(MessageChain messageChain, float initialDelay)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(messageChain);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref initialDelay;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C972 RID: 51570 RVA: 0x00061F5A File Offset: 0x0006015A
			public __c__DisplayClass83_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED4 RID: 16084
			// (get) Token: 0x0600C973 RID: 51571 RVA: 0x0030C4A4 File Offset: 0x0030A6A4
			// (set) Token: 0x0600C974 RID: 51572 RVA: 0x00061F63 File Offset: 0x00060163
			public unsafe MessageChain messages
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_messages), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED5 RID: 16085
			// (get) Token: 0x0600C975 RID: 51573 RVA: 0x0030C4D4 File Offset: 0x0030A6D4
			// (set) Token: 0x0600C976 RID: 51574 RVA: 0x00061F82 File Offset: 0x00060182
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003ED6 RID: 16086
			// (get) Token: 0x0600C977 RID: 51575 RVA: 0x0030C504 File Offset: 0x0030A704
			// (set) Token: 0x0600C978 RID: 51576 RVA: 0x00061FA1 File Offset: 0x000601A1
			public unsafe bool notify
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.NativeFieldInfoPtr_notify)) = value;
				}
			}

			// Token: 0x04008858 RID: 34904
			private static readonly IntPtr NativeFieldInfoPtr_messages;

			// Token: 0x04008859 RID: 34905
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400885A RID: 34906
			private static readonly IntPtr NativeFieldInfoPtr_notify;

			// Token: 0x0400885B RID: 34907
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400885C RID: 34908
			private static readonly IntPtr NativeMethodInfoPtr__SendMessageChain_b__0_Internal_Boolean_MessageChain_0;

			// Token: 0x0400885D RID: 34909
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_MessageChain_Single_PDM_0;

			// Token: 0x02000C41 RID: 3137
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass83_0+<<SendMessageChain>g__Routine|1>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E22D RID: 57901 RVA: 0x00352160 File Offset: 0x00350360
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0>.NativeClassPtr, "<<SendMessageChain>g__Routine|1>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "messageChain");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "initialDelay");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<messageClasses>5__2");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, "<i>5__3");
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671842);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671843);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671844);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671845);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671846);
					MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr, 100671847);
				}

				// Token: 0x0600E22E RID: 57902 RVA: 0x00352290 File Offset: 0x00350490
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E22F RID: 57903 RVA: 0x003522D8 File Offset: 0x003504D8
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E230 RID: 57904 RVA: 0x0035230C File Offset: 0x0035050C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156426, XrefRangeEnd = 156471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x17004626 RID: 17958
				// (get) Token: 0x0600E231 RID: 57905 RVA: 0x00352348 File Offset: 0x00350548
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E232 RID: 57906 RVA: 0x00352388 File Offset: 0x00350588
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156471, XrefRangeEnd = 156476, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x17004627 RID: 17959
				// (get) Token: 0x0600E233 RID: 57907 RVA: 0x003523BC File Offset: 0x003505BC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E234 RID: 57908 RVA: 0x0006E426 File Offset: 0x0006C626
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x1700461F RID: 17951
				// (get) Token: 0x0600E235 RID: 57909 RVA: 0x003523FC File Offset: 0x003505FC
				// (set) Token: 0x0600E236 RID: 57910 RVA: 0x0006E42F File Offset: 0x0006C62F
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004620 RID: 17952
				// (get) Token: 0x0600E237 RID: 57911 RVA: 0x00352424 File Offset: 0x00350624
				// (set) Token: 0x0600E238 RID: 57912 RVA: 0x0006E44A File Offset: 0x0006C64A
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004621 RID: 17953
				// (get) Token: 0x0600E239 RID: 57913 RVA: 0x00352454 File Offset: 0x00350654
				// (set) Token: 0x0600E23A RID: 57914 RVA: 0x0006E469 File Offset: 0x0006C669
				public unsafe MSGConversation.__c__DisplayClass83_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass83_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004622 RID: 17954
				// (get) Token: 0x0600E23B RID: 57915 RVA: 0x00352484 File Offset: 0x00350684
				// (set) Token: 0x0600E23C RID: 57916 RVA: 0x0006E488 File Offset: 0x0006C688
				public unsafe MessageChain messageChain
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MessageChain>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_messageChain), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004623 RID: 17955
				// (get) Token: 0x0600E23D RID: 57917 RVA: 0x003524B4 File Offset: 0x003506B4
				// (set) Token: 0x0600E23E RID: 57918 RVA: 0x0006E4A7 File Offset: 0x0006C6A7
				public unsafe float initialDelay
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr_initialDelay)) = value;
					}
				}

				// Token: 0x17004624 RID: 17956
				// (get) Token: 0x0600E23F RID: 57919 RVA: 0x003524DC File Offset: 0x003506DC
				// (set) Token: 0x0600E240 RID: 57920 RVA: 0x0006E4C2 File Offset: 0x0006C6C2
				public unsafe List<Message> _messageClasses_5__2
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Message>>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__messageClasses_5__2), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004625 RID: 17957
				// (get) Token: 0x0600E241 RID: 57921 RVA: 0x0035250C File Offset: 0x0035070C
				// (set) Token: 0x0600E242 RID: 57922 RVA: 0x0006E4E1 File Offset: 0x0006C6E1
				public unsafe int _i_5__3
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass83_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObMemeSiinLi1MeInUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009768 RID: 38760
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009769 RID: 38761
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x0400976A RID: 38762
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x0400976B RID: 38763
				private static readonly IntPtr NativeFieldInfoPtr_messageChain;

				// Token: 0x0400976C RID: 38764
				private static readonly IntPtr NativeFieldInfoPtr_initialDelay;

				// Token: 0x0400976D RID: 38765
				private static readonly IntPtr NativeFieldInfoPtr__messageClasses_5__2;

				// Token: 0x0400976E RID: 38766
				private static readonly IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x0400976F RID: 38767
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009770 RID: 38768
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009771 RID: 38769
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009772 RID: 38770
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009773 RID: 38771
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009774 RID: 38772
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x0200096F RID: 2415
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass88_0")]
		public sealed class __c__DisplayClass88_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C979 RID: 51577 RVA: 0x0030C52C File Offset: 0x0030A72C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass88_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass88_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, "label");
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100671848);
				MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr, 100671849);
			}

			// Token: 0x0600C97A RID: 51578 RVA: 0x0030C594 File Offset: 0x0030A794
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass88_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass88_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C97B RID: 51579 RVA: 0x0030C5D0 File Offset: 0x0030A7D0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156482, XrefRangeEnd = 156484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResponse_b__0(Response x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass88_0.NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600C97C RID: 51580 RVA: 0x00061FBC File Offset: 0x000601BC
			public __c__DisplayClass88_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED7 RID: 16087
			// (get) Token: 0x0600C97D RID: 51581 RVA: 0x0030C620 File Offset: 0x0030A820
			// (set) Token: 0x0600C97E RID: 51582 RVA: 0x00061FC5 File Offset: 0x000601C5
			public unsafe string label
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass88_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400885E RID: 34910
			private static readonly IntPtr NativeFieldInfoPtr_label;

			// Token: 0x0400885F RID: 34911
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008860 RID: 34912
			private static readonly IntPtr NativeMethodInfoPtr__GetResponse_b__0_Internal_Boolean_Response_0;
		}

		// Token: 0x02000970 RID: 2416
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0")]
		public sealed class __c__DisplayClass89_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C97F RID: 51583 RVA: 0x0030C648 File Offset: 0x0030A848
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass89_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass89_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "showResponseDelay");
				MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100671850);
				MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, 100671851);
			}

			// Token: 0x0600C980 RID: 51584 RVA: 0x0030C6C4 File Offset: 0x0030A8C4
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass89_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C981 RID: 51585 RVA: 0x0030C700 File Offset: 0x0030A900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156494, XrefRangeEnd = 156499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}

			// Token: 0x0600C982 RID: 51586 RVA: 0x00061FE4 File Offset: 0x000601E4
			public __c__DisplayClass89_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003ED8 RID: 16088
			// (get) Token: 0x0600C983 RID: 51587 RVA: 0x0030C740 File Offset: 0x0030A940
			// (set) Token: 0x0600C984 RID: 51588 RVA: 0x00061FED File Offset: 0x000601ED
			public unsafe float showResponseDelay
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr_showResponseDelay)) = value;
				}
			}

			// Token: 0x17003ED9 RID: 16089
			// (get) Token: 0x0600C985 RID: 51589 RVA: 0x0030C768 File Offset: 0x0030A968
			// (set) Token: 0x0600C986 RID: 51590 RVA: 0x00062008 File Offset: 0x00060208
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008861 RID: 34913
			private static readonly IntPtr NativeFieldInfoPtr_showResponseDelay;

			// Token: 0x04008862 RID: 34914
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008863 RID: 34915
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008864 RID: 34916
			private static readonly IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000C42 RID: 3138
			[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass89_0+<<ShowResponses>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E243 RID: 57923 RVA: 0x00352534 File Offset: 0x00350734
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique()
				{
					Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0>.NativeClassPtr, "<<ShowResponses>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>1__state");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>2__current");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, "<>4__this");
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671852);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671853);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671854);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671855);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671856);
					MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr, 100671857);
				}

				// Token: 0x0600E244 RID: 57924 RVA: 0x00352614 File Offset: 0x00350814
				[CallerCount(61)]
				[CachedScanResults(RefRangeStart = 2329, RefRangeEnd = 2390, XrefRangeStart = 2329, XrefRangeEnd = 2390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique>.NativeClassPtr))
				{
					IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E245 RID: 57925 RVA: 0x0035265C File Offset: 0x0035085C
				[CallerCount(13604)]
				[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x0600E246 RID: 57926 RVA: 0x00352690 File Offset: 0x00350890
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156484, XrefRangeEnd = 156489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}

				// Token: 0x1700462B RID: 17963
				// (get) Token: 0x0600E247 RID: 57927 RVA: 0x003526CC File Offset: 0x003508CC
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E248 RID: 57928 RVA: 0x0035270C File Offset: 0x0035090C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156489, XrefRangeEnd = 156494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x1700462C RID: 17964
				// (get) Token: 0x0600E249 RID: 57929 RVA: 0x00352740 File Offset: 0x00350940
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(14)]
					[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IntPtr* ptr = null;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
						IntPtr intPtr3 = intPtr;
						return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr3) : null;
					}
				}

				// Token: 0x0600E24A RID: 57930 RVA: 0x0006E4FC File Offset: 0x0006C6FC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique(IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004628 RID: 17960
				// (get) Token: 0x0600E24B RID: 57931 RVA: 0x00352780 File Offset: 0x00350980
				// (set) Token: 0x0600E24C RID: 57932 RVA: 0x0006E505 File Offset: 0x0006C705
				public unsafe int __1__state
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004629 RID: 17961
				// (get) Token: 0x0600E24D RID: 57933 RVA: 0x003527A8 File Offset: 0x003509A8
				// (set) Token: 0x0600E24E RID: 57934 RVA: 0x0006E520 File Offset: 0x0006C720
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700462A RID: 17962
				// (get) Token: 0x0600E24F RID: 57935 RVA: 0x003527D8 File Offset: 0x003509D8
				// (set) Token: 0x0600E250 RID: 57936 RVA: 0x0006E53F File Offset: 0x0006C73F
				public unsafe MSGConversation.__c__DisplayClass89_0 __4__this
				{
					get
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this);
						IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation.__c__DisplayClass89_0>(intPtr2) : null;
					}
					set
					{
						IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass89_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x04009775 RID: 38773
				private static readonly IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009776 RID: 38774
				private static readonly IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009777 RID: 38775
				private static readonly IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009778 RID: 38776
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009779 RID: 38777
				private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400977A RID: 38778
				private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x0400977B RID: 38779
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x0400977C RID: 38780
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x0400977D RID: 38781
				private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}

		// Token: 0x02000971 RID: 2417
		[ObfuscatedName("ScheduleOne.Messaging.MSGConversation+<>c__DisplayClass90_0")]
		public sealed class __c__DisplayClass90_0 : Il2CppSystem.Object
		{
			// Token: 0x0600C987 RID: 51591 RVA: 0x0030C798 File Offset: 0x0030A998
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass90_0()
			{
				Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<MSGConversation>.NativeClassPtr, "<>c__DisplayClass90_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr);
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "<>4__this");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "r");
				MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, "network");
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100671858);
				MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr, 100671859);
			}

			// Token: 0x0600C988 RID: 51592 RVA: 0x0030C828 File Offset: 0x0030AA28
			[CallerCount(2259)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass90_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MSGConversation.__c__DisplayClass90_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C989 RID: 51593 RVA: 0x0030C864 File Offset: 0x0030AA64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156499, XrefRangeEnd = 156515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateResponseUI_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MSGConversation.__c__DisplayClass90_0.NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600C98A RID: 51594 RVA: 0x00062027 File Offset: 0x00060227
			public __c__DisplayClass90_0(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003EDA RID: 16090
			// (get) Token: 0x0600C98B RID: 51595 RVA: 0x0030C898 File Offset: 0x0030AA98
			// (set) Token: 0x0600C98C RID: 51596 RVA: 0x00062030 File Offset: 0x00060230
			public unsafe MSGConversation __4__this
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MSGConversation>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDB RID: 16091
			// (get) Token: 0x0600C98D RID: 51597 RVA: 0x0030C8C8 File Offset: 0x0030AAC8
			// (set) Token: 0x0600C98E RID: 51598 RVA: 0x0006204F File Offset: 0x0006024F
			public unsafe Response r
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Response>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_r), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003EDC RID: 16092
			// (get) Token: 0x0600C98F RID: 51599 RVA: 0x0030C8F8 File Offset: 0x0030AAF8
			// (set) Token: 0x0600C990 RID: 51600 RVA: 0x0006206E File Offset: 0x0006026E
			public unsafe bool network
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MSGConversation.__c__DisplayClass90_0.NativeFieldInfoPtr_network)) = value;
				}
			}

			// Token: 0x04008865 RID: 34917
			private static readonly IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008866 RID: 34918
			private static readonly IntPtr NativeFieldInfoPtr_r;

			// Token: 0x04008867 RID: 34919
			private static readonly IntPtr NativeFieldInfoPtr_network;

			// Token: 0x04008868 RID: 34920
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008869 RID: 34921
			private static readonly IntPtr NativeMethodInfoPtr__CreateResponseUI_b__0_Internal_Void_0;
		}
	}
}
